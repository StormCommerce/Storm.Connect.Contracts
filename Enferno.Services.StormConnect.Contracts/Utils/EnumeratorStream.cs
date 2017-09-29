using System;
using System.Collections;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace Enferno.Services.StormConnect.Contracts.Utils
{
    public class EnumeratorStream : Stream
    {
        public SerializationType SerializationType { get; set; }
        private readonly IEnumerator enumerator;

        public EnumeratorStream(IEnumerator enumerator, SerializationType serializationType = SerializationType.Json)
        {
            SerializationType = serializationType;
            this.enumerator = enumerator;
        }

        public EnumeratorStream(IEnumerable enumerable, SerializationType serializationType = SerializationType.Json)
        {
            SerializationType = serializationType;
            enumerator = enumerable.GetEnumerator();
        }

        private byte[] bufferPrivate;
        private int bufferRead;

        public override int Read(byte[] buffer, int offset, int count)
        {
            if (bufferPrivate == null || bufferPrivate.Length == bufferRead)
            {
                bufferRead = 0;
                if (!enumerator.MoveNext())
                {
                    return 0;
                }
                if (SerializationType == SerializationType.Json)
                {
                    var jsonSerializerSettings = new JsonSerializerSettings
                    {
                        NullValueHandling = NullValueHandling.Ignore
                    };
                    var str = JsonConvert.SerializeObject(enumerator.Current, Formatting.None, jsonSerializerSettings);
                    bufferPrivate = Encoding.UTF8.GetBytes(str);
                }
                else if (SerializationType == SerializationType.DataContractSerializer)
                {
                    var dcs = new DataContractSerializer(enumerator.Current.GetType());
                    using (var ms = new MemoryStream())
                    {
                        dcs.WriteObject(ms, enumerator.Current);
                        bufferPrivate = ms.ToArray();
                    }
                }
            }

            if (bufferPrivate == null)
            {
                return 0;
            }

            var bytesToCopy = Math.Min(count, bufferPrivate.Length - bufferRead);
            Buffer.BlockCopy(bufferPrivate, bufferRead, buffer, offset, bytesToCopy);
            bufferRead += bytesToCopy;

            return bytesToCopy;
        }

        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }

        public override void Flush()
        {
            throw new NotImplementedException();
        }

        public override long Seek(long offset, SeekOrigin origin)
        {
            throw new NotImplementedException();
        }

        public override void SetLength(long value)
        {
            throw new NotImplementedException();
        }

        public override void Write(byte[] buffer, int offset, int count)
        {
            throw new NotImplementedException();
        }

        public override bool CanRead => true;

        public override bool CanSeek => false;

        public override bool CanWrite => false;

        public override long Length
        {
            get { throw new NotImplementedException(); }
        }

        public override long Position { get; set; }
    }
}
