using System;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace SampleAwsLambdaFunction
{
    public static class LambdaConfiguration
    {
        private static IConfigurationRoot instance = null;

        public static IConfigurationRoot Instance
        {
            get 
            {
                return instance ?? (instance = new ConfigurationBuilder()
                    .AddEnvironmentVariables()  // environment variables
                    .Build());
            }
        }
    }
}