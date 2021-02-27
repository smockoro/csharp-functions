using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Amazon.Lambda.Core;

// Assembly attribute to enable the Lambda function's JSON input to be converted into a .NET class.
[assembly: LambdaSerializer(typeof(Amazon.Lambda.Serialization.SystemTextJson.DefaultLambdaJsonSerializer))]

namespace SampleAwsLambdaFunction
{
    public class Function
    {
        
        /// <summary>
        /// A simple function that takes a string and does a ToUpper
        /// </summary>
        /// <param name="input"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public ResponseJson FunctionHandler(RequestJson input, ILambdaContext context)
        {
            var res = new ResponseJson();
            res.Name = input.Name?.ToUpper();
            res.Message = input.Message?.ToUpper();
            return res;
        }
    }

    public class RequestJson 
    {
        public string Name {get; set;}
        public string Message {get; set;}
    }

    public class ResponseJson
    {
        public string Name {get; set;}
        public string Message {get; set;}
    }
}
