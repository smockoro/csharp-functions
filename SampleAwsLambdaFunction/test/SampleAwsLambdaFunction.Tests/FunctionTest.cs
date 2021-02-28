using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Xunit;
using Amazon.Lambda.Core;
using Amazon.Lambda.TestUtilities;

using SampleAwsLambdaFunction;
using SampleAwsLambdaFunction.Domain.Model;

namespace SampleAwsLambdaFunction.Tests
{
    public class FunctionTest
    {
        [Fact]
        public void TestToUpperFunction()
        {

            // Invoke the lambda function and confirm the string was upper cased.
            var function = new Function();
            var context = new TestLambdaContext();

            var req = new RequestJson();
            req.Name = "sample";
            req.Message = "hello world";

            var res = function.FunctionHandler(req, context);

            Assert.Equal("SAMPLE", res.Name);
            Assert.Equal("HELLO WORLD", res.Message);
            Assert.Equal("messageToServiceReturn", res.ServiceMessage);
        }
    }
}
