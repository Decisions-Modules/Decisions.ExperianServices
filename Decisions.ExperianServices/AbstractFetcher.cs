using DecisionsFramework;
using Newtonsoft.Json;

namespace Decisions.ExperianServices
{
    public class AbstractFetcher
    {
        protected static readonly Log Log = new(ExperianConstants.LogCat);
        
        protected static readonly JsonSerializerSettings JsonSettings = new()
        {
            NullValueHandling = NullValueHandling.Ignore
        };
    }
}