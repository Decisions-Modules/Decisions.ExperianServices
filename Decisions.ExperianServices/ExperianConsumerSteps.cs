using Decisions.ExperianServices.ConsumerCreditProfile;
using Decisions.ExperianServices.Dao.CreditReport;
using Decisions.ExperianServices.Utilities;
using DecisionsFramework;
using DecisionsFramework.Design.Flow;

namespace Decisions.ExperianServices
{
    [AutoRegisterMethodsOnClass(true, "Experian", "Credit Profile", RegisterForAgents = true)]
    class ExperianConsumerSteps
    {
        private static readonly Log Log = new(ExperianConstants.LogCat);
        private static readonly AuthenticationUtility AuthenticationUtility = new();
        private static readonly ConsumerReportFetcher ConsumerReportFetcher = new();

        public static ExperianCreditReportResponse ExperianConsumerCreditProfile(ExperianCreditReportRequest request)
        {
            //Executing Oauth2 Request
            Log.Debug("Executing Oauth2 Request");
            AuthenticationUtility.ExecuteAuthRequest(ExperianApi.CreditProfile);

            //Executing Credit Report Request
            Log.Debug("Executing Consumer Credit Report Fetch");
            return ConsumerReportFetcher.ExecuteCreditReportRequest(request);
        } 
    }
}
