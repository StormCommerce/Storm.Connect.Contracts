using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Enferno.Services.StormConnect.Contracts.Utils
{
    public class MyRequest<T, T2>
    {
        public MyRequest(T header, IEnumerable<T2> data)
        {
            Header = header;
            Data = data;
        }

        public T Header { get; set; }
        public IEnumerable<T2> Data { get; set; }

        public Stream GetStream(SerializationType serializationType = SerializationType.Json)
        {
            return new EnumeratorStream(Items().GetEnumerator(), serializationType);
        }

        public IEnumerable Items()
        {
            return Data.Select(item => (object) item);
        }
    }
}
