using System.Runtime.Serialization;
using DecisionsFramework.Design.ConfigurationStorage.Attributes;
using Newtonsoft.Json;

namespace Decisions.ExperianServices.Dao.Prequalification
{
    [DataContract]
    [Writable]
    public class ExperianPrequalificationResponse
    {
        [DataMember]
        [WritableValue]
        [JsonProperty("customSolution")]
        public CustomSolution[] CustomSolution { get; set; }
    }
    
    [DataContract]
    [Writable] 
    public class CustomSolution
    {
        [JsonProperty("informationalMessage")]
        public InformationalMessage[] InformationalMessage { get; set; }
        
        [JsonProperty("riskModel")]
        public RiskModel[] RiskModel { get; set; }
        
        [JsonProperty("statement")]
        public Statement[] Statement { get; set; }
    }
    
    [DataContract]
    [Writable]
    public class InformationalMessage
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
    public class RiskModel
    {
        [JsonProperty("evaluation")]
        public string Evaluation { get; set; }

        [JsonProperty("modelIndicator")]
        public string ModelIndicator { get; set; }

        [JsonProperty("score")]
        public string Score { get; set; }

        [JsonProperty("scoreFactors")]
        public ScoreFactor[] ScoreFactors { get; set; }

        [JsonProperty("scorePercentile")]
        public string ScorePercentile { get; set; }
    }

    [DataContract]
    [Writable]
    public class ScoreFactor
    {
        [JsonProperty("importance")]
        public string Importance { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }
    }

    [DataContract]
    [Writable]
    public class Statement
    {
        [JsonProperty("dateReported")]
        public string DateReported { get; set; }

        [JsonProperty("statementText")]
        public string StatementText { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }
}