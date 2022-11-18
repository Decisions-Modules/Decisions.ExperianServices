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
                        new DataDescription(typeof(ExperianVerifyResponse), CreditReportResponseText))
                };
            }
        }
        
        public override ValidationIssue[] GetValidationIssues()
        {
            List<ValidationIssue> issues = new List<ValidationIssue>(base.GetValidationIssues());
            
            if (OverrideCredentials && 
                (string.IsNullOrEmpty(ClientId) || 
                 string.IsNullOrEmpty(ClientSecret)))
            {
                issues.Add(new ValidationIssue("If Credentials are overridden, Client ID and Client Secret must be specified in the step properties."));
            }
            else if (!OverrideCredentials && 
                     (string.IsNullOrEmpty(ModuleSettingsAccessor<ExperianSettings>.Instance.VerifyClientId) || 
                      string.IsNullOrEmpty(ModuleSettingsAccessor<ExperianSettings>.Instance.VerifyClientSecret)))
            {
                issues.Add(new ValidationIssue("If Credentials are not overridden, Client ID and Client Secret must be specified in the Experian Settings."));
            }

            return issues.ToArray();
        }
    }
}