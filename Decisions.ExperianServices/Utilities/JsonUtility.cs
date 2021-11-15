using DecisionsFramework;
using Newtonsoft.Json.Linq;

namespace Decisions.ExperianServices.Utilities
{
    public static class JsonUtility
    {
        private static readonly Log log = new Log(ExperianConstants.LogCat);

        /*
         * Print a JSON string into the console in value pairs.
         */
        public static void ParseAndLogJson(string response)
        {
            JObject parsed = JObject.Parse(response);

            foreach (var pair in parsed)
            {
                log.Debug("{0}: {1}", pair.Key, pair.Value);
            }
        }
    }
}
