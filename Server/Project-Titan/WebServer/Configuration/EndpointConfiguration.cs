using System;

namespace WebServer.Configuration
{
    public static class EndpointConfiguration
    {
        private const string DebugPrefix = "http://*:8443/";
        private const string ReleasePrefix = "https://*.trialsoftitan.com/";
        private const string DefaultDynamoEndpoint = "http://localhost:8000";

        public static string GetWebPrefix(bool isDebug)
        {
            var envPrefix = Environment.GetEnvironmentVariable("WEB_PREFIX");
            if (!string.IsNullOrWhiteSpace(envPrefix))
                return envPrefix;

            return isDebug ? DebugPrefix : ReleasePrefix;
        }

        public static string GetDynamoDbEndpoint()
        {
            var envEndpoint = Environment.GetEnvironmentVariable("DYNAMO_ENDPOINT");
            if (!string.IsNullOrWhiteSpace(envEndpoint))
                return envEndpoint;

            return DefaultDynamoEndpoint;
        }
    }
}
