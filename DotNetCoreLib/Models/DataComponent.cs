using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Configuration;

namespace SampleMvcApp.Models
{
    [Table("CstTable")]
    public class Customer
    {
        [Key]
        public int CstId { get; set; }

        [Required(ErrorMessage ="Customer Name is Required")]
        public string CstName { get; set; }
        [Required(ErrorMessage ="Customer Address is Required")]
        public string CstAddress { get; set; }
        [Required(ErrorMessage ="Customer Bill Amount is Required")]
        public double BillAmount { get; set; }
    }

    public class CstDbContext : DbContext
    {
        public DbSet<Customer> Customers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=FNFTraining;Integrated Security=True;Encrypt=False;Trust Server Certificate=True");


            //var connectionString = Program.Configuration["connectionString:myCon"];

            //optionsBuilder.UseSqlServer(connectionString);
        }

    }
}
