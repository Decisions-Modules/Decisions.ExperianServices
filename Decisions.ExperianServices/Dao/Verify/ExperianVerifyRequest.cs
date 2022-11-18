using System.Runtime.Serialization;
using Decisions.ExperianServices.Dao.CreditReport;
using DecisionsFramework.Design.ConfigurationStorage.Attributes;

namespace Decisions.ExperianServices.Dao.Verify
{
    [DataContract]
    [Writable]
    public class ExperianVerifyRequest : ExperianCreditReportRequest
    {
        /*
         * So far there are no known differences between this and the Credit Report Request schema but we want to
         * separate them out in case there are differences and for naming purposes.
         */
    }
}