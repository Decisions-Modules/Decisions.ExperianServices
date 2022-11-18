using System;
using Decisions.ExperianServices.ConsumerCreditProfile;
using Decisions.ExperianServices.Dao.CreditReport;
using Decisions.ExperianServices.Utilities;
using DecisionsFramework;
using DecisionsFramework.Design.Flow;

namespace Decisions.ExperianServices
{
    [AutoRegisterMethodsOnClass(true, "Experian", "Credit Profile", RegisterForAgents = true)]
    public class ExperianConsumerSteps
    {
        private static readonly Log Log = new(ExperianConstants.LogCat);
        private static readonly AuthenticationUtility AuthenticationUtility = new();
        private static readonly ConsumerReportFetcher ConsumerReportFetcher = new();

        /*
         * Deprecating Step in favor of a full step implementation required because we need the ability to set credentials
         * at that step level if we want to override the system specified Experian Credentials.
         */
        [Obsolete]
        [ExcludeMethodOnAutoRegister]
        public ExperianCreditReportResponse ExperianConsumerCreditProfile(ExperianCreditReportRequest request)
        {
            //Executing Oauth2 Request
            Log.Debug("Executing Oauth2 Request");
            AuthenticationUtility.ExecuteAuthRequest(ExperianApi.CreditProfile);

            //Executing Credit Report Request
            Log.Debug("Executing Consumer Credit Report Fetch");
            return ConsumerReportFetcher.ExecuteCreditProfileRequest(request, CreditProfileType.CreditReport);
        } 
        
        [Obsolete]
        [ExcludeMethodOnAutoRegister]
        public ExperianCreditReportResponse ExperianScoreOnlyPrequalification(ExperianCreditReportRequest request)
        {
            //Executing Oauth2 Request
            Log.Debug("Executing Oauth2 Request");
            AuthenticationUtility.ExecuteAuthRequest(ExperianApi.CreditProfile);

            //Executing Credit Report Request
            Log.Debug("Executing Consumer Credit Report Fetch");
            return ConsumerReportFetcher.ExecuteCreditProfileRequest(request, CreditProfileType.ScoreOnlyPrequalification);
        }
    }
}
