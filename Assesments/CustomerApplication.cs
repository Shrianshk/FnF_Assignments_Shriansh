using SampleConApp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Customer
    {
        public int CustomerId { get; set; }
        public string CustomerName { get; set; }
        public double BillAmount { get; set; }
    }
    class CustomerCollection
    {
        private List<Customer> customers = new List<Customer>();

        public void AddCustomer(Customer customer) => customers.Add(customer);
        public Customer GetCustomer(int customerId) => customers.Find(c => c.CustomerId == customerId);
        public void RemoveCustomer(int customerId)
        {
            var customer = GetCustomer(customerId);
            if (customer != null)
            {
                customers.Remove(customer); //exit
                return;
            }
            
        }
        public List<Customer> GetAllCustomers() => customers;
    }
    internal class CustomerApplication
    {
        static void Main(string[] args)
        {
            Console.WriteLine("------------------CUSTOMER MANAGEMENT PROGRAM-------------------");
            bool processing = false;
            do
            {
                Console.WriteLine("TO ADD NEW CUSTOMER PRESS 1");
                Console.WriteLine("TO REMOVE CUSTOMER PRESS 2");
                Console.WriteLine("TO UPDATE CUSTOMER PRESS 3");
                Console.WriteLine("TO SEARCH CUSTOMER PRESS 4");
                Console.WriteLine("TO DISPLAY ALL CUSTOMER PRESS 5");
                int a =  ConsoleUtil.GetInputInt("ENter your choice");
                
            }while(processing);
        }

    }
}
