using CollectionAssignment.DataLayer;
using CollectionAssignment.Entities;
using CollectionAssignment.Utilities;
using SampleConApp;
using System;
using System.Buffers;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionAssignment.Entities
{
    class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Address { get; set; } = string.Empty;
        public double BillAmount {  get; set; }
    }
    enum Operations { Add=1, Remove,Update,Find,GetAll }
}
namespace CollectionAssignment.DataLayer
{
   interface ICustomerManager
    {
        void AddCustomer(Customer cst);
        void UpdateCustomer(int id ,Customer cst);
        // Fix for RemoveCustomer (DeleteCustomer) method to avoid null dereference
        public void DeleteCustomer(int id);
        
        Customer FindCustomer(int id);
        IEnumerable<Customer> GetAllCustomers();
    }
    class CustomerManager : ICustomerManager
    {
        public void AddCustomer(Customer cst)
        {
            var orignal = GetAllCustomers() as List<Customer>;
            //add the new customer to the list
            orignal.Add(cst);
            //save it back to the file.
            CustomerUtil.SaveAllCustomers(orignal);

        }
        public void DeleteCustomer(int id)
        {
            var orignal = GetAllCustomers() as List<Customer>;
            if (orignal == null)
                throw new Exception("Customer list could not be loaded.");

            var selectedCst = orignal.Find(rec => rec.Id == id);
            if (selectedCst != null)
            {
                orignal.Remove(selectedCst);
                CustomerUtil.SaveAllCustomers(orignal);
            }
            else
            {
                throw new Exception("Customer not found to delete");
            }

        }
        public void UpdateCustomer(int id, Customer cst)
        {
            var orignal = GetAllCustomers() as List<Customer>;
            if (orignal == null)
                throw new Exception("Customer list could not be loaded.");

            //find the customer to update
            var sel = orignal.Find(rec => rec.Id == id);
            if (sel != null)
            {
                //update the customer details
                sel.Name = cst.Name;
                sel.Address = cst.Address;
                sel.BillAmount = cst.BillAmount;

                // Save changes back to file
                CustomerUtil.SaveAllCustomers(orignal);
            }
            else
            {
                throw new Exception("Customer not found to update");
            }
        }
        public Customer FindCustomer(int id)
        {
            var original = GetAllCustomers() as List<Customer>;
            //remove the element based on the id
            var selectedCst = original.Find(rec => rec.Id == id);
            if (selectedCst != null)
            {
                return selectedCst;
            }
            else
            {
                throw new Exception("Customer does not exist");
            }

        }
        public IEnumerable<Customer> GetAllCustomers()
        {
            var filePath = CustomerUtil.cstFile;
            var list = new List<Customer>();
            if (!File.Exists(filePath))
            {
                return list;
            }
            var lines = File.ReadAllLines(filePath);
            foreach (string line in lines)
            {
                var words = line.Split(',');
                var cst = new Customer
                {
                    Id = int.Parse(words[0]),
                    Name = words[1],
                    Address = words[2],
                    BillAmount = double.Parse(words[3])
                };
                list.Add(cst);
            }
            return list;

        }
    }
}
namespace CollectionAssignment.UILayer
{
    class CustomermanagementSoftware
    {
        static ICustomerManager mgr = new CustomerManager();
        static void Main(string[] args)
        {
            var menu = CustomerUtil.GetMenu();
            bool processing = false;
            do
            {
                var choice = ConsoleUtil.GetInputInt(menu);
                Operations selectedoperation = (Operations) choice;
                processing = processmenu(selectedoperation);
                _ = ConsoleUtil.GetInputString("Press ENTER to continue");
                Console.Clear();


            } while (processing);
        }
        public static bool processmenu(Operations operation)
        {
            switch (operation)
            {
                case Operations.Add:
                    Add();
                    break;
                case Operations.Remove:
                    Remove();
                    break;
                case Operations.Update:
                    Update();
                    break;
                case Operations.Find:
                    Get();
                    break;
                case Operations.GetAll:
                    GetAll();
                    break;
                default:
                    return false;
            }
            return true;
        }

        private static void GetAll()
        {
            var records = mgr.GetAllCustomers();
            foreach (var record in records)
            {
                Console.WriteLine($"{record.Name} from {record.Address} has billed {record.BillAmount:C}");

            }

        }

        private static void Get()
        {
            int id = ConsoleUtil.GetInputInt("Enter the id to find employee");
            try
            {
                var record = mgr.FindCustomer(id);
                Console.WriteLine($"{record.Name} from {record.Address} has billed {record.BillAmount:C}");

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }

        private static void Update()
        {
            int id = ConsoleUtil.GetInputInt("Enter the id to update");
            Customer cst = new Customer();
                cst.Name = ConsoleUtil.GetInputString("Enter the name");
                cst.Address = ConsoleUtil.GetInputString("Enter the address");
                cst.BillAmount = ConsoleUtil.GetInputInt("Enter the id");

            mgr.UpdateCustomer(id, cst);

        }

        private static void Remove()
        {
            int id = ConsoleUtil.GetInputInt("Enter the id to remove");
            mgr.DeleteCustomer(id);
            Console.WriteLine("Customer removed Successfully");
        }

        private static void Add()
        {
            Customer cst = new Customer();
            cst.Id = ConsoleUtil.GetInputInt("Enter the id");
            cst.Name = ConsoleUtil.GetInputString("Enter the name");
            cst.Address = ConsoleUtil.GetInputString("Enter the address");
            cst.BillAmount = ConsoleUtil.GetInputInt("Enter the id");
            mgr.AddCustomer(cst);

        }
    }
}
namespace CollectionAssignment.Utilities
{
   class CustomerUtil
    {
        const string menuFile = "C:\\Users\\6152777\\Desktop\\Menu.txt"; //create the file of menu
        public const string cstFile = "C:\\Users\\6152777\\Desktop\\cstFile.csv";
        public static string GetMenu() //method to read the menu file
        {
            var contents = File.ReadAllText(menuFile);
            return contents;
        }
        public static void SaveAllCustomers(IEnumerable<Customer> customers)
        {
            var lines = string.Empty;
            foreach (var item in customers)
            {
                var line = $"{item.Id}, {item.Name}, {item.Address}, {item.BillAmount}\n";
                lines += line;
            }
            File.WriteAllText(cstFile, lines); // Add the data to cstFile and saves it
        }
    }
}



