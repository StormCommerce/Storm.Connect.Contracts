using System;
using System.Runtime.Serialization;


namespace Enferno.Services.StormConnect.Contracts.Job
{
    [DataContract]
    public class JobLogDto
    {
        [DataMember]
        public int SeverityId { get; set; }
        [DataMember]
        public string Message { get; set; }
        [DataMember]
        public DateTime TimeStamp { get; set; }
        [DataMember]
        public string ImportedRow { get; set; }
    }
}
