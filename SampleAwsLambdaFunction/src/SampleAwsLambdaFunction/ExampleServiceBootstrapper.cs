using System;
using SampleAwsLambdaFunction.Domain.Service;

namespace SampleAwsLambdaFunction
{
    public static class ExampleServiceBootstrapper
    {
        public static IExampleService CreateInstance()
        {
            var messageToReturn = LambdaConfiguration.Instance["MESSAGE_TO_RETURN"];

            return new ExampleService(messageToReturn);
        }
    }
}