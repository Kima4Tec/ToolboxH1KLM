using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace ToolboxH1
{
    public class Program
    {
        private static IServiceProvider serviceProvider;
        public static void Main(string[] args)
        {
            //    //Arrays.MyCharArray();
            //Texts.MySubstring();
            //Texts.Reverse("Happiness");
            //Texts.Text("Text argument");
            //Texts.TextFun();
            //Arrays.array3[2] = 8;
            //Arrays.myCarArray();
            //ToolboxH1.Conventions getPrice = new ToolboxH1.Conventions ();
            //getPrice.Price = 191000;
            //Conditions.IfElseConditions();
            //Conditions.TryCatch();
            //Conditions.SwitchCase();
            //Conditions.SwitchCase2();
            //Console.WriteLine(Methods.StaticReturnMethod());
            //Loops.ForMethodWithModulus();
            //new Methods().TestTest3(); 
            Biler.PrintCars();
            //GetAppSettings.Test();              
            // Setup logging

            // Setup logging med provider
            // Tilføj logging og logging outpuut
            //build serviceprovider

            //ved brug: serviceprovider.getservice eller required
            //og så ILogger og klassen som type, hvor du vil bruge logging


            var serviceProvider = new ServiceCollection()
                .AddLogging(builder =>
                {
                    builder.AddConsole(); // Example: logging to console
                                          // Add other logging providers as needed (e.g., AddDebug, AddFile, etc.)
                })
                .BuildServiceProvider();

            // Example usage of logger in your main method
            var logger = serviceProvider.GetRequiredService<ILogger<Return>>();
            logger.LogInformation("Application starting up...");

            // Example usage of logger in your classes
            var yourClassInstance = new Return(logger);
            yourClassInstance.Returner();

            logger.LogInformation("Application shutting down...");

        }
    }
}

