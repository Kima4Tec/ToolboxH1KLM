using System.Linq;
using Microsoft.Extensions.Logging;
using System.Reflection;
using Microsoft.Extensions.DependencyInjection;
using ToolboxH1;

namespace ToolboxH1
{
public class LoggerInjector
    {
        private readonly ILogger _logger;

        public LoggerInjector(ILogger<LoggerInjector> logger)
        {
            _logger = logger;
        }

        public void InjectLogging(object obj)
        {
            var type = obj.GetType();
            var methods = type.GetMethods(BindingFlags.Instance | BindingFlags.Public)
                              .Where(m => !m.IsSpecialName); // Exclude special methods like properties or event handlers

            foreach (var method in methods)
            {
                var parameters = method.GetParameters()
                                       .Select(p => p.ParameterType)
                                       .ToArray();

                var logMethod = typeof(LoggerInjector).GetMethod(nameof(LogMethod), BindingFlags.Instance | BindingFlags.NonPublic)
                                                      .MakeGenericMethod(parameters);

                logMethod.Invoke(this, new object[] { obj, method });
            }
        }

        private void LogMethod<T>(object obj, MethodInfo method)
        {
            var type = obj.GetType();
            var methodName = method.Name;
            _logger.LogInformation($"Calling method {methodName} of class {type.FullName}");

            // You can also log method parameters, return value, etc.

            try
            {
                method.Invoke(obj, null);
                _logger.LogInformation($"Method {methodName} executed successfully");
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"Error executing method {methodName}");
            }
        }
    }

}

//Her er main:
//using System;
//using System.Linq;
//using System.Reflection;
//using Microsoft.Extensions.DependencyInjection;
//using Microsoft.Extensions.Logging;

//class Program
//{
//    static void Main(string[] args)
//    {
//        // Setup logging
//        var serviceProvider = new ServiceCollection()
//            .AddLogging(builder =>
//            {
//                builder.AddConsole(); // Example: logging to console
//                // Add other logging providers as needed (e.g., AddDebug, AddFile, etc.)
//            })
//            .BuildServiceProvider();

//        // Create an instance of LoggerInjector
//        var loggerInjector = new LoggerInjector(serviceProvider.GetRequiredService<ILogger<LoggerInjector>>());

//        // Discover and instantiate classes to inject logging into
//        var classes = Assembly.GetExecutingAssembly().GetTypes()
//                               .Where(type => type.IsClass && !type.IsAbstract && typeof(ILoggerInjected).IsAssignableFrom(type))
//                               .ToList();

//        foreach (var classType in classes)
//        {
//            var instance = Activator.CreateInstance(classType);
//            loggerInjector.InjectLogging(instance);
//        }

//        // Now all classes implementing ILoggerInjected have logging injected into them
//        // You can use the instances of these classes as needed
//    }
//}

//public interface ILoggerInjected
//{
//    // Marker interface to indicate classes that should have logging injected
//}

//// Example class
//public class YourClass : ILoggerInjected
//{
//    public void DoSomething()
//    {
//        Console.WriteLine("Doing something...");
//    }
//}

//// LoggerInjector class remains unchanged
