using Decisions.ExperianServices.ConsumerCreditProfile;
using Decisions.ExperianServices.Dao.CreditReport;
using DecisionsFramework;
using DecisionsFramework.Design.Flow;

namespace Decisions.ExperianServices
{
    [AutoRegisterMethodsOnClass(true, "Credit Profile", "Experian Steps", RegisterForAgents = true)]
    class ExperianConsumerSteps
    {
        private static readonly Log log = new Log(ExperianConstants.LogCat);
        private static readonly ConsumerReportFetcher ConsumerReportFetcher = new ConsumerReportFetcher();

        public static ExperianCreditReportResponse ExperianConsumerCreditProfile(ExperianCreditReportRequest request)
        {
            //Executing Oauth2 Request
            log.Debug("Executing Oauth2 Request");
            ConsumerReportFetcher.ExecuteAuthRequest();

            //Executing Credit Report Request
            log.Debug("Executing Consumer Credit Report Fetch");
            return ConsumerReportFetcher.ExecuteCreditReportRequest(request);
        } 
    }
}
