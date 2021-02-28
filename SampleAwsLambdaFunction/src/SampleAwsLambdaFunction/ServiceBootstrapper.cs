using System;
using SampleAwsLambdaFunction.Domain.Service;

namespace SampleAwsLambdaFunction
{
    public static class ServiceBootstrapper
    {
        public static IExampleService CreateInstance()
        {
            var messageToReturn = "messageToServiceReturn";

            return new ExampleService(messageToReturn);
        }
    }
}