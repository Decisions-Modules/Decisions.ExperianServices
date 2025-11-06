using System.Runtime.Serialization;
using DecisionsFramework.Design.ConfigurationStorage.Attributes;
using Newtonsoft.Json;

namespace Decisions.ExperianServices.Dao.PremierProfiles
{
    [Writable, DataContract]
    public class ExperianPremierProfilesRequest
    {
        [WritableValue, DataMember]
        [JsonProperty("bin")]
        public string Bin { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("name")]
        public string Name { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("street")]
        public string Street { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("city")]
        public string City { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("state")]
        public string State { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("zip")]
        public string Zip { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("phone")]
        public string Phone { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("taxId")]
        public string TaxId { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("subcode")]
        public string Subcode { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("modelCode")]
        public string ModelCode { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("comments")]
        public string Comments { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("businessAggregates")]
        public bool? BusinessAggregates { get; set; } = false;
    }
}
