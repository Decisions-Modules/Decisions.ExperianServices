using System.Collections.Generic;
using Decisions.ExperianServices.PremierProfiles;
using Decisions.ExperianServices.Dao.PremierProfiles;
using Decisions.ExperianServices.Utilities;
using DecisionsFramework;
using DecisionsFramework.Design.Flow;
using DecisionsFramework.Design.Flow.Mapping;
using DecisionsFramework.ServiceLayer;

namespace Decisions.ExperianServices
{
    [AutoRegisterStep("Experian Premier Profiles", "Experian", "Premier Profiles")]
    public class ExperianPremierProfilesStep : AbstractExperianStep, IDataConsumer
    {
        protected const string RESPONSE_OUTPUT = "Premier Profiles Response";

        public DataDescription[] InputData
            => new DataDescription[] { new(typeof(ExperianPremierProfilesRequest), RequestText) };

        public override OutcomeScenarioData[] OutcomeScenarios
            => new OutcomeScenarioData[] { new("Result", new DataDescription(typeof(PremierProfilesResponse), RESPONSE_OUTPUT)) };

        public override ResultData Run(StepStartData data)
        {
            ExperianPremierProfilesRequest request = data[RequestText] as ExperianPremierProfilesRequest;

            Log.Debug("Executing Oauth2 Request");
            AuthenticationUtility.ExecuteAuthRequest(ExperianApi.PremierProfiles, OverrideCredentials, UserName, Password, ClientId, ClientSecret);

            Log.Debug("Executing Premier Profiles Request");
            PremierProfilesResponse response = PremierProfilesFetcher
                .ExecutePremierProfilesRequest(request, OverrideCredentials, ClientReferenceId);

            Dictionary<string, object> results = new Dictionary<string, object>
            {
                [RESPONSE_OUTPUT] = response
            };

            return new ResultData("Result", results);
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
                     (string.IsNullOrEmpty(ModuleSettingsAccessor<ExperianSettings>.Instance.PremierProfilesClientId) || 
                     string.IsNullOrEmpty(ModuleSettingsAccessor<ExperianSettings>.Instance.PremierProfilesClientSecret)))
            {
                issues.Add(new ValidationIssue("If Credentials are not overridden, Client ID and Client Secret must be specified in the Experian Settings."));
            }

            return issues.ToArray();
        }
    }
}