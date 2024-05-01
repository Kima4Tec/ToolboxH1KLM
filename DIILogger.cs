using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace ToolboxH1
{
    public class DIILogger //Should be starting file
    {
        //Install
        //Microsoft.Extensions.Logging
        //Microsoft.Extensions.Logging.Console

        //Configure logging in my application
        public void ConfigureServices(IServiceCollection services)
        {
            //Add logging
            services.AddLogging(builder => 
            {  
                builder.AddConsole(); //Here it logs to the console. Add other logging providers if needed
            });
            //Here is place for service registrations
            services.AddTransient<MyService>();

        }

        //Now it is configure and ready to use.

    }
}
