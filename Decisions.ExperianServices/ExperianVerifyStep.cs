using System.Collections.Generic;
using Decisions.ExperianServices.Dao.Verify;
using Decisions.ExperianServices.Utilities;
using Decisions.ExperianServices.Verify;
using DecisionsFramework.Design.Flow;

namespace Decisions.ExperianServices
{
    [AutoRegisterStep("Experian Verify", "Experian", "Verify")]
    public class ExperianVerifyStep : AbstractVerifyStep
    {
        public override ResultData Run(StepStartData data)
        {
            ExperianVerifyRequest request = data[RequestText] as ExperianVerifyRequest;
            
            //Executing Oauth2 Request
            Log.Debug("Executing Oauth2 Request");
            AuthenticationUtility.ExecuteAuthRequest(ExperianApi.Verify, OverrideCredentials, UserName, Password, ClientId, ClientSecret);

            //Executing Verify Request
            Log.Debug("Executing Verify Fetch");
            ExperianVerifyResponse response = VerifyFetcher.ExecuteVerifyRequest(
                request, 
                VerifyType.Verify,
                request?.Requestor.SubscriberCode,
                OverrideCredentials, 
                ClientReferenceId);
            Dictionary<string, object> results = new Dictionary<string, object>
            {
                [VerifyResponseText] = response
            };

            return new ResultData("Result", results);
        }
    }
}