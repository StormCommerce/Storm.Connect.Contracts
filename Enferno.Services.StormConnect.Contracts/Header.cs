using System.Runtime.Serialization;

namespace Enferno.Services.StormConnect.Contracts
{
    [DataContract(Name = "Header", Namespace = "Enferno.Services.StormConnect.Contracts")]
    public class Header
    {
        public Header()
        {
            
        }

        public Header(Header oldHeader)
        {
            JobId = oldHeader.JobId;
            StorageName = oldHeader.StorageName;
            AccountId = oldHeader.AccountId;
            SerializationType = oldHeader.SerializationType;
            SupplierId = oldHeader.SupplierId;
        }

        [DataMember(Order = 2)]
        public int? SupplierId { get; set; }

        /// <summary>
        /// Just used as a return value to the caller and a handle to the workers.
        /// </summary>
        [DataMember(Order = 6)]
        public string JobId { get; set; }

        /// <summary>
        /// Just used as a return value to the caller and a handle to the workers. Can be used to rerun a failed import if set from the caller.
        /// </summary>
        [DataMember(Order = 7)]
        public string StorageName { get; set; }

        [DataMember(Order = 8)]
        public SerializationType SerializationType { get; set; }

        [DataMember]
        public int AccountId { get; set; }
    }
}
