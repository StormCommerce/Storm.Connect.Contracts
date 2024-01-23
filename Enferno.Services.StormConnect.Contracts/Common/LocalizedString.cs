using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Enferno.Services.StormConnect.Contracts.Common
{
    [DataContract(Name = "LocalizedString", Namespace = "Enferno.Services.StormConnect.Contracts.Common")]
    public class LocalizedString
    {
        [DataMember(Order = 1)]
        public string Default { get; set; }

        [DataMember(Order = 2)]
        public Dictionary<string, string> Cultures { get; set; }

        public string GetByCultureOrDefault(string culture)
        {
            if (culture == null || Cultures == null) return Default;

            return Cultures.TryGetValue(culture, out var value) ? value : Default;
        }
    }
}
