﻿using System;
using System.Runtime.Serialization;

namespace Enferno.Services.StormConnect.Contracts.Common
{
    [DataContract(Name = "Image", Namespace = "Enferno.Services.StormConnect.Contracts.Common")]
    public class Image
    {
        [DataMember(Order = 1)]
        public string FileTypeName { get; set; }

        [DataMember(Order = 2)]
        public string ExternalCode { get; set; }

        [DataMember(Order = 3)]
        public string Filename { get; set; }

        [DataMember(Order = 4)]
        public string Url { get; set; }

        [DataMember(Order = 5)]
        public DateTime? LastModified { get; set; }

        [DataMember(Order = 6)]
        public LocalizedString Name { get; set; }

        [DataMember(Order = 7)]
        public LocalizedString Description { get; set; }

        [DataMember(Order = 8)]
        public bool? IsVariantUnique { get; set; }

        [DataMember(Order = 9)]
        public bool? IsActive { get; set; }
    }
}