using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleDotNetCore.Data
{
    public class Book
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(100)]
        public string Title { get; set; }
        [Required]
        [MaxLength(50)]

        public string Author { get; set; }
        [Required]

        public int BookPrice { get; set; }

    }
    class Bookcontext : DbContext
    {
        public DbSet<Book> Books { get; set; }
        private const string DB_SOURCE = "(localdb)\\MSSQLLocalDB";
        private const string DB_NAME = "FNFTraining";

        public IConfigurationRoot? Configuration { get; set; }
        private void ConfigureServices()
        {
            var conf = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("appsettings.json",false).Build();
            if (conf == null)
            {
                throw new Exception("config Failed");
            }
            Configuration = conf;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseSqlServer($"Data Source={DB_SOURCE};Initial Catalog={DB_NAME};Integrated Security=True;Encrypt=False;TrustServerCertificate=True");
            base.OnConfiguring(optionsBuilder);
            ConfigureServices();
            var connectionString= Configuration["connectionString"];
            optionsBuilder.UseSqlServer(connectionString);
        }
    }
}
