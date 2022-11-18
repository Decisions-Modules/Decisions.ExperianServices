using System.Collections.Generic;
using Decisions.ExperianServices.Dao.Prequalification;
using DecisionsFramework;
using DecisionsFramework.Design.Flow;
using DecisionsFramework.Design.Flow.Mapping;
using DecisionsFramework.ServiceLayer;

namespace Decisions.ExperianServices
{
    public abstract class AbstractPrequalificationStep : AbstractExperianStep
    {
        public abstract override ResultData Run(StepStartData data);
        
        public override DataDescription[] InputData
        {
            get
            {
                DataDescription[] inputData = base.InputData;
                
                List<DataDescription> inputs = new List<DataDescription>(inputData)
                {
                    new (typeof(ExperianPrequalificationRequest), RequestText)
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
                        new DataDescription(typeof(ExperianPrequalificationResponse), ResponseText))
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
                     (string.IsNullOrEmpty(ModuleSettingsAccessor<ExperianSettings>.Instance.PrequalificationClientId) || 
                     string.IsNullOrEmpty(ModuleSettingsAccessor<ExperianSettings>.Instance.PrequalificationClientSecret)))
            {
                issues.Add(new ValidationIssue("If Credentials are not overridden, Client ID and Client Secret must be specified in the Experian Settings."));
            }

            return issues.ToArray();
        }
    }
}