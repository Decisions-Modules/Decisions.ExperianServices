using System.Runtime.Serialization;
using Decisions.ExperianServices.Dao.CreditReport;
using DecisionsFramework.Design.ConfigurationStorage.Attributes;
using Newtonsoft.Json;

namespace Decisions.ExperianServices.Dao.Verify
{
    [DataContract]
    [Writable]
    public class ExperianVerifyRequest
    {
        [DataMember]
        [WritableValue]
        [JsonProperty("consumerPii")]
        public ConsumerPii ConsumerPii { get; set; }

        [DataMember]
        [WritableValue]
        [JsonProperty("requestor")]
        public Requestor Requestor { get; set; }

        [DataMember]
        [WritableValue]
        [JsonProperty("permissiblePurpose")]
        public PermissiblePurpose PermissiblePurpose { get; set; }

        [DataMember]
        [WritableValue]
        [JsonProperty("resellerInfo")]
        public ResellerInfo ResellerInfo { get; set; }
        
        [DataMember]
        [WritableValue]
        [JsonProperty("reportType")]
        public string ReportType { get; set; }

        [DataMember]
        [WritableValue]
        [JsonProperty("vendorData")]
        public VendorData VendorData { get; set; }

        [DataMember]
        [WritableValue]
        [JsonProperty("customOptions")]
        public CustomOptions CustomOptions { get; set; }
        
        [DataMember]
        [WritableValue]
        [JsonProperty("reportCustomLabels")]
        public ReportCustomLabels ReportCustomLabels { get; set; }
    }
    
    [DataContract]
    [Writable]
    public partial class ConsumerPii
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
        public string ZipCode { get; set; }
    }
    
    [DataContract]
    [Writable]
    public class Requestor
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