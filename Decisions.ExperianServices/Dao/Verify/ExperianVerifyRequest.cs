using System.Runtime.Serialization;
using Decisions.ExperianServices.Dao.CreditReport;
using DecisionsFramework.Design.ConfigurationStorage.Attributes;
using Newtonsoft.Json;

namespace Decisions.ExperianServices.Dao.Verify
{
    [DataContract]
    [Writable]
    public class ExperianVerifyRequest : ExperianCreditReportRequest
    {
        [DataContract]
        [Writable]
        public new class ConsumerPii
        {
            [DataMember]
            [WritableValue]
            [JsonProperty("applicantInformation")]
            public ApplicantInformation ApplicantInformation { get; set; }
        }
        
        [DataContract]
        [Writable]
        public class ApplicantInformation
        {
            [DataMember]
            [WritableValue]
            [JsonProperty("name")]
            public Name Name { get; set; }

            [DataMember]
            [WritableValue]
            [JsonProperty("ssn")]
            public Ssn Ssn { get; set; }

            [DataMember]
            [WritableValue]
            [JsonProperty("dob")]
            public Dob Dob { get; set; }

            [DataMember]
            [WritableValue]
            [JsonProperty("phone")]
            public Phone[] Phone { get; set; }

            [DataMember]
            [WritableValue]
            [JsonProperty("currentAddress")]
            public CurrentAddress CurrentAddress { get; set; }
        }
        
        [DataContract]
        [Writable]
        public class CurrentAddress
        {
            [DataMember]
            [WritableValue]
            [JsonProperty("line1")]
            public string Line1 { get; set; }

            [DataMember]
            [WritableValue]
            [JsonProperty("line2")]
            public string Line2 { get; set; }

            [DataMember]
            [WritableValue]
            [JsonProperty("line3")]
            public string Line3 { get; set; }

            [DataMember]
            [WritableValue]
            [JsonProperty("city")]
            public string City { get; set; }

            [DataMember]
            [WritableValue]
            [JsonProperty("state")]
            public string State { get; set; }

            [DataMember]
            [WritableValue]
            [JsonProperty("zipCode")]
            public long ZipCode { get; set; }
        }
        
        [DataContract]
        [Writable]
        public new class Requestor
        {
            [DataMember]
            [WritableValue]
            [JsonProperty("subscriberCode")]
            public string SubscriberCode { get; set; }
            
            [DataMember]
            [WritableValue]
            [JsonProperty("verifierName")]
            public string VerifierName { get; set; }
        }
    }
}