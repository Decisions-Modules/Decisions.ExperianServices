using System.Collections.Generic;
using Decisions.ExperianServices.Dao.Verify;
using DecisionsFramework;
using DecisionsFramework.Design.Flow;
using DecisionsFramework.Design.Flow.Mapping;
using DecisionsFramework.ServiceLayer;

namespace Decisions.ExperianServices
{
    public abstract class AbstractVerifyStep : AbstractExperianStep
    {
        protected const string SubCodeText = "Sub Code";
        
        protected string SubCode = "";
        
        public abstract override ResultData Run(StepStartData data);

        public override DataDescription[] InputData
        {
            get
            {
                DataDescription[] inputData = base.InputData;
                
                List<DataDescription> inputs = new List<DataDescription>(inputData)
                {
                    new (typeof(ExperianVerifyRequest), RequestText)
                };

                if (OverrideCredentials)
                {
                    inputs.Add(new DataDescription(typeof(string), SubCodeText));
                }

                return inputs.ToArray();
            }
        }

        public override OutcomeScenarioData[] OutcomeScenarios
        {
            get
            {
                return new []
                {
                    new OutcomeScenarioData("Result",
                        new DataDescription(typeof(ExperianVerifyResponse), VerifyResponseText))
                };
            }
        }
        
        public override ValidationIssue[] GetValidationIssues()
        {
            List<ValidationIssue> issues = new List<ValidationIssue>(base.GetValidationIssues());
            
            if (OverrideCredentials && 
                (string.IsNullOrEmpty(ClientId) || 
                 string.IsNullOrEmpty(ClientSecret) || 
                 string.IsNullOrEmpty(SubCode)))
            {
                issues.Add(new ValidationIssue("If Credentials are overridden, Client ID, Client Secret, and Sub Code must be specified in the step properties."));
            }
            else if (!OverrideCredentials && 
                     (string.IsNullOrEmpty(ModuleSettingsAccessor<ExperianSettings>.Instance.VerifyClientId) || 
                      string.IsNullOrEmpty(ModuleSettingsAccessor<ExperianSettings>.Instance.VerifyClientSecret) || 
                      string.IsNullOrEmpty(ModuleSettingsAccessor<ExperianSettings>.Instance.VerifySubCode)))
            {
                issues.Add(new ValidationIssue("If Credentials are not overridden, Client ID, Client Secret, and Sub Code must be specified in the Experian Settings."));
            }

            return issues.ToArray();
        }
    }
}