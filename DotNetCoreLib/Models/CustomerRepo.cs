namespace SampleMvcApp.Models
{
    public class CustomerRepo
    {
        public void AddCustomer(Customer customer)
        {
            var context = new CstDbContext();
            context.Customers.Add(customer);
            context.SaveChanges();
        }
        public List<Customer> GetAllCustomers()
        {
            var context = new CstDbContext();
            return context.Customers.ToList();
        }
        public Customer GetCustomerById(int id)
        {
            var context = new CstDbContext();
            return context.Customers.FirstOrDefault( c=> c.CstId == id);
        }
        public void RemoveCustomer(int id)
        {
            var context = new CstDbContext();
            var customer = context.Customers.Find(id);
            if (customer != null)
            {
                context.Customers.Remove(customer);
                context.SaveChanges();
            }

        }
        public void UpdateCustomer(Customer customer)
        {
            var context = new CstDbContext();
            context.Customers.Update(customer);
            context.SaveChanges();
        }
    }
}
