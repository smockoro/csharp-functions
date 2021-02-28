using System;
using SampleAwsLambdaFunction.Domain.Model;

namespace SampleAwsLambdaFunction.Domain.Service 
{
    public interface IExampleService 
    {
        ResponseJson GetServiceLogic(RequestJson req);
    }
}