using Xunit;
using SampleAwsLambdaFunction.Domain.Model;
using SampleAwsLambdaFunction.Domain.Service;

namespace SampleAwsLambdaFunction.Tests.Domain.Service
{
    public class ExampleServicetest
    {
        [Fact]
        public void TestGetServiceLogic()
        {
            var exampleService = new ExampleService("test message");
            var req = new RequestJson();
            req.Name = "sample";
            req.Message = "hello world";

            var res = exampleService.GetServiceLogic(req);

            Assert.Equal("SAMPLE", res.Name);
            Assert.Equal("HELLO WORLD", res.Message);
            Assert.Equal("test message", res.ServiceMessage);
        }
    }
}