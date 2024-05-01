using Microsoft.Extensions.DependencyInjection;

namespace ToolboxH1
{
    internal class DIexplained
    {
        // Define the interface for the service
        public interface IMyService
        {
            void DoSomething();
        }

        // Implement the service interface
        public class MyService : IMyService
        {
            public void DoSomething()
            {
                // Implement the functionality of the service here
            }
        }

        // Register services with the dependency injection container
        public void ConfigureServices(IServiceCollection services)
        {
            // Add a transient registration for IMyService with MyService
            services.AddTransient<IMyService, MyService>();
        }

        // Example of a controller using dependency injection
        public class MyController : ControllerBase
        {
            private readonly IMyService _myService;

            // Constructor injection to receive an instance of IMyService
            public MyController(IMyService myService)
            {
                _myService = myService;
            }

            // Use _myService instance to call methods defined in the interface
        }
    }
}
