using System;
using System.Runtime.Serialization;
using DecisionsFramework.Design.ConfigurationStorage.Attributes;
using Newtonsoft.Json;

namespace Decisions.ExperianServices.Dao.PremierProfiles
{
    [Writable, DataContract]
    public class PremierProfilesResponse
    {
        [WritableValue, DataMember]
        [JsonProperty("requestId")]
        public string RequestId { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("success")]
        public bool? Success { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("comments")]
        public string Comments { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("results")]
        public Results Results { get; set; }
    }

    [Writable, DataContract]
    public class ScoreInformation
    {
        [WritableValue, DataMember]
        [JsonProperty("fsrScore")]
        public FsrScore FsrScore { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("commercialScore")]
        public CommercialScore CommercialScore { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("fsrScoreFactors")]
        public ScoreFactors[] FsrScoreFactors { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("commercialScoreFactors")]
        public ScoreFactors[] CommercialScoreFactors { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("fsrScoreTrends")]
        public ScoreTrends[] FsrScoreTrends { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("commercialScoreTrends")]
        public ScoreTrends[] CommercialScoreTrends { get; set; }
    }

    [Writable, DataContract]
    public class ScoreFactors
    {
        [WritableValue, DataMember]
        [JsonProperty("code")]
        public string Code { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("definition")]
        public string Definition { get; set; }
    }

    [Writable, DataContract]
    public class ScoreTrends
    {
        [WritableValue, DataMember]
        [JsonProperty("quarter")]
        public string Quarter { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("score")]
        public double? Score { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("industryScore")]
        public double? IndustryScore { get; set; }
    }

    [Writable, DataContract]
    public class ContractSpendingDetail
    {
        [WritableValue, DataMember]
        [JsonProperty("contractAction")]
        public string ContractAction { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("contractId")]
        public string ContractId { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("programSource")]
        public string ProgramSource { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("departmentAgency")]
        public string DepartmentAgency { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("productService")]
        public string ProductService { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("signedDate")]
        public string SignedDate { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("obligationAmount")]
        public double? ObligationAmount { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("reasonForModification")]
        public string ReasonForModification { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("additionalDescription")]
        public string AdditionalDescription { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("sequenceNumber")]
        public double? SequenceNumber { get; set; }
    }

    [Writable, DataContract]
    public class ContractSpendingSummary
    {
        [WritableValue, DataMember]
        [JsonProperty("totalDollarAmount")]
        public double? TotalDollarAmount { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("totalNumberOfTransactions")]
        public double? TotalNumberOfTransactions { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("spendByFiscalYear")]
        public SpendByFiscalYear[] SpendByFiscalYear { get; set; }
    }

    [Writable, DataContract]
    public class GovernmentActivity
    {
        [WritableValue, DataMember]
        [JsonProperty("congressionalDistrict")]
        public string CongressionalDistrict { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("contractor")]
        public string Contractor { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("debarredIndicator")]
        public string DebarredIndicator { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("agency")]
        public string Agency { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("exclusionType")]
        public string ExclusionType { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("activeDate")]
        public string ActiveDate { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("terminationDate")]
        public string TerminationDate { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("importExportCode")]
        public string ImportExportCode { get; set; }
    }

    [Writable, DataContract]
    public class EconomicDiversity
    {
        [WritableValue, DataMember]
        [JsonProperty("minorityOwnedIndicator")]
        public bool? MinorityOwnedIndicator { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("womenOwnedIndicator")]
        public bool? WomenOwnedIndicator { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("disadvantagedIndicator")]
        public bool? DisadvantagedIndicator { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("sbaCertifiedIndicator")]
        public bool? SbaCertifiedIndicator { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("sba8aIndicator")]
        public bool? Sba8aIndicator { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("hubZoneIndicator")]
        public bool? HubZoneIndicator { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("veteranOwnedIndicator")]
        public bool? VeteranOwnedIndicator { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("disabledVeteranOwnedIndicator")]
        public bool? DisabledVeteranOwnedIndicator { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("historicalBlackCollegeAndUniversitiesIndicator")]
        public bool? HistoricalBlackCollegeAndUniversitiesIndicator { get; set; }
    }

    [Writable, DataContract]
    public class CorporateFinancialInformation
    {
        [WritableValue, DataMember]
        [JsonProperty("currentDate")]
        public string CurrentDate { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("fiscalYearEndDate")]
        public string FiscalYearEndDate { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("balanceSheets")]
        public BalanceSheets[] BalanceSheets { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("operatingStatements")]
        public OperatingStatements[] OperatingStatements { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("criticalDataAndFinancialRatios")]
        public CriticalDataAndFinancialRatios[] CriticalDataAndFinancialRatios { get; set; }
    }

    [Writable, DataContract]
    public class ConsumerStatement
    {
        [WritableValue, DataMember]
        [JsonProperty("type")]
        public Type Type { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("dateReported")]
        public string DateReported { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("text")]
        public string Text { get; set; }
    }

    [Writable, DataContract]
    public class CommercialGovernmentEntityCode
    {
        [WritableValue, DataMember]
        [JsonProperty("cageCode")]
        public string CageCode { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("samNumber")]
        public double? SamNumber { get; set; }
    }

    [Writable, DataContract]
    public class Competitors
    {
        [WritableValue, DataMember]
        [JsonProperty("competitorName")]
        public string CompetitorName { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("competitorBin")]
        public string CompetitorBin { get; set; }
    }

    [Writable, DataContract]
    public class ProprietorNameAndAddress
    {
        [WritableValue, DataMember]
        [JsonProperty("profileType")]
        public string ProfileType { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("profileDate")]
        public string ProfileDate { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("proprietorName")]
        public string ProprietorName { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("address")]
        public Address Address { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("ssn")]
        public string Ssn { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("title")]
        public string Title { get; set; }
    }

    [Writable, DataContract]
    public class Inquiries
    {
        [WritableValue, DataMember]
        [JsonProperty("inquiryBusinessCategory")]
        public string InquiryBusinessCategory { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("inquiryCount")]
        public InquiryCount[] InquiryCount { get; set; }
    }

    [Writable, DataContract]
    public class ExpandedCreditSummary
    {
        [WritableValue, DataMember]
        [JsonProperty("bankruptcyCount")]
        public double? BankruptcyCount { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("oldestBankruptcyDate")]
        public string OldestBankruptcyDate { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("mostRecentBankruptcyDate")]
        public string MostRecentBankruptcyDate { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("taxLienCount")]
        public double? TaxLienCount { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("oldestTaxLienDate")]
        public string OldestTaxLienDate { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("mostRecentTaxLienDate")]
        public string MostRecentTaxLienDate { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("judgmentCount")]
        public double? JudgmentCount { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("oldestJudgmentDate")]
        public string OldestJudgmentDate { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("mostRecentJudgmentDate")]
        public string MostRecentJudgmentDate { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("collectionCount")]
        public double? CollectionCount { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("collectionBalance")]
        public double? CollectionBalance { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("collectionCountPast24Months")]
        public double? CollectionCountPast24Months { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("legalBalance")]
        public double? LegalBalance { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("uccFilings")]
        public double? UccFilings { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("uccDerogatoryCount")]
        public double? UccDerogatoryCount { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("currentAccountBalance")]
        public double? CurrentAccountBalance { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("currentTradelineCount")]
        public double? CurrentTradelineCount { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("monthlyAverageDbt")]
        public double? MonthlyAverageDbt { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("highestDbt6Months")]
        public double? HighestDbt6Months { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("highestDbt5Quarters")]
        public double? HighestDbt5Quarters { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("activeTradelineCount")]
        public double? ActiveTradelineCount { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("allTradelineBalance")]
        public double? AllTradelineBalance { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("allTradelineCount")]
        public double? AllTradelineCount { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("averageBalance5Quarters")]
        public double? AverageBalance5Quarters { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("singleHighCredit")]
        public double? SingleHighCredit { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("lowBalance6Months")]
        public double? LowBalance6Months { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("highBalance6Months")]
        public double? HighBalance6Months { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("oldestCollectionDate")]
        public string OldestCollectionDate { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("mostRecentCollectionDate")]
        public string MostRecentCollectionDate { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("currentDbt")]
        public double? CurrentDbt { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("oldestUccDate")]
        public string OldestUccDate { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("mostRecentUccDate")]
        public string MostRecentUccDate { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("bankruptcyIndicator")]
        public bool? BankruptcyIndicator { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("judgmentIndicator")]
        public bool? JudgmentIndicator { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("taxLienIndicator")]
        public bool? TaxLienIndicator { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("tradeCollectionCount")]
        public double? TradeCollectionCount { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("tradeCollectionBalance")]
        public double? TradeCollectionBalance { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("openCollectionCount")]
        public double? OpenCollectionCount { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("openCollectionBalance")]
        public double? OpenCollectionBalance { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("ofacMatchWarning")]
        public OfacMatchWarning OfacMatchWarning { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("victimStatementIndicator")]
        public bool? VictimStatementIndicator { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("commercialFraudRiskIndicatorCount")]
        public double? CommercialFraudRiskIndicatorCount { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("unsummarizedTradelineCount")]
        public double? UnsummarizedTradelineCount { get; set; }
    }

    [Writable, DataContract]
    public class ExecutiveSummary
    {
        [WritableValue, DataMember]
        [JsonProperty("lowestTotalAccountBalance")]
        public LowestTotalAccountBalance LowestTotalAccountBalance { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("highestTotalAccountBalance")]
        public HighestTotalAccountBalance HighestTotalAccountBalance { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("currentTotalAccountBalance")]
        public CurrentTotalAccountBalance CurrentTotalAccountBalance { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("highCreditAmountExtended")]
        public double? HighCreditAmountExtended { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("medianCreditAmountExtended")]
        public double? MedianCreditAmountExtended { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("industryDescription")]
        public string IndustryDescription { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("businessDbt")]
        public BusinessDbt BusinessDbt { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("predictedDbt")]
        public double? PredictedDbt { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("predictedDbtDate")]
        public string PredictedDbtDate { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("industryDbt")]
        public double? IndustryDbt { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("allIndustryDbt")]
        public double? AllIndustryDbt { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("industryPaymentComparison")]
        public IndustryPaymentComparison IndustryPaymentComparison { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("paymentTrendIndicator")]
        public PaymentTrendIndicator PaymentTrendIndicator { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("commonTerms")]
        public CommonTerms CommonTerms { get; set; }
    }

    [Writable, DataContract]
    public class UccCoDebtors
    {
        [WritableValue, DataMember]
        [JsonProperty("name")]
        public string Name { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("address")]
        public AddressResult Address { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("taxId")]
        public string TaxId { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("sequenceNumber")]
        public double? SequenceNumber { get; set; }
    }

    [Writable, DataContract]
    public class CorporateLinkage
    {
        [WritableValue, DataMember]
        [JsonProperty("businessName")]
        public string BusinessName { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("bin")]
        public string Bin { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("corporateLinkageType")]
        public string CorporateLinkageType { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("matchingBusinessIndicator")]
        public bool? MatchingBusinessIndicator { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("address")]
        public LinkageBusinessAddress Address { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("returnLimitExceeded")]
        public bool? ReturnLimitExceeded { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    [Writable, DataContract]
    public class LinkageBusinessAddress
    {
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
        [JsonProperty("country")]
        public string Country { get; set; }
    }

    [Writable, DataContract]
    public class CommercialFraudShieldSummary
    {
        [WritableValue, DataMember]
        [JsonProperty("matchingBusinessIndicator")]
        public string MatchingBusinessIndicator { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("activeBusinessIndicator")]
        public bool? ActiveBusinessIndicator { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("ofacMatchWarning")]
        public OFACMatchWarning OfacMatchWarning { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("businessVictimStatementIndicator")]
        public bool? BusinessVictimStatementIndicator { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("businessRiskTriggersIndicator")]
        public bool? BusinessRiskTriggersIndicator { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("nameAddressVerificationIndicator")]
        public bool? NameAddressVerificationIndicator { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("businessRiskTriggersStatement")]
        public string[] BusinessRiskTriggersStatement { get; set; }
    }

    [Writable, DataContract]
    public class BusinessCollectionsDetailResult
    {
        [WritableValue, DataMember]
        [JsonProperty("accountStatus")]
        public string AccountStatus { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("datePlacedForCollection")]
        public string DatePlacedForCollection { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("dateClosed")]
        public string DateClosed { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("amountPlacedForCollection")]
        public double? AmountPlacedForCollection { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("amountPaid")]
        public double? AmountPaid { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("collectionAgencyInfo")]
        public CollectionAgencyInfoResult CollectionAgencyInfo { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("clientOfCollectionAgency")]
        public ClientOfCollectionAgency ClientOfCollectionAgency { get; set; }
    }

    [Writable, DataContract]
    public class ClientOfCollectionAgency
    {
        [WritableValue, DataMember]
        [JsonProperty("clientName")]
        public string ClientName { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("phoneNumber")]
        public string PhoneNumber { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("clientAccountNumber")]
        public string ClientAccountNumber { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("contactName")]
        public string ContactName { get; set; }
    }

    [Writable, DataContract]
    public class CollectionAgencyInfoResult
    {
        [WritableValue, DataMember]
        [JsonProperty("name")]
        public string Name { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("phoneNumber")]
        public string PhoneNumber { get; set; }
    }

    [Writable, DataContract]
    public class BusinessCorporateRegistrationResult
    {
        [WritableValue, DataMember]
        [JsonProperty("stateOfOrigin")]
        public string StateOfOrigin { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("legalName")]
        public string LegalName { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("charterNumber")]
        public string CharterNumber { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("originalFilingDate")]
        public string OriginalFilingDate { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("recentFilingDate")]
        public string RecentFilingDate { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("incorporatedDate")]
        public string IncorporatedDate { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("businessType")]
        public string BusinessType { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("statusFlag")]
        public StatusFlag StatusFlag { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("statusDescription")]
        public string StatusDescription { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("profitFlag")]
        public string ProfitFlag { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("existenceTermYears")]
        public double? ExistenceTermYears { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("existenceTermDate")]
        public string ExistenceTermDate { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("federalTaxID")]
        public string FederalTaxID { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("stateTaxId")]
        public string StateTaxId { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("domesticForeignIndicator")]
        public string DomesticForeignIndicator { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("agentName")]
        public string AgentName { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("agentAddress")]
        public AgentAddressResult AgentAddress { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("corporateRegistrationIndicator")]
        public bool? CorporateRegistrationIndicator { get; set; }
    }

    [Writable, DataContract]
    public class AgentAddressResult
    {
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
    }

    [Writable, DataContract]
    public class OFACMatchWarning
    {
        [WritableValue, DataMember]
        [JsonProperty("code")]
        public double? Code { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("definition")]
        public string Definition { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("detailStatement")]
        public string DetailStatement { get; set; }
    }

    [Writable, DataContract]
    public class LienDetail
    {
        [WritableValue, DataMember]
        [JsonProperty("dateFiled")]
        public string DateFiled { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("legalType")]
        public string LegalType { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("legalAction")]
        public string LegalAction { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("documentNumber")]
        public string DocumentNumber { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("filingLocation")]
        public string FilingLocation { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("owner")]
        public string Owner { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("liabilityAmount")]
        public double? LiabilityAmount { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("customerDisputeIndicator")]
        public bool? CustomerDisputeIndicator { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("taxLienDescription")]
        public string TaxLienDescription { get; set; }
    }

    [Writable, DataContract]
    public class ExecutiveInformation
    {
        [WritableValue, DataMember]
        [JsonProperty("firstName")]
        public string FirstName { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("middleName")]
        public string MiddleName { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("lastName")]
        public string LastName { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("title")]
        public string Title { get; set; }
    }

    [Writable, DataContract]
    public class SICCode
    {
        [WritableValue, DataMember]
        [JsonProperty("code")]
        public string Code { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("definition")]
        public string Definition { get; set; }
    }

    [Writable, DataContract]
    public class NAICSCode
    {
        [WritableValue, DataMember]
        [JsonProperty("code")]
        public string Code { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("definition")]
        public string Definition { get; set; }
    }

    [Writable, DataContract]
    public class BusinessFacts
    {
        [WritableValue, DataMember]
        [JsonProperty("fileEstablishedDate")]
        public string FileEstablishedDate { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("sicCodes")]
        public SICCode[] SicCodes { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("naicsCodes")]
        public NAICSCode[] NaicsCodes { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("stockExchange")]
        public string StockExchange { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("tickerSymbol")]
        public string TickerSymbol { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("fileEstablishedFlag")]
        public FileEstablishedFlag FileEstablishedFlag { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("stateOfIncorporation")]
        public string StateOfIncorporation { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("dateOfIncorporation")]
        public string DateOfIncorporation { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("businessType")]
        public string BusinessType { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("yearsInBusinessIndicator")]
        public YearsInBusinessIndicator YearsInBusinessIndicator { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("yearsInBusiness")]
        public double? YearsInBusiness { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("yearsOnFile")]
        public double? YearsOnFile { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("fortune1000")]
        public Fortune1000 Fortune1000 { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("corporateLinkageType")]
        public string CorporateLinkageType { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("executiveInformation")]
        public ExecutiveInformation[] ExecutiveInformation { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("salesSizeCode")]
        public string SalesSizeCode { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("salesRevenue")]
        public double? SalesRevenue { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("employeeSizeCode")]
        public string EmployeeSizeCode { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("employeeSize")]
        public double? EmployeeSize { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("locationEmployeeSizeCode")]
        public string LocationEmployeeSizeCode { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("locationEmployeeSize")]
        public double? LocationEmployeeSize { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("publicIndicator")]
        public bool? PublicIndicator { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("nonProfitIndicator")]
        public bool? NonProfitIndicator { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("locationSalesRevenue")]
        public string LocationSalesRevenue { get; set; }
    }

    [Writable, DataContract]
    public class PaymentTotalsResult
    {
        [WritableValue, DataMember]
        [JsonProperty("newlyReportedTradelines")]
        public TradeLine NewlyReportedTradelines { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("continuouslyReportedTradelines")]
        public TradeLine ContinuouslyReportedTradelines { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("combinedTradelines")]
        public TradeLine CombinedTradelines { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("additionalTradelines")]
        public TradeLine AdditionalTradelines { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("tradelines")]
        public TradeLine Tradelines { get; set; }
    }

    [Writable, DataContract]
    public class TradePaymentExperiencesResult
    {
        [WritableValue, DataMember]
        [JsonProperty("paymentIndicator")]
        public PaymentIndicator PaymentIndicator { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("businessCategory")]
        public string BusinessCategory { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("dateReported")]
        public string DateReported { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("dateLastActivity")]
        public string DateLastActivity { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("terms")]
        public string Terms { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("recentHighCredit")]
        public RecentHighCredit RecentHighCredit { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("accountBalance")]
        public AccountBalance AccountBalance { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("currentPercentage")]
        public double? CurrentPercentage { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("dbt30")]
        public double? Dbt30 { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("dbt60")]
        public double? Dbt60 { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("dbt90")]
        public double? Dbt90 { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("dbt91Plus")]
        public double? Dbt91Plus { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("comments")]
        public string Comments { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("tradelineFlag")]
        public TradelineFlag TradelineFlag { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("newlyReportedIndicator")]
        public NewlyReportedIndicator NewlyReportedIndicator { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("customerDisputeIndicator")]
        public string CustomerDisputeIndicator { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("itipConsolidatedNumber")]
        public double? ItipConsolidatedNumber { get; set; }
    }

    [Writable, DataContract]
    public class TradePaymentTrend
    {
        [WritableValue, DataMember]
        [JsonProperty("date")]
        [JsonConverter(typeof(DateFormatConverter))]
        public DateTimeOffset? Date { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("dbt")]
        public long? Dbt { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("totalAccountBalance")]
        public AmountModifier TotalAccountBalance { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("currentPercentage")]
        public long? CurrentPercentage { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("dbt30")]
        public long? Dbt30 { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("dbt60")]
        public long? Dbt60 { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("dbt90")]
        public long? Dbt90 { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("dbt91Plus")]
        public long? Dbt91Plus { get; set; }
    }

    [Writable, DataContract]
    public class TradeLine
    {
        [WritableValue, DataMember]
        [JsonProperty("tradelineCount")]
        public long? TradelineCount { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("currentDbt")]
        public long? CurrentDbt { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("totalHighCreditAmount")]
        public AmountModifier TotalHighCreditAmount { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("totalAccountBalance")]
        public AmountModifier TotalAccountBalance { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("currentPercentage")]
        public long? CurrentPercentage { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("dbt30")]
        public long? Dbt30 { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("dbt60")]
        public long? Dbt60 { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("dbt90")]
        public long? Dbt90 { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("dbt91Plus")]
        public long? Dbt91Plus { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("numberOfLines")]
        public double? NumberOfLines { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("dbt")]
        public double? Dbt { get; set; }
    }

    [Writable, DataContract]
    public class AmountModifier
    {
        [WritableValue, DataMember]
        [JsonProperty("amount")]
        public float? Amount { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("modifier")]
        public string Modifier { get; set; }
    }

    [Writable, DataContract]
    public class BankruptcyDetail
    {
        [WritableValue, DataMember]
        [JsonProperty("dateFiled")]
        public string DateFiled { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("legalType")]
        public string LegalType { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("legalAction")]
        public string LegalAction { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("documentNumber")]
        public string DocumentNumber { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("filingLocation")]
        public string FilingLocation { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("owner")]
        public string Owner { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("customerDisputeIndicator")]
        public bool? CustomerDisputeIndicator { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("liabilityAmount")]
        public double? LiabilityAmount { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("assetAmount")]
        public double? AssetAmount { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("exemptAmount")]
        public double? ExemptAmount { get; set; }
    }

    [Writable, DataContract]
    public class Address
    {
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
        [JsonProperty("zipExtension")]
        public string ZipExtension { get; set; }
    }

    [Writable, DataContract]
    public class AddressResult
    {
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
        [JsonProperty("zipExtension")]
        public string ZipExtension { get; set; }
    }

    [Writable, DataContract]
    public class JudgmentDetail
    {
        [WritableValue, DataMember]
        [JsonProperty("dateFiled")]
        [JsonConverter(typeof(DateFormatConverter))]
        public DateTimeOffset? DateFiled { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("legalType")]
        public string LegalType { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("legalAction")]
        public string LegalAction { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("documentNumber")]
        public string DocumentNumber { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("filingLocation")]
        public string FilingLocation { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("owner")]
        public string Owner { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("liabilityAmount")]
        public double? LiabilityAmount { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("plaintiffName")]
        public string PlaintiffName { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("customerDisputeIndicator")]
        public bool? CustomerDisputeIndicator { get; set; }
    }

    [Writable, DataContract]
    public class BusinessHeaderResult
    {
        [WritableValue, DataMember]
        [JsonProperty("bin")]
        public string Bin { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("businessName")]
        public string BusinessName { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("address")]
        public AddressResult Address { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("phone")]
        public string Phone { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("taxId")]
        public string TaxId { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("websiteUrl")]
        public string WebsiteUrl { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("legalBusinessName")]
        public string LegalBusinessName { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("dbaNames")]
        public string[] DbaNames { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("customerDisputeIndicator")]
        public bool? CustomerDisputeIndicator { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("foreignCountry")]
        public bool? ForeignCountry { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("corporateLinkageIndicator")]
        public bool? CorporateLinkageIndicator { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("matchingBranchAddress")]
        public MatchingBranchAddress MatchingBranchAddress { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("branchLocation")]
        public BranchLocation BranchLocation { get; set; }
    }

    [Writable, DataContract]
    public class UCCFilingsDetail
    {
        [WritableValue, DataMember]
        [JsonProperty("dateFiled")]
        [JsonConverter(typeof(DateFormatConverter))]
        public DateTimeOffset? DateFiled { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("legalType")]
        public string LegalType { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("legalAction")]
        public string LegalAction { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("documentNumber")]
        public string DocumentNumber { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("filingLocation")]
        public string FilingLocation { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("collateralCodes")]
        public CollateralCode[] CollateralCodes { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("securedParty")]
        public string SecuredParty { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("assignee")]
        public string Assignee { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("owner")]
        public string Owner { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("customerDisputeIndicator")]
        public bool? CustomerDisputeIndicator { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("originalUCCFilingsInfo")]
        public OriginalUCCFilingsInfo OriginalUCCFilingsInfo { get; set; }
    }

    [Writable, DataContract]
    public class CollateralCode
    {
        [WritableValue, DataMember]
        [JsonProperty("code")]
        public string Code { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("definition")]
        public string Definition { get; set; }
    }

    [Writable, DataContract]
    public class UCCFilingsTrends
    {
        [WritableValue, DataMember]
        [JsonProperty("date")]
        [JsonConverter(typeof(DateFormatConverter))]
        public DateTimeOffset? Date { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("count")]
        public double? Count { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("derogatoryCount")]
        public double? DerogatoryCount { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("releasesAndTerminationsCount")]
        public double? ReleasesAndTerminationsCount { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("continuationsCount")]
        public double? ContinuationsCount { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("amendedAndAssignedCount")]
        public double? AmendedAndAssignedCount { get; set; }
    }

    [Writable, DataContract]
    public class BizAggregates
    {
        [WritableValue, DataMember]
        [JsonProperty("ATC039")]
        public double? ATC039 { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("CTB019")]
        public double? CTB019 { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("JDC008")]
        public double? JDC008 { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("NTB019")]
        public double? NTB019 { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("NTC032")]
        public double? NTC032 { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("OTB001")]
        public double? OTB001 { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("OTC006")]
        public double? OTC006 { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("RTB019")]
        public double? RTB019 { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("RTC048")]
        public double? RTC048 { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("TTB021")]
        public double? TTB021 { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("TTB022")]
        public double? TTB022 { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("TTB028")]
        public double? TTB028 { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("TTB029")]
        public double? TTB029 { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("TTB030")]
        public double? TTB030 { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("TTB031")]
        public double? TTB031 { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("TTB032")]
        public double? TTB032 { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("TTC050")]
        public double? TTC050 { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("TTP085")]
        public double? TTP085 { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("TTP086")]
        public double? TTP086 { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("TXB005")]
        public double? TXB005 { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("TXC008")]
        public double? TXC008 { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("ACC001")]
        public double? ACC001 { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("ACC002")]
        public double? ACC002 { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("ACC003")]
        public double? ACC003 { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("ACC004")]
        public double? ACC004 { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("ACC005")]
        public double? ACC005 { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("ACC006")]
        public double? ACC006 { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("ACC007")]
        public double? ACC007 { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("ACC008")]
        public double? ACC008 { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("ATB001")]
        public double? ATB001 { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("ATB002")]
        public double? ATB002 { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("ATB003")]
        public double? ATB003 { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("ATB004")]
        public double? ATB004 { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("ATB005")]
        public double? ATB005 { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("ATB006")]
        public double? ATB006 { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("ATB007")]
        public double? ATB007 { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("ATB008")]
        public double? ATB008 { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("ATB009")]
        public double? ATB009 { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("ATB010")]
        public double? ATB010 { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("ATB011")]
        public double? ATB011 { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("ATB012")]
        public double? ATB012 { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("ATB013")]
        public double? ATB013 { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("ATB014")]
        public double? ATB014 { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("ATB015")]
        public double? ATB015 { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("ATB016")]
        public double? ATB016 { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("ATB017")]
        public double? ATB017 { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("ATB018")]
        public double? ATB018 { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("ATB019")]
        public double? ATB019 { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("ATC020")]
        public double? ATC020 { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("ATC021")]
        public double? ATC021 { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("ATC022")]
        public double? ATC022 { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("ATC023")]
        public double? ATC023 { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("ATC024")]
        public double? ATC024 { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("ATC025")]
        public double? ATC025 { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("ATC026")]
        public double? ATC026 { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("ATC027")]
        public double? ATC027 { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("ATC028")]
        public double? ATC028 { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("ATC029")]
        public double? ATC029 { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("ATC030")]
        public double? ATC030 { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("ATC031")]
        public double? ATC031 { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("ATC032")]
        public double? ATC032 { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("ATD034")]
        public double? ATD034 { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("ATD035")]
        public double? ATD035 { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("ATP036")]
        public double? ATP036 { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("ATP037")]
        public double? ATP037 { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("ATP038")]
        public double? ATP038 { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("BKB001")]
        public double? BKB001 { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("BKB002")]
        public double? BKB002 { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("BKB003")]
        public double? BKB003 { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("BKC004")]
        public double? BKC004 { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("BKC005")]
        public double? BKC005 { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("BKC006")]
        public double? BKC006 { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("BKC007")]
        public double? BKC007 { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("BKC008")]
        public double? BKC008 { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("BKO009")]
        public double? BKO009 { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("BKO010")]
        public double? BKO010 { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("BKO011")]
        public double? BKO011 { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("BRB001")]
        public double? BRB001 { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("BRB002")]
        public double? BRB002 { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("BRB003")]
        public double? BRB003 { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("BRB004")]
        public double? BRB004 { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("BRB005")]
        public double? BRB005 { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("BRB006")]
        public double? BRB006 { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("BRB007")]
        public double? BRB007 { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("BRC008")]
        public double? BRC008 { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("BRC009")]
        public double? BRC009 { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("BRC010")]
        public double? BRC010 { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("BRC011")]
        public double? BRC011 { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("BRC012")]
        public double? BRC012 { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("BRC013")]
        public double? BRC013 { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("BRC014")]
        public double? BRC014 { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("BRO015")]
        public double? BRO015 { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("BRO016")]
        public double? BRO016 { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("BRO017")]
        public double? BRO017 { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("BRP018")]
        public double? BRP018 { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("BRP019")]
        public double? BRP019 { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("BRP020")]
        public double? BRP020 { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("BRP021")]
        public double? BRP021 { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("BRP022")]
        public double? BRP022 { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("BRP023")]
        public double? BRP023 { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("CLB001")]
        public double? CLB001 { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("CLB002")]
        public double? CLB002 { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("CLB003")]
        public double? CLB003 { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("CLB004")]
        public double? CLB004 { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("CLB005")]
        public double? CLB005 { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("CLC006")]
        public double? CLC006 { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("CLC007")]
        public double? CLC007 { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("CLC008")]
        public double? CLC008 { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("CLC009")]
        public double? CLC009 { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("CLC010")]
        public double? CLC010 { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("CLC011")]
        public double? CLC011 { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("CLC012")]
        public double? CLC012 { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("CLC013")]
        public double? CLC013 { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("CLO014")]
        public double? CLO014 { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("CLO015")]
        public double? CLO015 { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("CLP016")]
        public double? CLP016 { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("CLP017")]
        public double? CLP017 { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("CLP018")]
        public double? CLP018 { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("CLP019")]
        public double? CLP019 { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("CTB001")]
        public double? CTB001 { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("CTB002")]
        public double? CTB002 { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("CTB003")]
        public double? CTB003 { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("CTB004")]
        public double? CTB004 { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("CTB005")]
        public double? CTB005 { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("CTB006")]
        public double? CTB006 { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("CTB007")]
        public double? CTB007 { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("CTB008")]
        public double? CTB008 { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("CTB009")]
        public double? CTB009 { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("CTB010")]
        public double? CTB010 { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("CTB011")]
        public double? CTB011 { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("CTB012")]
        public double? CTB012 { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("CTB013")]
        public double? CTB013 { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("CTB014")]
        public double? CTB014 { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("CTB015")]
        public double? CTB015 { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("CTB016")]
        public double? CTB016 { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("CTB017")]
        public double? CTB017 { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("CTB018")]
        public double? CTB018 { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("CTC021")]
        public double? CTC021 { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("CTC022")]
        public double? CTC022 { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("CTC023")]
        public double? CTC023 { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("CTC024")]
        public double? CTC024 { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("CTC025")]
        public double? CTC025 { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("CTC026")]
        public double? CTC026 { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("CTC027")]
        public double? CTC027 { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("CTC028")]
        public double? CTC028 { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("CTC029")]
        public double? CTC029 { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("CTC030")]
        public double? CTC030 { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("CTC031")]
        public double? CTC031 { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("CTC032")]
        public double? CTC032 { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("CTC033")]
        public double? CTC033 { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("CTC034")]
        public double? CTC034 { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("CTC035")]
        public double? CTC035 { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("CTC036")]
        public double? CTC036 { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("CTD038")]
        public double? CTD038 { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("CTP039")]
        public double? CTP039 { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("CTP040")]
        public double? CTP040 { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("CTP041")]
        public double? CTP041 { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("DMO003")]
        public string DMO003 { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("DMO009")]
        public string DMO009 { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("DMO013")]
        public string DMO013 { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("IQC001")]
        public double? IQC001 { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("IQC002")]
        public double? IQC002 { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("IQC003")]
        public double? IQC003 { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("JDB001")]
        public double? JDB001 { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("JDB002")]
        public double? JDB002 { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("JDB003")]
        public double? JDB003 { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("JDB004")]
        public double? JDB004 { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("JDB005")]
        public double? JDB005 { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("JDB006")]
        public double? JDB006 { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("JDC007")]
        public double? JDC007 { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("JDC009")]
        public double? JDC009 { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("JDC010")]
        public double? JDC010 { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("JDC011")]
        public double? JDC011 { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("JDC012")]
        public double? JDC012 { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("JDO013")]
        public double? JDO013 { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("JDO014")]
        public double? JDO014 { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("JDP015")]
        public double? JDP015 { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("JDP016")]
        public double? JDP016 { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("JDP017")]
        public double? JDP017 { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("LGC002")]
        public double? LGC002 { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("LGC003")]
        public double? LGC003 { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("LGC004")]
        public double? LGC004 { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("LSB001")]
        public double? LSB001 { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("LSB002")]
        public double? LSB002 { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("LSB003")]
        public double? LSB003 { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("LSB004")]
        public double? LSB004 { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("LSB005")]
        public double? LSB005 { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("LSB006")]
        public double? LSB006 { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("LSB007")]
        public double? LSB007 { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("LSB008")]
        public double? LSB008 { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("LSB009")]
        public double? LSB009 { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("LSC010")]
        public double? LSC010 { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("LSC011")]
        public double? LSC011 { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("LSC012")]
        public double? LSC012 { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("LSC013")]
        public double? LSC013 { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("LSC014")]
        public double? LSC014 { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("LSC015")]
        public double? LSC015 { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("LSC016")]
        public double? LSC016 { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("LSC017")]
        public double? LSC017 { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("LSC018")]
        public double? LSC018 { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("LSC019")]
        public double? LSC019 { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("LSC020")]
        public double? LSC020 { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("LSC021")]
        public double? LSC021 { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("LSC022")]
        public double? LSC022 { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("LSC023")]
        public double? LSC023 { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("LSC024")]
        public double? LSC024 { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("LSC025")]
        public double? LSC025 { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("LSC026")]
        public double? LSC026 { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("LSC027")]
        public double? LSC027 { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("LSC028")]
        public double? LSC028 { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("LSC029")]
        public double? LSC029 { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("LSC030")]
        public double? LSC030 { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("LSC031")]
        public double? LSC031 { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("LSC032")]
        public double? LSC032 { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("LSC033")]
        public double? LSC033 { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("LSP034")]
        public double? LSP034 { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("LSP035")]
        public double? LSP035 { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("NTB001")]
        public double? NTB001 { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("NTB002")]
        public double? NTB002 { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("NTB003")]
        public double? NTB003 { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("NTB004")]
        public double? NTB004 { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("NTB005")]
        public double? NTB005 { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("NTB006")]
        public double? NTB006 { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("NTB007")]
        public double? NTB007 { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("NTB008")]
        public double? NTB008 { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("NTB009")]
        public double? NTB009 { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("NTB010")]
        public double? NTB010 { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("NTB011")]
        public double? NTB011 { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("NTB012")]
        public double? NTB012 { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("NTB013")]
        public double? NTB013 { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("NTB014")]
        public double? NTB014 { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("NTB015")]
        public double? NTB015 { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("NTB016")]
        public double? NTB016 { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("NTB017")]
        public double? NTB017 { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("NTB018")]
        public double? NTB018 { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("NTC020")]
        public double? NTC020 { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("NTC021")]
        public double? NTC021 { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("NTC022")]
        public double? NTC022 { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("NTC023")]
        public double? NTC023 { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("NTC024")]
        public double? NTC024 { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("NTC025")]
        public double? NTC025 { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("NTC026")]
        public double? NTC026 { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("NTC027")]
        public double? NTC027 { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("NTC028")]
        public double? NTC028 { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("NTC029")]
        public double? NTC029 { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("NTC030")]
        public double? NTC030 { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("NTC031")]
        public double? NTC031 { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("NTD034")]
        public double? NTD034 { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("NTD035")]
        public double? NTD035 { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("NTP036")]
        public double? NTP036 { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("NTP037")]
        public double? NTP037 { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("NTP038")]
        public double? NTP038 { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("NTP039")]
        public double? NTP039 { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("OTB002")]
        public double? OTB002 { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("OTB003")]
        public double? OTB003 { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("OTB004")]
        public double? OTB004 { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("OTB005")]
        public double? OTB005 { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("OTC007")]
        public double? OTC007 { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("OTC008")]
        public double? OTC008 { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("OTC009")]
        public double? OTC009 { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("OTC010")]
        public double? OTC010 { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("OTC011")]
        public double? OTC011 { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("OTD012")]
        public double? OTD012 { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("OTD013")]
        public double? OTD013 { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("OTP014")]
        public double? OTP014 { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("OTP015")]
        public double? OTP015 { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("OTP016")]
        public double? OTP016 { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("OTP017")]
        public double? OTP017 { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("OTP018")]
        public double? OTP018 { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("OTP019")]
        public double? OTP019 { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("OTP020")]
        public double? OTP020 { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("OTP021")]
        public double? OTP021 { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("PRO001")]
        public double? PRO001 { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("PRO002")]
        public double? PRO002 { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("PRO003")]
        public double? PRO003 { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("RTB001")]
        public double? RTB001 { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("RTB002")]
        public double? RTB002 { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("RTB003")]
        public double? RTB003 { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("RTB004")]
        public double? RTB004 { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("RTB005")]
        public double? RTB005 { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("RTB006")]
        public double? RTB006 { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("RTB007")]
        public double? RTB007 { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("RTB008")]
        public double? RTB008 { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("RTB009")]
        public double? RTB009 { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("RTB010")]
        public double? RTB010 { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("RTB011")]
        public double? RTB011 { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("RTB012")]
        public double? RTB012 { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("RTB013")]
        public double? RTB013 { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("RTB014")]
        public double? RTB014 { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("RTB015")]
        public double? RTB015 { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("RTB016")]
        public double? RTB016 { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("RTB017")]
        public double? RTB017 { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("RTB018")]
        public double? RTB018 { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("RTB020")]
        public double? RTB020 { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("RTB021")]
        public double? RTB021 { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("RTB022")]
        public double? RTB022 { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("RTB023")]
        public double? RTB023 { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("RTB024")]
        public double? RTB024 { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("RTB025")]
        public double? RTB025 { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("RTB026")]
        public double? RTB026 { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("RTB027")]
        public double? RTB027 { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("RTB028")]
        public double? RTB028 { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("RTB029")]
        public double? RTB029 { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("RTB030")]
        public double? RTB030 { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("RTB031")]
        public double? RTB031 { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("RTB032")]
        public double? RTB032 { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("RTB033")]
        public double? RTB033 { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("RTB034")]
        public double? RTB034 { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("RTB035")]
        public double? RTB035 { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("RTC036")]
        public double? RTC036 { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("RTC037")]
        public double? RTC037 { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("RTC038")]
        public double? RTC038 { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("RTC039")]
        public double? RTC039 { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("RTC040")]
        public double? RTC040 { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("RTC041")]
        public double? RTC041 { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("RTC042")]
        public double? RTC042 { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("RTC043")]
        public double? RTC043 { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("RTC044")]
        public double? RTC044 { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("RTC045")]
        public double? RTC045 { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("RTC046")]
        public double? RTC046 { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("RTC047")]
        public double? RTC047 { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("RTC049")]
        public double? RTC049 { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("RTC050")]
        public double? RTC050 { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("RTC051")]
        public double? RTC051 { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("RTC052")]
        public double? RTC052 { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("RTC053")]
        public double? RTC053 { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("RTC054")]
        public double? RTC054 { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("RTD059")]
        public double? RTD059 { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("RTD060")]
        public double? RTD060 { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("RTD061")]
        public double? RTD061 { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("RTD062")]
        public double? RTD062 { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("RTD063")]
        public double? RTD063 { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("RTD064")]
        public double? RTD064 { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("RTD065")]
        public double? RTD065 { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("RTD067")]
        public double? RTD067 { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("RTD068")]
        public double? RTD068 { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("RTD069")]
        public double? RTD069 { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("RTD070")]
        public double? RTD070 { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("RTD071")]
        public double? RTD071 { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("RTD072")]
        public double? RTD072 { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("RTO077")]
        public double? RTO077 { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("RTO079")]
        public double? RTO079 { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("RTP081")]
        public double? RTP081 { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("RTP082")]
        public double? RTP082 { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("RTP083")]
        public double? RTP083 { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("RTP086")]
        public double? RTP086 { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("TTB001")]
        public double? TTB001 { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("TTB002")]
        public double? TTB002 { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("TTB003")]
        public double? TTB003 { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("TTB004")]
        public double? TTB004 { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("TTB005")]
        public double? TTB005 { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("TTB006")]
        public double? TTB006 { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("TTB007")]
        public double? TTB007 { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("TTB008")]
        public double? TTB008 { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("TTB009")]
        public double? TTB009 { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("TTB010")]
        public double? TTB010 { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("TTB011")]
        public double? TTB011 { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("TTB012")]
        public double? TTB012 { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("TTB013")]
        public double? TTB013 { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("TTB014")]
        public double? TTB014 { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("TTB015")]
        public double? TTB015 { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("TTB016")]
        public double? TTB016 { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("TTB017")]
        public double? TTB017 { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("TTB018")]
        public double? TTB018 { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("TTB019")]
        public double? TTB019 { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("TTB020")]
        public double? TTB020 { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("TTB023")]
        public double? TTB023 { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("TTB024")]
        public double? TTB024 { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("TTB025")]
        public double? TTB025 { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("TTB026")]
        public double? TTB026 { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("TTB027")]
        public double? TTB027 { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("TTB033")]
        public double? TTB033 { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("TTC035")]
        public double? TTC035 { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("TTC036")]
        public double? TTC036 { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("TTC037")]
        public double? TTC037 { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("TTC038")]
        public double? TTC038 { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("TTC039")]
        public double? TTC039 { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("TTC040")]
        public double? TTC040 { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("TTC041")]
        public double? TTC041 { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("TTC042")]
        public double? TTC042 { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("TTC043")]
        public double? TTC043 { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("TTC044")]
        public double? TTC044 { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("TTC045")]
        public double? TTC045 { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("TTC046")]
        public double? TTC046 { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("TTC047")]
        public double? TTC047 { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("TTC048")]
        public double? TTC048 { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("TTC049")]
        public double? TTC049 { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("TTC051")]
        public double? TTC051 { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("TTC052")]
        public double? TTC052 { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("TTC053")]
        public double? TTC053 { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("TTC054")]
        public double? TTC054 { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("TTC055")]
        public double? TTC055 { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("TTC056")]
        public double? TTC056 { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("TTC057")]
        public double? TTC057 { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("TTC058")]
        public double? TTC058 { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("TTC059")]
        public double? TTC059 { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("TTC060")]
        public double? TTC060 { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("TTC061")]
        public double? TTC061 { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("TTC063")]
        public double? TTC063 { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("TTC064")]
        public double? TTC064 { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("TTC065")]
        public double? TTC065 { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("TTC066")]
        public double? TTC066 { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("TTC067")]
        public double? TTC067 { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("TTC068")]
        public double? TTC068 { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("TTC069")]
        public double? TTC069 { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("TTC070")]
        public double? TTC070 { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("TTO074")]
        public double? TTO074 { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("TTO075")]
        public double? TTO075 { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("TTO076")]
        public double? TTO076 { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("TTO077")]
        public double? TTO077 { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("TTP079")]
        public double? TTP079 { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("TTP080")]
        public double? TTP080 { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("TTP084")]
        public double? TTP084 { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("TXB001")]
        public double? TXB001 { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("TXB002")]
        public double? TXB002 { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("TXB003")]
        public double? TXB003 { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("TXB004")]
        public double? TXB004 { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("TXB006")]
        public double? TXB006 { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("TXC007")]
        public double? TXC007 { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("TXC009")]
        public double? TXC009 { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("TXC010")]
        public double? TXC010 { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("TXC011")]
        public double? TXC011 { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("TXC012")]
        public double? TXC012 { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("TXO013")]
        public double? TXO013 { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("TXO014")]
        public double? TXO014 { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("TXP015")]
        public double? TXP015 { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("TXP016")]
        public double? TXP016 { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("TXP017")]
        public double? TXP017 { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("UCC001")]
        public double? UCC001 { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("UCC002")]
        public double? UCC002 { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("UCC003")]
        public double? UCC003 { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("UCC004")]
        public double? UCC004 { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("UCC005")]
        public double? UCC005 { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("UCC006")]
        public double? UCC006 { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("UCC007")]
        public double? UCC007 { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("UCC008")]
        public double? UCC008 { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("UCC009")]
        public double? UCC009 { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("UCC010")]
        public double? UCC010 { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("UCC011")]
        public double? UCC011 { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("UCC012")]
        public double? UCC012 { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("UCC013")]
        public double? UCC013 { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("UCC014")]
        public double? UCC014 { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("UCC015")]
        public double? UCC015 { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("UCC016")]
        public double? UCC016 { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("DMO004")]
        public string DMO004 { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("DMO014")]
        public string DMO014 { get; set; }
    }

    [Writable, DataContract]
    public class LeasingInformationResult
    {
        [WritableValue, DataMember]
        [JsonProperty("leasingName")]
        public string LeasingName { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("address")]
        public Address2 Address { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("phone")]
        public string Phone { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("leaseCommencementDate")]
        public string LeaseCommencementDate { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("originalLeaseAmount")]
        public double? OriginalLeaseAmount { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("leaseCloseDate")]
        public string LeaseCloseDate { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("leaseTerm")]
        public double? LeaseTerm { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("paymentsPerYear")]
        public double? PaymentsPerYear { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("paymentInterval")]
        public string PaymentInterval { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("paymentType")]
        public string PaymentType { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("commentCode")]
        public string CommentCode { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("currentDueDate")]
        public string CurrentDueDate { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("scheduledAmountDue")]
        public double? ScheduledAmountDue { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("currentBalanceAmount")]
        public double? CurrentBalanceAmount { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("numberOfPaymentsOverdue")]
        public double? NumberOfPaymentsOverdue { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("paymentOverdueAmount")]
        public double? PaymentOverdueAmount { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("totalRemainingBalance")]
        public double? TotalRemainingBalance { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("numberOfCurrentPayments")]
        public double? NumberOfCurrentPayments { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("numberOfLatePayments")]
        public double? NumberOfLatePayments { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("daysLate30")]
        public double? DaysLate30 { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("daysLate60")]
        public double? DaysLate60 { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("daysLate90")]
        public double? DaysLate90 { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("daysLate90Plus")]
        public double? DaysLate90Plus { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("leaseProductType")]
        public string LeaseProductType { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("leaseType")]
        public string LeaseType { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("leaseExtractDate")]
        public string LeaseExtractDate { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("customerDisputeIndicator")]
        public bool? CustomerDisputeIndicator { get; set; }
    }

    [Writable, DataContract]
    public class LicenseDetailsResult
    {
        [WritableValue, DataMember]
        [JsonProperty("licenseState")]
        public string LicenseState { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("licenseNumber")]
        public string LicenseNumber { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("licenseDateIssued")]
        public string LicenseDateIssued { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("licenseStatus")]
        public string LicenseStatus { get; set; }
    }

    [Writable, DataContract]
    public class Results
    {
        [WritableValue, DataMember]
        [JsonProperty("businessHeader")]
        public BusinessHeaderResult BusinessHeader { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("collectionsDetail")]
        public BusinessCollectionsDetailResult[] CollectionsDetail { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("tradePaymentExperiences")]
        public TradePaymentExperiencesResult[] TradePaymentExperiences { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("additionalPaymentExperiences")]
        public TradePaymentExperiencesResult[] AdditionalPaymentExperiences { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("paymentTotals")]
        public PaymentTotalsResult PaymentTotals { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("monthlyPaymentTrends")]
        public TradePaymentTrend[] MonthlyPaymentTrends { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("industryPaymentTrends")]
        public IndustryPaymentTrends IndustryPaymentTrends { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("quarterlyPaymentTrends")]
        public TradePaymentTrend[] QuarterlyPaymentTrends { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("bankruptcyDetail")]
        public BankruptcyDetail[] BankruptcyDetail { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("taxLienDetail")]
        public LienDetail[] TaxLienDetail { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("judgmentDetail")]
        public JudgmentDetail[] JudgmentDetail { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("uccFilingsSummary")]
        public UccFilingsSummary UccFilingsSummary { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("uccFilingsDetail")]
        public UCCFilingsDetail[] UccFilingsDetail { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("corporateRegistration")]
        public BusinessCorporateRegistrationResult CorporateRegistration { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("executiveInformation")]
        public ExecutiveInformation[] ExecutiveInformation { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("businessFacts")]
        public BusinessFacts BusinessFacts { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("corporateLinkage")]
        public CorporateLinkage[] CorporateLinkage { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("commercialFraudShieldSummary")]
        public CommercialFraudShieldSummary CommercialFraudShieldSummary { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("expandedCreditSummary")]
        public ExpandedCreditSummary ExpandedCreditSummary { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("executiveSummary")]
        public ExecutiveSummary ExecutiveSummary { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("inquiries")]
        public Inquiries[] Inquiries { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("competitors")]
        public Competitors[] Competitors { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("proprietorNameAndAddress")]
        public ProprietorNameAndAddress[] ProprietorNameAndAddress { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("uccCoDebtors")]
        public UccCoDebtors[] UccCoDebtors { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("sicCodes")]
        public SICCode[] SicCodes { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("naicsCodes")]
        public NAICSCode[] NaicsCodes { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("scoreInformation")]
        public ScoreInformation ScoreInformation { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("stockExchange")]
        public string StockExchange { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("fortune1000")]
        public Fortune1000[] Fortune1000 { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("enhancedBusinessDescription")]
        public string EnhancedBusinessDescription { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("corporateFinancialInformation")]
        public CorporateFinancialInformation CorporateFinancialInformation { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("consumerStatement")]
        public ConsumerStatement[] ConsumerStatement { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("commercialGovernmentEntityCode")]
        public CommercialGovernmentEntityCode CommercialGovernmentEntityCode { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("economicDiversity")]
        public EconomicDiversity EconomicDiversity { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("governmentActivity")]
        public GovernmentActivity GovernmentActivity { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("contractSpendingSummary")]
        public ContractSpendingSummary ContractSpendingSummary { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("contractSpendingDetail")]
        public ContractSpendingDetail[] ContractSpendingDetail { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("leasingInformation")]
        public LeasingInformationResult[] LeasingInformation { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("licenseDetails")]
        public LicenseDetailsResult[] LicenseDetails { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("bondDetails")]
        public BondDetails[] BondDetails { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("insuranceDetails")]
        public InsuranceDetails[] InsuranceDetails { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("stocks")]
        public Stocks Stocks { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("commercialBankInformation")]
        public CommercialBankInformation[] CommercialBankInformation { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("aggregates")]
        public BizAggregates Aggregates { get; set; }
    }

    [Writable, DataContract]
    public class FsrScore
    {
        [WritableValue, DataMember]
        [JsonProperty("publiclyHeldCompany")]
        public bool? PubliclyHeldCompany { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("limitedProfile")]
        public bool? LimitedProfile { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("score")]
        public double? Score { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("profileNumber")]
        public string ProfileNumber { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("modelCode")]
        public string ModelCode { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("modelTitle")]
        public string ModelTitle { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("percentileRanking")]
        public double? PercentileRanking { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("probability")]
        public double? Probability { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("riskClass")]
        public RiskClass RiskClass { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("customerDisputeIndicator")]
        public bool? CustomerDisputeIndicator { get; set; }
    }

    [Writable, DataContract]
    public class CommercialScore
    {
        [WritableValue, DataMember]
        [JsonProperty("publiclyHeldCompany")]
        public bool? PubliclyHeldCompany { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("limitedProfile")]
        public bool? LimitedProfile { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("score")]
        public double? Score { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("profileNumber")]
        public string ProfileNumber { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("modelCode")]
        public string ModelCode { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("modelTitle")]
        public string ModelTitle { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("percentileRanking")]
        public double? PercentileRanking { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("probability")]
        public double? Probability { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("riskClass")]
        public RiskClass RiskClass { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("customerDisputeIndicator")]
        public bool? CustomerDisputeIndicator { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("customModelCode")]
        public string CustomModelCode { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("recommendedCreditLimitAmount")]
        public double? RecommendedCreditLimitAmount { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("highCreditLimitAmount")]
        public double? HighCreditLimitAmount { get; set; }
    }

    [Writable, DataContract]
    public class SpendByFiscalYear
    {
        [WritableValue, DataMember]
        [JsonProperty("year")]
        public double? Year { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("totalAmount")]
        public double? TotalAmount { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("singleHighestAmount")]
        public double? SingleHighestAmount { get; set; }
    }

    [Writable, DataContract]
    public class BalanceSheets
    {
        [WritableValue, DataMember]
        [JsonProperty("yearEnd")]
        public double? YearEnd { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("cashAndEquivalent")]
        public double? CashAndEquivalent { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("receivablesNet")]
        public double? ReceivablesNet { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("inventory")]
        public double? Inventory { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("otherCurrentAssets")]
        public double? OtherCurrentAssets { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("totalCurrentAssets")]
        public double? TotalCurrentAssets { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("fixedAssets")]
        public double? FixedAssets { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("investments")]
        public double? Investments { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("otherAssets")]
        public double? OtherAssets { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("totalAssets")]
        public double? TotalAssets { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("debtDueIn1Year")]
        public double? DebtDueIn1Year { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("notesPayable")]
        public double? NotesPayable { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("accountsPayable")]
        public double? AccountsPayable { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("taxesPayable")]
        public double? TaxesPayable { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("otherCurrentLiabilities")]
        public double? OtherCurrentLiabilities { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("totalCurrentLiabilities")]
        public double? TotalCurrentLiabilities { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("longTermDebt")]
        public double? LongTermDebt { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("otherLiabilities")]
        public double? OtherLiabilities { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("netWorth")]
        public double? NetWorth { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("totalLiabilitiesandNetWorth")]
        public double? TotalLiabilitiesandNetWorth { get; set; }
    }

    [Writable, DataContract]
    public class OperatingStatements
    {
        [WritableValue, DataMember]
        [JsonProperty("yearEnd")]
        public double? YearEnd { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("netSales")]
        public double? NetSales { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("costOfGoodsSold")]
        public double? CostOfGoodsSold { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("grossIncomeOnSales")]
        public double? GrossIncomeOnSales { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("expenses")]
        public double? Expenses { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("preTaxIncome")]
        public double? PreTaxIncome { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("taxes")]
        public double? Taxes { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("afterTaxes")]
        public double? AfterTaxes { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("extraordinaryIncome")]
        public double? ExtraordinaryIncome { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("netIncome")]
        public double? NetIncome { get; set; }
    }

    [Writable, DataContract]
    public class CriticalDataAndFinancialRatios
    {
        [WritableValue, DataMember]
        [JsonProperty("yearEnd")]
        public double? YearEnd { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("tangibleNetWorth")]
        public double? TangibleNetWorth { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("netWorkingCapital")]
        public double? NetWorkingCapital { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("currentRatio")]
        public double? CurrentRatio { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("totalDebttoTangibleNetWorth")]
        public double? TotalDebttoTangibleNetWorth { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("currentDebtToTangibleNetWorth")]
        public double? CurrentDebtToTangibleNetWorth { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("afterTaxIncomeToTangibleNetWorth")]
        public double? AfterTaxIncomeToTangibleNetWorth { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("afterTaxIncomeToNetSales")]
        public double? AfterTaxIncomeToNetSales { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("netSalestoInventory")]
        public double? NetSalestoInventory { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("costOfGoodsSoldToInventory")]
        public double? CostOfGoodsSoldToInventory { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("averageDaysSalesOutstanding")]
        public double? AverageDaysSalesOutstanding { get; set; }
    }

    [Writable, DataContract]
    public class Type
    {
        [WritableValue, DataMember]
        [JsonProperty("code")]
        public string Code { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("definition")]
        public string Definition { get; set; }
    }

    [Writable, DataContract]
    public class InquiryCount
    {
        [WritableValue, DataMember]
        [JsonProperty("month")]
        public double? Month { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("year")]
        public double? Year { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("count")]
        public double? Count { get; set; }
    }

    [Writable, DataContract]
    public class OfacMatchWarning
    {
        [WritableValue, DataMember]
        [JsonProperty("code")]
        public string Code { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("definition")]
        public string Definition { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("detailStatement")]
        public string DetailStatement { get; set; }
    }

    [Writable, DataContract]
    public class LowestTotalAccountBalance
    {
        [WritableValue, DataMember]
        [JsonProperty("amount")]
        public double? Amount { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("modifier")]
        public string Modifier { get; set; }
    }

    [Writable, DataContract]
    public class HighestTotalAccountBalance
    {
        [WritableValue, DataMember]
        [JsonProperty("amount")]
        public double? Amount { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("modifier")]
        public string Modifier { get; set; }
    }

    [Writable, DataContract]
    public class CurrentTotalAccountBalance
    {
        [WritableValue, DataMember]
        [JsonProperty("amount")]
        public double? Amount { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("modifier")]
        public string Modifier { get; set; }
    }

    [Writable, DataContract]
    public class BusinessDbt
    {
        [WritableValue, DataMember]
        [JsonProperty("code")]
        public double? Code { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("definition")]
        public string Definition { get; set; }
    }

    [Writable, DataContract]
    public class IndustryPaymentComparison
    {
        [WritableValue, DataMember]
        [JsonProperty("code")]
        public string Code { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("definition")]
        public string Definition { get; set; }
    }

    [Writable, DataContract]
    public class PaymentTrendIndicator
    {
        [WritableValue, DataMember]
        [JsonProperty("code")]
        public string Code { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("definition")]
        public string Definition { get; set; }
    }

    [Writable, DataContract]
    public class CommonTerms
    {
        [WritableValue, DataMember]
        [JsonProperty("first")]
        public string First { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("second")]
        public string Second { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("third")]
        public string Third { get; set; }
    }

    [Writable, DataContract]
    public class StatusFlag
    {
        [WritableValue, DataMember]
        [JsonProperty("definition")]
        public string Definition { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("code")]
        public string Code { get; set; }
    }

    [Writable, DataContract]
    public class FileEstablishedFlag
    {
        [WritableValue, DataMember]
        [JsonProperty("code")]
        public string Code { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("definition")]
        public string Definition { get; set; }
    }

    [Writable, DataContract]
    public class YearsInBusinessIndicator
    {
        [WritableValue, DataMember]
        [JsonProperty("code")]
        public string Code { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("definition")]
        public string Definition { get; set; }
    }

    [Writable, DataContract]
    public class Fortune1000
    {
        [WritableValue, DataMember]
        [JsonProperty("year")]
        public double? Year { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("rank")]
        public double? Rank { get; set; }
    }

    [Writable, DataContract]
    public class PaymentIndicator
    {
        [WritableValue, DataMember]
        [JsonProperty("code")]
        public string Code { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("definition")]
        public string Definition { get; set; }
    }

    [Writable, DataContract]
    public class RecentHighCredit
    {
        [WritableValue, DataMember]
        [JsonProperty("modifier")]
        public string Modifier { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("amount")]
        public double? Amount { get; set; }
    }

    [Writable, DataContract]
    public class AccountBalance
    {
        [WritableValue, DataMember]
        [JsonProperty("modifier")]
        public string Modifier { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("amount")]
        public double? Amount { get; set; }
    }

    [Writable, DataContract]
    public class TradelineFlag
    {
        [WritableValue, DataMember]
        [JsonProperty("code")]
        public string Code { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("definition")]
        public string Definition { get; set; }
    }

    [Writable, DataContract]
    public class NewlyReportedIndicator
    {
        [WritableValue, DataMember]
        [JsonProperty("code")]
        public string Code { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("definition")]
        public string Definition { get; set; }
    }

    [Writable, DataContract]
    public class MatchingBranchAddress
    {
        [WritableValue, DataMember]
        [JsonProperty("bin")]
        public string Bin { get; set; }

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
        [JsonProperty("zipExtension")]
        public string ZipExtension { get; set; }
    }

    [Writable, DataContract]
    public class BranchLocation
    {
        [WritableValue, DataMember]
        [JsonProperty("bin")]
        public string Bin { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("locationId")]
        public string LocationId { get; set; }
    }

    [Writable, DataContract]
    public class OriginalUCCFilingsInfo
    {
        [WritableValue, DataMember]
        [JsonProperty("legalAction")]
        public string LegalAction { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("filingState")]
        public string FilingState { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("documentNumber")]
        public string DocumentNumber { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("dateFiled")]
        public string DateFiled { get; set; }
    }

    [Writable, DataContract]
    public class Address2
    {
        [WritableValue, DataMember]
        [JsonProperty("city")]
        public string City { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("state")]
        public string State { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("zip")]
        public string Zip { get; set; }
    }

    [Writable, DataContract]
    public class IndustryPaymentTrends
    {
        [WritableValue, DataMember]
        [JsonProperty("sic")]
        public string Sic { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("trends")]
        public TradePaymentTrend[] Trends { get; set; }
    }

    [Writable, DataContract]
    public class UccFilingsSummary
    {
        [WritableValue, DataMember]
        [JsonProperty("uccFilingsCount")]
        public double? UccFilingsCount { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("uccFilingsTrends")]
        public UCCFilingsTrends[] UccFilingsTrends { get; set; }
    }

    [Writable, DataContract]
    public class BondDetails
    {
        [WritableValue, DataMember]
        [JsonProperty("bondAmount")]
        public double? BondAmount { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("bondEffectiveDate")]
        public string BondEffectiveDate { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("bondNumber")]
        public string BondNumber { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("bondCompany")]
        public string BondCompany { get; set; }
    }

    [Writable, DataContract]
    public class InsuranceDetails
    {
        [WritableValue, DataMember]
        [JsonProperty("insuranceEffectiveDate")]
        public string InsuranceEffectiveDate { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("insuranceExpirationDate")]
        public string InsuranceExpirationDate { get; set; }
    }

    [Writable, DataContract]
    public class Stocks
    {
        [WritableValue, DataMember]
        [JsonProperty("stockExchange")]
        public string StockExchange { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("tickerSymbol")]
        public string TickerSymbol { get; set; }
    }

    [Writable, DataContract]
    public class CommercialBankInformation
    {
        [WritableValue, DataMember]
        [JsonProperty("institutionType")]
        public string InstitutionType { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("relationship")]
        public string Relationship { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("institutionName")]
        public string InstitutionName { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("address")]
        public string Address { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("phone")]
        public string Phone { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("profileDate")]
        public string ProfileDate { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("openDate")]
        public string OpenDate { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("closeDate")]
        public string CloseDate { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("accountRating")]
        public string AccountRating { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("balanceRange")]
        public string BalanceRange { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("figuresInBalance")]
        public double? FiguresInBalance { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("balanceAmount")]
        public double? BalanceAmount { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("customerDisputeIndicator")]
        public bool? CustomerDisputeIndicator { get; set; }
    }

    [Writable, DataContract]
    public class RiskClass
    {
        [WritableValue, DataMember]
        [JsonProperty("code")]
        public double? Code { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("definition")]
        public string Definition { get; set; }
    }

    internal class DateFormatConverter : Newtonsoft.Json.Converters.IsoDateTimeConverter
    {
        public DateFormatConverter()
        {
            DateTimeFormat = "yyyy-MM-dd";
        }
    }

}
