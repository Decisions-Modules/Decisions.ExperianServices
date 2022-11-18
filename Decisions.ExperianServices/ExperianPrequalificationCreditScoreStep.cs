using System.Collections.Generic;
using Decisions.ExperianServices.Dao.Prequalification;
using Decisions.ExperianServices.Prequalification;
using Decisions.ExperianServices.Utilities;
using DecisionsFramework.Design.Flow;

namespace Decisions.ExperianServices
{
    [AutoRegisterStep("Experian Prequalification Credit Score", "Experian", "Prequalification")]
    public class ExperianPrequalificationCreditScoreStep : AbstractPrequalificationStep
    {
       public override ResultData Run(StepStartData data)
        {
            ExperianPrequalificationRequest request = data[RequestText] as ExperianPrequalificationRequest;

            SetUpInputVariables(data);

            //Executing Oauth2 Request
            Log.Debug("Executing Oauth2 Request");
            AuthenticationUtility.ExecuteAuthRequest(ExperianApi.Prequalification, OverrideCredentials, UserName, Password, ClientId, ClientSecret);
            
            //Executing Pre-qualification Credit Score Request
            Log.Debug("Executing Pre-qualification Credit Score Fetch");
            ExperianPrequalificationResponse response = PrequalificationFetcher.ExecutePrequalificationRequest(
                request, 
                PrequalificationType.CreditScore, 
                OverrideCredentials, 
                ClientReferenceId);
            Dictionary<string, object> results = new Dictionary<string, object>
            {
                [ResponseText] = response
            };

            return new ResultData("Result", results);
        }
    }
}