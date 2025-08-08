using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp1.CustomCollections;

namespace ConsoleApp1
{
    internal class Ex21FileIOExample
    {
        static void Main(string[] args)
        {
            //getfile();
            //creatrefile();
            creatingCSVFile();
            readfileCSVFile();
        }

        static void getfile()
        {
            var files = Directory.GetFiles("C:\\Users\\6152777\\Desktop\\Visual Studio Start\\ConsoleApp1\\Assignments");
            foreach (var item in files)
            {
                var selected_file = new FileInfo(item);
                Console.WriteLine($"the name {selected_file} is created on {selected_file.CreationTime}");


                
            }
        }
        static void creatrefile()
        {

            Console.WriteLine("Displaying Directories and its Info");
            var directorys = Directory.GetDirectories("C:\\Users\\6152777\\Desktop\\Visual Studio Start\\ConsoleApp1\\Assignments");
            foreach (var dirPath in directorys)
            {
                var dir = new DirectoryInfo(dirPath);
                Console.WriteLine(dir.Name);
            }

            var newDir = "C:\\Testdir";
            var dirInfo = Directory.CreateDirectory(newDir);
            var parent = dirInfo.Parent;
            foreach (var dir_path in directorys)
            {
                var info = new DirectoryInfo(dir_path);
                foreach (var file in info.GetFiles())
                {
                    Console.WriteLine(file.Name);
                }
            }
        }
        private static void creatingCSVFile()
        {
            var customer = new Customer
            {
                CustomerId = 123,
                CustomerName = "jade",
                BillAmount = 4000
            };
            var filepath = "C:\\Users\\6152777\\Desktop\\Visual Studio Start\\ConsoleApp1\\Assignments";
            var content = $"{customer.CustomerId} , {customer.CustomerName} .{customer.BillAmount}";
            File.WriteAllText(filepath, content);
        }
        private static void readfileCSVFile()
        {
            var filepath = "C:\\Users\\6152777\\Desktop\\Visual Studio Start\\ConsoleApp1\\Assignments";
            if (File.Exists(filepath))
            {
                var content = File.ReadAllText(filepath);
                var paths = content.Split(',');
                if (paths.Length == 3)
                {
                    var customer = new Customer
                    {
                        CustomerId = int.Parse(paths[0]),
                        CustomerName = paths[1],
                        BillAmount = double.Parse(paths[2])
                    };
                    Console.WriteLine($"Customer Id : {customer.CustomerId}  , Customername is : {customer.CustomerName}, Customer billamount is {customer.BillAmount}");

                }
                else
                {
                    Console.WriteLine("invalid csv format");
                }
               
            }
        }
    }
}
