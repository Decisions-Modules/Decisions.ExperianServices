using System;
using System.Runtime.Serialization;
using DecisionsFramework.Design.ConfigurationStorage.Attributes;
using Newtonsoft.Json;

namespace Decisions.ExperianServices.Dao.Verify
{
    [DataContract]
    [Writable]
    public class ExperianVerifyResponse
    {
        [DataMember]
        [WritableValue]
        [JsonProperty("expVerifyReport")]
        public ExpVerifyReport ExpVerifyReport { get; set; }

        [DataMember]
        [WritableValue]
        [JsonProperty("pdfBytes")]
        public string PdfBytes { get; set; }
    }
    
    [DataContract]
    [Writable]
    public class ExpVerifyReport
    {
        [JsonProperty("reportId")]
        public Guid ReportId { get; set; }

        [JsonProperty("reportType")]
        public string ReportType { get; set; }

        [JsonProperty("reportGeneratedDate")]
        public string ReportGeneratedDate { get; set; }

        [JsonProperty("requestor")]
        public Requestor Requestor { get; set; }

        [JsonProperty("consumerPii")]
        public ConsumerPii ConsumerPii { get; set; }

        [JsonProperty("reportCustomLabels")]
        public ReportCustomLabels ReportCustomLabels { get; set; }
    }

    public partial class ConsumerPii
    {
        [JsonProperty("employmentHistory")]
        public EmploymentHistory[] EmploymentHistory { get; set; }
    }

    [DataContract]
    [Writable]
    public class EmploymentHistory
    {
        [JsonProperty("asOfDate")]
        public string AsOfDate { get; set; }

        [JsonProperty("originReportId")]
        public string OriginReportId { get; set; }

        [JsonProperty("originSourceId")]
        public string OriginSourceId { get; set; }

        [JsonProperty("employerIdentificationNumber")]
        public string EmployerIdentificationNumber { get; set; }

        [JsonProperty("employerName")]
        public string EmployerName { get; set; }

        [JsonProperty("employerAddress")]
        public EmployerAddress EmployerAddress { get; set; }

        [JsonProperty("originalHireDate")]
        public string OriginalHireDate { get; set; }

        [JsonProperty("mostRecentHireDate")]
        public string MostRecentHireDate { get; set; }

        [JsonProperty("employmentStatus")]
        public Status EmploymentStatus { get; set; }

        [JsonProperty("workStatus")]
        public Status WorkStatus { get; set; }

        [JsonProperty("positionTenure")]
        public string PositionTenure { get; set; }

        [JsonProperty("positionTitle")]
        public string PositionTitle { get; set; }

        [JsonProperty("employerDisclaimers")]
        public object EmployerDisclaimers { get; set; }
    }

    [DataContract]
    [Writable]
    public class EmployerAddress
    {
        [JsonProperty("lineOne")]
        public string LineOne { get; set; }

        [JsonProperty("lineTwo")]
        public object LineTwo { get; set; }

        [JsonProperty("lineThree")]
        public object LineThree { get; set; }

        [JsonProperty("cityName")]
        public string CityName { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("countryCode")]
        public string CountryCode { get; set; }

        [JsonProperty("postalCode")]
        public string PostalCode { get; set; }
    }

    [DataContract]
    [Writable]
    public class Status
    {
        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    [DataContract]
    [Writable]
    public class ReportCustomLabels
    {
        [JsonProperty("label1")]
        public Label Label1 { get; set; }
        
        [JsonProperty("label2")]
        public Label Label2 { get; set; }

        [JsonProperty("label3")]
        public Label Label3 { get; set; }

        [JsonProperty("label4")]
        public Label Label4 { get; set; }

        [JsonProperty("label5")]
        public Label Label5 { get; set; }
    }

    [DataContract]
    [Writable]
    public class Label
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }
}