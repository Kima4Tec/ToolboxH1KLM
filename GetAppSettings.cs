using Microsoft.Extensions.Configuration;
using System;

namespace ToolboxH1
{
    public class GetAppSettings
    {

        public static void Test()
        {
            IConfiguration config = new ConfigurationBuilder()
    .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
    .Build();

            string mySet = config["MySetting"];
            Console.WriteLine($"MySetting: {mySet}");
            string mySets = config.GetValue<string>("MainSetting:SubSetting");
            Console.WriteLine($"MySubSetting: {mySets}");
        }
    }
}
