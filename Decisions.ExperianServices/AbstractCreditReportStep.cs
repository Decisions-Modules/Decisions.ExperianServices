using System.Collections.Generic;
using Decisions.ExperianServices.Dao.CreditReport;
using DecisionsFramework;
using DecisionsFramework.Design.Flow;
using DecisionsFramework.Design.Flow.Mapping;
using DecisionsFramework.ServiceLayer;

namespace Decisions.ExperianServices
{
    public abstract class AbstractCreditReportStep : AbstractExperianStep, IDataConsumer
    {
        public abstract override ResultData Run(StepStartData data);
        
        public DataDescription[] InputData
        {
            get
            {
                return new DataDescription[]
                {
                    new(typeof(ExperianCreditReportRequest), RequestText)
                };
            }
        }

        public override OutcomeScenarioData[] OutcomeScenarios
        {
            get
            {
                return new []
                {
                    new OutcomeScenarioData("Result",
                        new DataDescription(typeof(ExperianCreditReportResponse), CreditReportResponseText))
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
                     (string.IsNullOrEmpty(ModuleSettingsAccessor<ExperianSettings>.Instance.ExperianClientId) || 
                     string.IsNullOrEmpty(ModuleSettingsAccessor<ExperianSettings>.Instance.ExperianClientSecret)))
            {
                issues.Add(new ValidationIssue("If Credentials are not overridden, Client ID and Client Secret must be specified in the Experian Settings."));
            }

            return issues.ToArray();
        }
    }
}