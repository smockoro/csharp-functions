using System;

namespace SampleAwsLambdaFunction.Domain.Model 
{
    public class ResponseJson
    {
        public string Name {get; set;}
        public string Message {get; set;}
        public string ServiceMessage {get; set;}
    }
}