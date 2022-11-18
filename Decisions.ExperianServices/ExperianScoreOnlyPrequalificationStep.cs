using System.Collections.Generic;
using Decisions.ExperianServices.ConsumerCreditProfile;
using Decisions.ExperianServices.Dao.CreditReport;
using Decisions.ExperianServices.Utilities;
using DecisionsFramework.Design.Flow;

namespace Decisions.ExperianServices
{
    [AutoRegisterStep("Experian Score Only Prequalification", "Experian", "Credit Profile")]
    public class ExperianScoreOnlyPrequalificationStep : AbstractCreditReportStep
    {
        public override ResultData Run(StepStartData data)
        {
            ExperianCreditReportRequest request = data[RequestText] as ExperianCreditReportRequest;

            SetUpInputVariables(data);

            //Executing Oauth2 Request
            Log.Debug("Executing Oauth2 Request");
            AuthenticationUtility.ExecuteAuthRequest(ExperianApi.CreditProfile, OverrideCredentials, UserName, Password, ClientId, ClientSecret);
            
            //Executing Score Only Pre-qualification Request
            Log.Debug("Executing Score Only Pre-qualification Fetch");
            ExperianCreditReportResponse response = ConsumerReportFetcher.ExecuteCreditProfileRequest(
                request, 
                CreditProfileType.ScoreOnlyPrequalification, 
                OverrideCredentials, 
                ClientReferenceId);
            Dictionary<string, object> results = new Dictionary<string, object>
            {
                [CreditReportResponseText] = response
            };

            return new ResultData("Result", results);
        }
    }
}