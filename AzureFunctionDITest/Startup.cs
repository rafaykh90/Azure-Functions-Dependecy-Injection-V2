using AzureFunctionDITest.Implementation;
using AzureFunctionDITest.Interfaces;
using Microsoft.Azure.Functions.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection;

[assembly: FunctionsStartup(typeof(AzureFunctionDITest.Startup))]

namespace AzureFunctionDITest
{
    public class Startup : FunctionsStartup
    {
        public override void Configure(IFunctionsHostBuilder builder)
        {
            builder.Services.AddScoped<IGreeter, SimpleGreeter>();
        }
    }
}
