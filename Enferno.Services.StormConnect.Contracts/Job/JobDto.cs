using System;
using System.Runtime.Serialization;

namespace Enferno.Services.StormConnect.Contracts.Job
{
    [DataContract]
    public class JobDto
    {
        [DataMember]
        public int JobId { get; set; }
        [DataMember]
        public int StatusId { get; set; }
        [DataMember]
        public string StorageName { get; set; }
        [DataMember]
        public int Totals { get; set; }
        [DataMember]
        public int Inserts { get; set; }
        [DataMember]
        public int Updates { get; set; }
        [DataMember]
        public int Fail { get; set; }
        [DataMember]
        public DateTime Start { get; set; }
        [DataMember]
        public DateTime? Stop { get; set; }
        [DataMember]
        public System.DateTime LastUpdated { get; set; }
        [DataMember]
        public bool IsFinished { get; set; }
        [DataMember]
        public TimeSpan RunTime { get; set; }
    }
}