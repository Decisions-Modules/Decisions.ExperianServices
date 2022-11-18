using System.Collections.Generic;
using Decisions.ExperianServices.Dao.Verify;
using Decisions.ExperianServices.Utilities;
using Decisions.ExperianServices.Verify;
using DecisionsFramework.Design.Flow;

namespace Decisions.ExperianServices
{
    [AutoRegisterStep("Experian Verify Plus", "Experian", "Verify")]
    public class ExperianVerifyPlusStep : AbstractVerifyStep
    {
        public override ResultData Run(StepStartData data)
        {
            ExperianVerifyRequest request = data[RequestText] as ExperianVerifyRequest;

            SetUpInputVariables(data);

            //Executing Oauth2 Request
            Log.Debug("Executing Oauth2 Request");
            AuthenticationUtility.ExecuteAuthRequest(ExperianApi.Verify, OverrideCredentials, UserName, Password, ClientId, ClientSecret);

            //Executing Verify Request
            Log.Debug("Executing Verify Fetch");
            ExperianVerifyResponse response = VerifyFetcher.ExecuteVerifyRequest(
                request, 
                VerifyType.VerifyPlus, 
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