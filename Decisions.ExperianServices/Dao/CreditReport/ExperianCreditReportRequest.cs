using System.Runtime.Serialization;
using DecisionsFramework.Design.ConfigurationStorage.Attributes;
using Newtonsoft.Json;

namespace Decisions.ExperianServices.Dao.CreditReport
{
    [DataContract]
    [Writable]
    public class ExperianCreditReportRequest
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
        [JsonProperty("freezeOverride")]
        public FreezeOverride FreezeOverride { get; set; }
        
        [DataMember]
        [WritableValue]
        [JsonProperty("vendorData")]
        public VendorData VendorData { get; set; }

        [DataMember]
        [WritableValue]
        [JsonProperty("addOns")]
        public AddOns Addons { get; set; }

        [DataMember]
        [WritableValue]
        [JsonProperty("customOptions")]
        public CustomOptions CustomOptions { get; set; }
    }

    [DataContract]
    [Writable]
    public class AddOns
    {
        [DataMember]
        [WritableValue]
        [JsonProperty("directCheck")]
        public string DirectCheck { get; set; } = string.Empty;

        [DataMember]
        [WritableValue]
        [JsonProperty("demographics")]
        public string Demographics { get; set; }

        [DataMember]
        [WritableValue]
        [JsonProperty("staggSelect")]
        public string StaggSelect { get; set; }

        [DataMember]
        [WritableValue]
        [JsonProperty("eircRevolvingBankCardsAttributes")]
        public string EircRevolvingBankCardsAttributes { get; set; }

        [DataMember]
        [WritableValue]
        [JsonProperty("eircClosedEndLoansAttributes")]
        public string EircClosedEndLoansAttributes { get; set; }

        [DataMember]
        [WritableValue]
        [JsonProperty("eircMortgagesAttributes")]
        public string EircMortgagesAttributes { get; set; }

        [DataMember]
        [WritableValue]
        [JsonProperty("eircStudentLoansAttributes")]
        public string EircStudentLoansAttributes { get; set; }

        [DataMember]
        [WritableValue]
        [JsonProperty("TAPS4Attributes")]
        public string Taps4Attributes { get; set; }

        [DataMember]
        [WritableValue]
        [JsonProperty("clarityEarlyRiskScore")]
        public string ClarityEarlyRiskScore { get; set; }

        [DataMember]
        [WritableValue]
        [JsonProperty("clarityData")]
        public ClarityData ClarityData { get; set; }

        [DataMember]
        [WritableValue]
        [JsonProperty("renterRiskScore")]
        public string RenterRiskScore { get; set; }

        [DataMember]
        [WritableValue]
        [JsonProperty("rentBureauData")]
        public RentBureauData RentBureauData { get; set; }
        
        [DataMember]
        [WritableValue]
        [JsonProperty("riskModels")]
        public RiskModels RiskModels { get; set; }

        [DataMember]
        [WritableValue]
        [JsonProperty("summaries")]
        public Summaries Summaries { get; set; }

        [DataMember]
        [WritableValue]
        [JsonProperty("fraudShield")]
        public string FraudShield { get; set; }

        [DataMember]
        [WritableValue]
        [JsonProperty("mla")]
        public string Mla { get; set; } = string.Empty;

        [DataMember]
        [WritableValue]
        [JsonProperty("ofacmsg")]
        public string Ofacmsg { get; set; } = string.Empty;

        [DataMember]
        [WritableValue]
        [JsonProperty("consumerIdentCheck")]
        public ConsumerIdentCheck ConsumerIdentCheck { get; set; }

        [DataMember]
        [WritableValue]
        [JsonProperty("joint")]
        public string Joint { get; set; } = string.Empty;

        [DataMember]
        [WritableValue]
        [JsonProperty("paymentHistory84")]
        public string PaymentHistory84 { get; set; } = string.Empty;
        
        [DataMember]
        [WritableValue]
        [JsonProperty("syntheticId")]
        public string SyntheticId { get; set; }
        
        [DataMember]
        [WritableValue]
        [JsonProperty("taxRefundLoan")]
        public string TaxRefundLoan { get; set; }
        
        [DataMember]
        [WritableValue]
        [JsonProperty("sureProfile")]
        public string SureProfile { get; set; }
        
        [DataMember]
        [WritableValue]
        [JsonProperty("incomeAndEmploymentReport")]
        public string IncomeAndEmploymentReport { get; set; }
        
        [DataMember]
        [WritableValue]
        [JsonProperty("incomeAndEmploymentReportData")]
        public IncomeAndEmploymentReportData IncomeAndEmploymentReportData { get; set; }
    }

    [DataContract]
    [Writable]
    public class ClarityData
    {
        [DataMember]
        [WritableValue]
        [JsonProperty("clarityAccountId")]
        public string ClarityAccountId { get; set; }

        [DataMember]
        [WritableValue]
        [JsonProperty("clarityLocationId")]
        public string ClarityLocationId { get; set; }

        [DataMember]
        [WritableValue]
        [JsonProperty("clarityControlFileName")]
        public string ClarityControlFileName { get; set; }

        [DataMember]
        [WritableValue]
        [JsonProperty("clarityControlFileVersion")]
        public string ClarityControlFileVersion { get; set; }
    }

    [DataContract]
    [Writable]
    public class ConsumerIdentCheck
    {
        [DataMember]
        [WritableValue]
        [JsonProperty("getUniqueConsumerIdentifier")]
        public string GetUniqueConsumerIdentifier { get; set; } = string.Empty;

        [DataMember]
        [WritableValue]
        [JsonProperty("verifyPrimaryConsumerIdentifier")]
        public string VerifyPrimaryConsumerIdentifier { get; set; }

        [DataMember]
        [WritableValue]
        [JsonProperty("verifySecondaryConsumerIdentifier")]
        public string VerifySecondaryConsumerIdentifier { get; set; }
    }
    
    [DataContract]
    [Writable]
    public class IncomeAndEmploymentReportData
    {
        [DataMember]
        [WritableValue]
        [JsonProperty("verifierName")]
        public string VerifierName { get; set; } = string.Empty;

        [DataMember]
        [WritableValue]
        [JsonProperty("reportType")]
        public string ReportType { get; set; }
    }

    [DataContract]
    [Writable]
    public class RentBureauData
    {
        [DataMember]
        [WritableValue]
        [JsonProperty("primaryApplRentBureauFreezePin")]
        public string PrimaryApplRentBureauFreezePin { get; set; }

        [DataMember]
        [WritableValue]
        [JsonProperty("secondaryApplRentBureauFreezePin")]
        public string SecondaryApplRentBureauFreezePin { get; set; }
    }

    [DataContract]
    [Writable]
    public class RiskModels
    {
        [DataMember]
        [WritableValue]
        [JsonProperty("modelIndicator")]
        public string[] ModelIndicator { get; set; } = { string.Empty };

        [DataMember]
        [WritableValue]
        [JsonProperty("scorePercentile")]
        public string ScorePercentile { get; set; } = string.Empty;
    }

    [DataContract]
    [Writable]
    public class Summaries
    {
        [DataMember]
        [WritableValue]
        [JsonProperty("summaryType")]
        public string[] SummaryType { get; set; } = { string.Empty };
    }

    [DataContract]
    [Writable]
    public class ConsumerPii
    {
        [DataMember]
        [WritableValue]
        [JsonProperty("primaryApplicant")]
        public AryApplicant PrimaryApplicant { get; set; }

        [DataMember]
        [WritableValue]
        [JsonProperty("secondaryApplicant")]
        public AryApplicant SecondaryApplicant { get; set; }
    }

    [DataContract]
    [Writable]
    public class AryApplicant
    {
        [DataMember]
        [WritableValue]
        [JsonProperty("name")]
        public Name Name { get; set; }

        [DataMember]
        [WritableValue]
        [JsonProperty("dob")]
        public Dob Dob { get; set; }

        [DataMember]
        [WritableValue]
        [JsonProperty("ssn")]
        public Ssn Ssn { get; set; }

        [DataMember]
        [WritableValue]
        [JsonProperty("driverslicense")]
        public DriversLicense DriversLicense { get; set; }

        [DataMember]
        [WritableValue]
        [JsonProperty("phone")]
        public Phone[] Phone { get; set; }

        [DataMember]
        [WritableValue]
        [JsonProperty("employment")]
        public Employment Employment { get; set; }

        [DataMember]
        [WritableValue]
        [JsonProperty("currentAddress", NullValueHandling = NullValueHandling.Ignore)]
        public Address CurrentAddress { get; set; }

        [DataMember]
        [WritableValue]
        [JsonProperty("previousAddress", NullValueHandling = NullValueHandling.Ignore)]
        public Address[] PreviousAddress { get; set; }
    }

    [DataContract]
    [Writable]
    public class Address
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
    public class Dob
    {
        [DataMember]
        [WritableValue]
        [JsonProperty("dob")]
        public string DobDob { get; set; }
    }

    [DataContract]
    [Writable]
    public class DriversLicense
    {
        [DataMember]
        [WritableValue]
        [JsonProperty("number")]
        public string Number { get; set; }

        [DataMember]
        [WritableValue]
        [JsonProperty("state")]
        public string State { get; set; }
    }

    [DataContract]
    [Writable]
    public class Employment
    {
        [DataMember]
        [WritableValue]
        [JsonProperty("employerName")]
        public string EmployerName { get; set; }

        [DataMember]
        [WritableValue]
        [JsonProperty("employerAddress")]
        public Address EmployerAddress { get; set; }
    }

    [DataContract]
    [Writable]
    public class Name
    {
        [DataMember]
        [WritableValue]
        [JsonProperty("lastName")]
        public string LastName { get; set; }

        [DataMember]
        [WritableValue]
        [JsonProperty("firstName")]
        public string FirstName { get; set; }

        [DataMember]
        [WritableValue]
        [JsonProperty("middleName")]
        public string MiddleName { get; set; }

        [DataMember]
        [WritableValue]
        [JsonProperty("generationCode")]
        public string GenerationCode { get; set; }
    }

    [DataContract]
    [Writable]
    public class Phone
    {
        [DataMember]
        [WritableValue]
        [JsonProperty("number")]
        public string Number { get; set; }

        [DataMember]
        [WritableValue]
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    [DataContract]
    [Writable]
    public class Ssn
    {
        [DataMember]
        [WritableValue]
        [JsonProperty("ssn")]
        public string SsnSsn { get; set; }
    }

    [DataContract]
    [Writable]
    public class CustomOptions
    {
        [DataMember]
        [WritableValue]
        [JsonProperty("optionId")]
        public string[] OptionId { get; set; }
    }

    [DataContract]
    [Writable]
    public class FreezeOverride
    {
        [DataMember]
        [WritableValue]
        [JsonProperty("primaryApplFreezeOverrideCode")]
        public string PrimaryApplFreezeOverrideCode { get; set; }

        [DataMember]
        [WritableValue]
        [JsonProperty("secondaryApplFreezeOverrideCode")]
        public string SecondaryApplFreezeOverrideCode { get; set; }
    }
    
    [DataContract]
    [Writable]
    public class VendorData
    {
        [DataMember]
        [WritableValue]
        [JsonProperty("vendorNumber")]
        public string VendorNumber { get; set; }

        [DataMember]
        [WritableValue]
        [JsonProperty("vendorVersion")]
        public string VendorVersion { get; set; }
    }

    [DataContract]
    [Writable]
    public class PermissiblePurpose
    {
        [DataMember]
        [WritableValue]
        [JsonProperty("type")]
        public string Type { get; set; }

        [DataMember]
        [WritableValue]
        [JsonProperty("terms")]
        public string Terms { get; set; }

        [DataMember]
        [WritableValue]
        [JsonProperty("abbreviatedAmount")]
        public string AbbreviatedAmount { get; set; }
    }

    [DataContract]
    [Writable]
    public class Requestor
    {
        [DataMember]
        [WritableValue]
        [JsonProperty("subscriberCode")]
        public string SubscriberCode { get; set; }
    }

    [DataContract]
    [Writable]
    public class ResellerInfo
    {
        [DataMember]
        [WritableValue]
        [JsonProperty("endUserName")]
        public string EndUserName { get; set; }
    } 
}
