using System;
using SampleAwsLambdaFunction.Domain.Model;

namespace SampleAwsLambdaFunction.Domain.Service 
{
    public class ExampleService : IExampleService 
    {
        readonly private string serviceMessage;

        public ExampleService(string serviceMessage) 
        {
            this.serviceMessage = serviceMessage;
        }

        public ResponseJson GetServiceLogic(RequestJson requestJson)
        {
            var res = new ResponseJson();
            res.Name = requestJson.Name?.ToUpper();
            res.Message = requestJson.Message?.ToUpper();
            res.ServiceMessage = this.serviceMessage;
            return res;
        }
    }
}