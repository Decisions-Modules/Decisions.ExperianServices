using System.Runtime.Serialization;
using DecisionsFramework.Design.ConfigurationStorage.Attributes;
using Newtonsoft.Json;

namespace Decisions.ExperianServices.Dao.CreditReport
{
    [DataContract]
    [Writable]
    public partial class ExperianCreditReportResponse
    {
        [DataMember]
        [WritableValue]
        [JsonProperty("creditProfile")]
        public CreditProfile[] CreditProfile { get; set; }
    }

    [DataContract]
    [Writable]
    public partial class CreditProfile
    {
        [JsonProperty("addressInformation")]
        public AddressInformation[] AddressInformation { get; set; }

        [JsonProperty("consumerAssistanceReferralAddress")]
        public ConsumerAssistanceReferralAddress ConsumerAssistanceReferralAddress { get; set; }

        [JsonProperty("consumerIdentity")]
        public ConsumerIdentity ConsumerIdentity { get; set; }

        [JsonProperty("directCheck")]
        public DirectCheck[] DirectCheck { get; set; }

        [JsonProperty("employmentInformation")]
        public EmploymentInformation[] EmploymentInformation { get; set; }

        [JsonProperty("fraudShield")]
        public FraudShield[] FraudShield { get; set; }

        [JsonProperty("informationalMessage")]
        public InformationalMessage[] InformationalMessage { get; set; }

        [JsonProperty("inquiry")]
        public Inquiry[] Inquiry { get; set; }

        [JsonProperty("m1a")]
        public M1A M1A { get; set; }

        [JsonProperty("ofac")]
        public Ofac Ofac { get; set; }

        [JsonProperty("summaries")]
        public ResponseSummaries[] Summaries { get; set; }

        [JsonProperty("publicRecord")]
        public PublicRecord[] PublicRecord { get; set; }

        [JsonProperty("riskModel")]
        public RiskModel[] RiskModel { get; set; }

        [JsonProperty("ssn")]
        public ResponseSsn[] Ssn { get; set; }

        [JsonProperty("statement")]
        public Statement[] Statement { get; set; }

        [JsonProperty("tradeline")]
        public Tradeline[] Tradeline { get; set; }

        [JsonProperty("modelAttribute")]
        public ModelAttribute ModelAttribute { get; set; }

        [JsonProperty("uniqueConsumerIdentifier")]
        public UniqueConsumerIdentifier UniqueConsumerIdentifier { get; set; }

        public CreditProfileDetails CreditProfileDetails { get; set; }
    }

    [DataContract]
    [Writable]
    public partial class AddressInformation
    {
        [JsonProperty("censusGeoCode")]
        public string CensusGeoCode { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("countyCode")]
        public string CountyCode { get; set; }

        [JsonProperty("dwellingType")]
        public string DwellingType { get; set; }

        [JsonProperty("firstReportedDate")]
        public string FirstReportedDate { get; set; }

        [JsonProperty("lastReportingSubscriberCode", NullValueHandling = NullValueHandling.Ignore)]
        public string LastReportingSubscriberCode { get; set; }

        [JsonProperty("lastUpdatedDate")]
        public string LastUpdatedDate { get; set; }

        [JsonProperty("source")]
        public string Source { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("streetName", NullValueHandling = NullValueHandling.Ignore)]
        public string StreetName { get; set; }

        [JsonProperty("streetPrefix", NullValueHandling = NullValueHandling.Ignore)]
        public string StreetPrefix { get; set; }

        [JsonProperty("streetSuffix", NullValueHandling = NullValueHandling.Ignore)]
        public string StreetSuffix { get; set; }

        [JsonProperty("timesReported")]
        public string TimesReported { get; set; }

        [JsonProperty("zipCode")]
        public string ZipCode { get; set; }
    }

    [DataContract]
    [Writable]
    public partial class ConsumerAssistanceReferralAddress
    {
        [JsonProperty("cityStateZip")]
        public string CityStateZip { get; set; }

        [JsonProperty("officeName")]
        public string OfficeName { get; set; }

        [JsonProperty("firstReportedDate")]
        public string FirstReportedDate { get; set; }

        [JsonProperty("phone")]
        public string Phone { get; set; }

        [JsonProperty("poBox")]
        public string PoBox { get; set; }

        [JsonProperty("streetName")]
        public string StreetName { get; set; }
    }

    [DataContract]
    [Writable]
    public partial class ConsumerIdentity
    {
        [JsonProperty("dob")]
        public FullDob Dob { get; set; }

        [JsonProperty("name")]
        public ResponseName[] Name { get; set; }

        [JsonProperty("phone")]
        public ResponsePhone[] Phone { get; set; }
    }

    [DataContract]
    [Writable]
    public partial class FullDob
    {
        [JsonProperty("day")]
        public string Day { get; set; }

        [JsonProperty("month")]
        public string Month { get; set; }

        [JsonProperty("year")]
        public string Year { get; set; }
    }

    [DataContract]
    [Writable]
    public partial class ResponseName
    {
        [JsonProperty("firstName")]
        public string FirstName { get; set; }

        [JsonProperty("middleName", NullValueHandling = NullValueHandling.Ignore)]
        public string MiddleName { get; set; }

        [JsonProperty("surname")]
        public string Surname { get; set; }

        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }
    }

    [DataContract]
    [Writable]
    public partial class ResponsePhone
    {
        [JsonProperty("number")]
        public string Number { get; set; }

        [JsonProperty("source")]
        public string Source { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    [DataContract]
    [Writable]
    public partial class DirectCheck
    {
        [JsonProperty("subscriberAddress")]
        public string SubscriberAddress { get; set; }

        [JsonProperty("subscriberCity")]
        public string SubscriberCity { get; set; }

        [JsonProperty("subscriberCode")]
        public string SubscriberCode { get; set; }

        [JsonProperty("subscriberName")]
        public string SubscriberName { get; set; }

        [JsonProperty("subscriberPhone")]
        public string SubscriberPhone { get; set; }

        [JsonProperty("subscriberState")]
        public string SubscriberState { get; set; }

        [JsonProperty("subscriberZipCode")]
        public string SubscriberZipCode { get; set; }
    }

    [DataContract]
    [Writable]
    public partial class EmploymentInformation
    {
        [JsonProperty("addressExtraLine")]
        public string AddressExtraLine { get; set; }

        [JsonProperty("addressFirstLine")]
        public string AddressFirstLine { get; set; }

        [JsonProperty("addressSecondLine")]
        public string AddressSecondLine { get; set; }

        [JsonProperty("firstReportedDate")]
        public string FirstReportedDate { get; set; }

        [JsonProperty("lastUpdatedDate")]
        public string LastUpdatedDate { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("source")]
        public string Source { get; set; }

        [JsonProperty("zipCode")]
        public string ZipCode { get; set; }
    }

    [DataContract]
    [Writable]
    public partial class FraudShield
    {
        [JsonProperty("addressCount")]
        public string AddressCount { get; set; }

        [JsonProperty("addressDate")]
        public string AddressDate { get; set; }

        [JsonProperty("addressErrorCode")]
        public string AddressErrorCode { get; set; }

        [JsonProperty("dateOfBirth")]
        public string DateOfBirth { get; set; }

        [JsonProperty("dateOfDeath")]
        public string DateOfDeath { get; set; }

        [JsonProperty("fraudShieldIndicators")]
        public FraudShieldIndicators FraudShieldIndicators { get; set; }

        [JsonProperty("sic")]
        public string Sic { get; set; }

        [JsonProperty("socialCount")]
        public string SocialCount { get; set; }

        [JsonProperty("socialDate")]
        public string SocialDate { get; set; }

        [JsonProperty("socialErrorCode")]
        public string SocialErrorCode { get; set; }

        [JsonProperty("ssnFirstPossibleIssuanceYear")]
        public string SsnFirstPossibleIssuanceYear { get; set; }

        [JsonProperty("ssnLastPossibleIssuanceYear")]
        public string SsnLastPossibleIssuanceYear { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    [DataContract]
    [Writable]
    public partial class FraudShieldIndicators
    {
        [JsonProperty("indicator")]
        public string[] Indicator { get; set; }
    }

    [DataContract]
    [Writable]
    public partial class InformationalMessage
    {
        [JsonProperty("messageNumber")]
        public string MessageNumber { get; set; }

        [JsonProperty("messageNumberDetailed")]
        public string MessageNumberDetailed { get; set; }

        [JsonProperty("messageText")]
        public string MessageText { get; set; }
    }

    [DataContract]
    [Writable]
    public partial class Inquiry
    {
        [JsonProperty("amount")]
        public string Amount { get; set; }

        [JsonProperty("date")]
        public string Date { get; set; }

        [JsonProperty("kob")]
        public string Kob { get; set; }

        [JsonProperty("subscriberCode")]
        public string SubscriberCode { get; set; }

        [JsonProperty("subscriberName")]
        public string SubscriberName { get; set; }

        [JsonProperty("terms")]
        public string Terms { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    [DataContract]
    [Writable]
    public partial class M1A
    {
        [JsonProperty("messageNumber")]
        public string MessageNumber { get; set; }

        [JsonProperty("messageText")]
        public string MessageText { get; set; }
    }

    [DataContract]
    [Writable]
    public partial class Ofac
    {
        [JsonProperty("messageNumber")]
        public string MessageNumber { get; set; }

        [JsonProperty("messageText")]
        public string MessageText { get; set; }
    }

    [DataContract]
    [Writable]
    public partial class ResponseSummaries
    {
        [JsonProperty("summaryType")]
        public string SummaryType { get; set; }

        [JsonProperty("attributes")]
        public Attributes[] Attributes { get; set; }
    }

    [DataContract]
    [Writable]
    public partial class Attributes
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    [DataContract]
    [Writable]
    public partial class PublicRecord
    {
        [JsonProperty("adjustmentPercent")]
        public string AdjustmentPercent { get; set; }
        
        [JsonProperty("amount")]
        public string Amount { get; set; }

        [JsonProperty("bankruptcyAssetAmount")]
        public string BankruptcyAssetAmount { get; set; }

        [JsonProperty("bankruptcyVoluntaryIndicator")]
        public string BankruptcyVoluntaryIndicator { get; set; }

        [JsonProperty("bookPageSequence")]
        public string BookPageSequence { get; set; }

        [JsonProperty("courtCode")]
        public string CourtCode { get; set; }

        [JsonProperty("courtName")]
        public string CourtName { get; set; }

        [JsonProperty("disputeFlag")]
        public string DisputeFlag { get; set; }

        [JsonProperty("ecoa")]
        public string Ecoa { get; set; }

        [JsonProperty("evaluation")]
        public string Evaluation { get; set; }

        [JsonProperty("filingDate")]
        public string FilingDate { get; set; }

        [JsonProperty("plaintiffName")]
        public string PlaintiffName { get; set; }

        [JsonProperty("referenceNumber")]
        public string ReferenceNumber { get; set; }

        [JsonProperty("repaymentPercent")]
        public string RepaymentPercent { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("statusDate")]
        public string StatusDate { get; set; }
    }

    [DataContract]
    [Writable]
    public partial class RiskModel
    {
        [JsonProperty("evaluation")]
        public string Evaluation { get; set; }

        [JsonProperty("modelIndicator")]
        public string ModelIndicator { get; set; }

        [JsonProperty("score")]
        public string Score { get; set; }

        [JsonProperty("scoreFactors")]
        public ScoreFactors[] ScoreFactors { get; set; }

        [JsonProperty("scorePercentile")]
        public string ScorePercentile { get; set; }
    }

    [DataContract]
    [Writable]
    public partial class ScoreFactors
    {
        [JsonProperty("importance")]
        public string Importance { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }
    }

    [DataContract]
    [Writable]
    public partial class ResponseSsn
    {
        [JsonProperty("number")]
        public string Number { get; set; }

        [JsonProperty("ssnIndicators")]
        public string SsnIndicators { get; set; }

        [JsonProperty("variationIndicator")]
        public string VariationIndicator { get; set; }
    }

    [DataContract]
    [Writable]
    public partial class Statement
    {
        [JsonProperty("dateReported")]
        public string DateReported { get; set; }

        [JsonProperty("statementText")]
        public string StatementText { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    [DataContract]
    [Writable]
    public partial class Summary
    {
        [JsonProperty("summaryType")]
        public string SummaryType { get; set; }

        [JsonProperty("attributes")]
        public Attribute[] Attributes { get; set; }
    }

    [DataContract]
    [Writable]
    public partial class Attribute
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }


    }

    [DataContract]
    [Writable]
    public partial class Tradeline
    {
        [JsonProperty("accountNumber")]
        public string AccountNumber { get; set; }

        [JsonProperty("accountType")]
        public string AccountType { get; set; }

        [JsonProperty("amount1")]
        public string Amount1 { get; set; }

        [JsonProperty("amount1Qualifier")]
        public string Amount1Qualifier { get; set; }

        [JsonProperty("amount2")]
        public string Amount2 { get; set; }

        [JsonProperty("amount2Qualifier")]
        public string Amount2Qualifier { get; set; }

        [JsonProperty("amountBalloonPayment")]
        public string AmountBalloonPayment { get; set; }

        [JsonProperty("amountPastDue")]
        public string AmountPastDue { get; set; }

        [JsonProperty("balanceAmount")]
        public string BalanceAmount { get; set; }

        [JsonProperty("balanceDate")]
        public string BalanceDate { get; set; }

        [JsonProperty("bankruptcyChapterNumber")]
        public string BankruptcyChapterNumber { get; set; }

        [JsonProperty("consumerComment")]
        public string ConsumerComment { get; set; }

        [JsonProperty("consumerDisputeFlag")]
        public string ConsumerDisputeFlag { get; set; }

        [JsonProperty("datePaymentDue")]
        public string DatePaymentDue { get; set; }

        [JsonProperty("delinquencies30Days")]
        public string Delinquencies30Days { get; set; }

        [JsonProperty("delinquencies60Days")]
        public string Delinquencies60Days { get; set; }

        [JsonProperty("delinquencies90to180Days")]
        public string Delinquencies90To180Days { get; set; }

        [JsonProperty("derogCounter")]
        public string DerogCounter { get; set; }

        [JsonProperty("ecoa")]
        public string Ecoa { get; set; }

        [JsonProperty("enhancedPaymentData")]
        public EnhancedPaymentData EnhancedPaymentData { get; set; }

        [JsonProperty("evaluation")]
        public string Evaluation { get; set; }

        [JsonProperty("kob")]
        public string Kob { get; set; }

        [JsonProperty("lastPaymentDate")]
        public string LastPaymentDate { get; set; }

        [JsonProperty("maxDelinquencyDate")]
        public string MaxDelinquencyDate { get; set; }

        [JsonProperty("monthlyPaymentAmount")]
        public string MonthlyPaymentAmount { get; set; }

        [JsonProperty("monthlyPaymentType")]
        public string MonthlyPaymentType { get; set; }

        [JsonProperty("monthsHistory")]
        public string MonthsHistory { get; set; }

        [JsonProperty("openDate")]
        public string OpenDate { get; set; }

        [JsonProperty("openOrClosed")]
        public string OpenOrClosed { get; set; }

        [JsonProperty("originalCreditorName")]
        public string OriginalCreditorName { get; set; }

        [JsonProperty("paymentHistory")]
        public string PaymentHistory { get; set; }

        [JsonProperty("revolvingOrInstallment")]
        public string RevolvingOrInstallment { get; set; }

        [JsonProperty("soldToName")]
        public string SoldToName { get; set; }

        [JsonProperty("specialComment")]
        public string SpecialComment { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("statusDate")]
        public string StatusDate { get; set; }

        [JsonProperty("subscriberCode")]
        public string SubscriberCode { get; set; }

        [JsonProperty("subscriberName")]
        public string SubscriberName { get; set; }

        [JsonProperty("terms")]
        public string Terms { get; set; }

        [JsonProperty("trendedTrades")]
        public TrendedTrades[] TrendedTrades { get; set; }
    }

    [DataContract]
    [Writable]
    public partial class EnhancedPaymentData
    {
        [JsonProperty("actualPaymentAmount")]
        public string ActualPayoffAmount { get; set; }

        [JsonProperty("chargeoffAmount")]
        public string ChargeoffAmount { get; set; }

        [JsonProperty("ciiCode")]
        public string CiiCode { get; set; }

        [JsonProperty("complianceCondition")]
        public string ComplianceCondition { get; set; }

        [JsonProperty("creditLimitAmount")]
        public string CreditLimitAccount { get; set; }

        [JsonProperty("enhancedAccountCondition")]
        public string EnhancedAccountCondition { get; set; }

        [JsonProperty("enhancedAccountType")]
        public string EnhancedAccountType { get; set; }

        [JsonProperty("enhancedPaymentHistory84")]
        public string EnhancedPaymentHistory84 { get; set; }

        [JsonProperty("enhancedPaymentStatus")]
        public string EnhancedPaymentStatus { get; set; }

        [JsonProperty("enhancedSpecialComment")]
        public string EnhancedSpecialComment { get; set; }

        [JsonProperty("enhancedTerms")]
        public string EnhancedTerms { get; set; }

        [JsonProperty("enhancedTermsFrequency")]
        public string EnhancedTermsFrequency { get; set; }

        [JsonProperty("firstDelinquencyDate")]
        public string FirstDelinquencyDate { get; set; }

        [JsonProperty("highBalanceAmount")]
        public string HighBalanceAmount { get; set; }

        [JsonProperty("maxDelinquencyCode")]
        public string MaxDelinquencyCode { get; set; }

        [JsonProperty("mortgageId")]
        public string MortgageId { get; set; }

        [JsonProperty("originalCreditorClassificationCode")]
        public string OriginalCreditorClassificationCode { get; set; }

        [JsonProperty("originalLoanAmount")]
        public string OriginalLoanAmount { get; set; }

        [JsonProperty("paymentLevelDate")]
        public string PaymentLevelDate { get; set; }

        [JsonProperty("purchasedPortfolioFromName")]
        public string PurchasedPortfolioFromName { get; set; }

        [JsonProperty("secondDelinquencyDate")]
        public string SecondDelinquencyDate { get; set; }

        [JsonProperty("secondaryAgencyCode")]
        public string SecondaryAgencyCode { get; set; }

        [JsonProperty("secondaryAgencyId")]
        public string SecondaryAgencyId { get; set; }

        [JsonProperty("specialPaymentAmount")]
        public string SpecialPaymentAmount { get; set; }

        [JsonProperty("specialPaymentCode")]
        public string SpecialPaymentCode { get; set; }

        [JsonProperty("specialPaymentDate")]
        public string SpecialPaymentDate { get; set; }
    }

    [DataContract]
    [Writable]
    public partial class TrendedTrades
    {
        [JsonProperty("monthNumber")]
        public string MonthNumber { get; set; }

        [JsonProperty("balanceAmount")]
        public string BalanceAmount { get; set; }

        [JsonProperty("originalLoanAmountOrLimit")]
        public string OriginalLoanAmountOrLimit { get; set; }

        [JsonProperty("scheduledPaymentAmount")]
        public string ScheduledPaymentAmount { get; set; }

        [JsonProperty("actualPaymentAmount")]
        public string ActualPaymentAmount { get; set; }

        [JsonProperty("lastPaymentDate")]
        public string LastPaymentDate { get; set; }
    }

    [DataContract]
    [Writable]
    public partial class ModelAttribute
    {
        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("modelAttributes")]
        public ModelAttributes[] ModelAttributes { get; set; }
    }

    [DataContract]
    [Writable]
    public partial class ModelAttributes
    {
        [JsonProperty("modelTypeIndicator")]
        public string ModelTypeIndicator { get; set; }

        [JsonProperty("variableName")]
        public string VariableName { get; set; }

        [JsonProperty("signOfAttribute")]
        public string SignOfAttribute { get; set; }

        [JsonProperty("attributeValue")]
        public string AttributeValue { get; set; }
    }

    [DataContract]
    [Writable]
    public partial class UniqueConsumerIdentifier
    {
        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("verificationIndicator")]
        public string VerificationIndicator { get; set; }
    }

    [DataContract]
    [Writable]
    public partial class CreditProfileDetails
    {
        public string DisputedAccountsExcluded { get; set; }

        public string PublicRecordsCount { get; set; }

        public string InstallmentBalance { get; set; }

        public string RealEstateBalance { get; set; }

        public string RevolvingBalance { get; set; }

        public string PastDueAmount { get; set; }

        public string MonthlyPayment { get; set; }

        public string MonthlyPaymentPartialFlag { get; set; }

        public string RealEstatePayment { get; set; }

        public string RealEstatePaymentPartialFlag { get; set; }

        public string RevolvingAvailablePercent { get; set; }

        public string RevolvingAvailablePartialFlag { get; set; }

        public string TotalInquiries { get; set; }

        public string InquiriesDuringLast6Months { get; set; }

        public string TotalTradeItems { get; set; }

        public string PaidAccounts { get; set; }

        public string SatisfactoryAccounts { get; set; }

        public string NowDelinquentDerog { get; set; }

        public string WasDelinquentDerog { get; set; }

        public string OldestTradeDate { get; set; }

        public string Delinquencies30Days { get; set; }

        public string Delinquencies60Days { get; set; }

        public string Delinquencies90To180Days { get; set; }

        public string DerogCounter { get; set; }
    }
}
