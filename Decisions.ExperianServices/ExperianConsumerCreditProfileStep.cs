using System.Collections.Generic;
using Decisions.ExperianServices.ConsumerCreditProfile;
using Decisions.ExperianServices.Dao.CreditReport;
using Decisions.ExperianServices.Utilities;
using DecisionsFramework.Design.Flow;

namespace Decisions.ExperianServices
{
    [AutoRegisterStep("Experian Consumer Credit Profile", "Experian", "Credit Profile")]
    public class ExperianConsumerCreditProfileStep : AbstractCreditReportStep
    {
        public override ResultData Run(StepStartData data)
        {
            ExperianCreditReportRequest request = data[RequestText] as ExperianCreditReportRequest;

            SetUpInputVariables(data);

            //Executing Oauth2 Request
            Log.Debug("Executing Oauth2 Request");
            AuthenticationUtility.ExecuteAuthRequest(ExperianApi.CreditProfile, OverrideCredentials, UserName, Password, ClientId, ClientSecret);

            //Executing Credit Profile Request
            Log.Debug("Executing Consumer Credit Profile Fetch");
            ExperianCreditReportResponse response = ConsumerReportFetcher.ExecuteCreditProfileRequest(
                request, 
                CreditProfileType.CreditReport, 
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