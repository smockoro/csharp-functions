using Microsoft.Azure.Funtions.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection;
using SampleAzureFunction.Domain.Service;
using SampleAzureFunction.Domain.Repository;
using SampleAzureFunction.Repository;

[assembly: FunctionsStartup(typeof(SampleAzureFunction.Startup))]

namespace SampleAzureFunction
{
    public class Startup : FunctionsStartup
    {
        public override void Configure(IFunctionsHostBuilder builder)
        {
            builder.Services.AddSingleton<ITodoService>((svc) => {
                return new TodoService(new InMemoryTodoRepository());
            });
        }
    }    
}