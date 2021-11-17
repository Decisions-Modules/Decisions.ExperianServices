using Decisions.ExperianServices.Dao.Prequalification;
using Decisions.ExperianServices.Prequalification;
using Decisions.ExperianServices.Utilities;
using DecisionsFramework;
using DecisionsFramework.Design.Flow;

namespace Decisions.ExperianServices
{
    [AutoRegisterMethodsOnClass(true, "Experian", "Prequalification", RegisterForAgents = true)]
    class ExperianPrequalificationSteps
    {
        private static readonly Log Log = new(ExperianConstants.LogCat);
        private static readonly AuthenticationUtility AuthenticationUtility = new();
        private static readonly PrequalificationFetcher PrequalificationFetcher = new();

        public static ExperianPrequalificationResponse ExperianPrequalification(ExperianPrequalificationRequest request)
        {
            //Executing Oauth2 Request
            Log.Debug("Executing Oauth2 Request");
            AuthenticationUtility.ExecuteAuthRequest(ExperianApi.Prequalification);

            //Executing Prequalification Report Request
            Log.Debug("Executing Prequalification Request");
            return PrequalificationFetcher.ExecutePrequalificationRequest(request);
        } 
    }
}
