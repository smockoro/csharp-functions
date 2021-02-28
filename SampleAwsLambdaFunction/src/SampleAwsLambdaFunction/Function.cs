using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SampleAwsLambdaFunction.Domain.Model;
using SampleAwsLambdaFunction.Domain.Service;

using Amazon.Lambda.Core;

// Assembly attribute to enable the Lambda function's JSON input to be converted into a .NET class.
[assembly: LambdaSerializer(typeof(Amazon.Lambda.Serialization.SystemTextJson.DefaultLambdaJsonSerializer))]

namespace SampleAwsLambdaFunction
{
    public class Function
    {
        private readonly IExampleService exampleService;
        
        // Default ctor
        public Function()
            : this (ExampleServiceBootstrapper.CreateInstance()) {}
        
        // Injection ctor
        public Function(IExampleService exampleService)
        {
            this.exampleService = exampleService;
        }
        
        public ResponseJson FunctionHandler(RequestJson input, ILambdaContext context)
        {
            context.Logger.LogLine("get service Logic");
            return this.exampleService.GetServiceLogic(input);
        }
    }
}
