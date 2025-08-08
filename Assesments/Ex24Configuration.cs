using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;

namespace ConsoleApp1
{
    internal class Ex24Configuration
    {
        public static IConfiguration AppConfig { get; private set; }

        static void Main(string[] args)
        {
            var config = new ConfigurationBuilder()
                .SetBasePath(AppContext.BaseDirectory) // Use AppContext.BaseDirectory instead of Directory.GetCurrentDirectory()
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true) // Fix parameter name
                .Build();

            //AppConfig = config; // Assign the built configuration to AppConfig
            //var appName = AppConfig["AppSettings:AppName"];
            //var title = AppConfig["AppSettings:Title"];
            //Console.WriteLine($"~~~~~~~~~~{appName.ToUpper()}~~~~~~~~~~~~~~~~~~~");
           
            //Console.WriteLine($"~~~~~~~~~~{title.ToUpper()}~~~~~~~~~~~~~~~~~~~");
            //Console.ReadLine();
            
            var appsettings =  new AppSettings();
            config.GetSection("Appsettings").Bind(appsettings ); //Bind the configuration to class through an Extension Microsoft.Extensions.Configuration.Binder,this is widely used approch to read the configuration settings in a strongly typed manner
            Console.WriteLine(appsettings.Appname);
            Console.WriteLine(appsettings.Title);
            Console.ReadLine();
        } 
        class AppSettings
        {
            public string Appname {  get; set; } = string.Empty;
            public string Title { get; set; } = string.Empty;
        }
    }
}
