using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlazorApp.Shared
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        [Column("productName")]
        public string Name { get; set; }
        [Column("ProductPrice",TypeName= "decimal(18,2)")]
        public decimal Price { get; set; }
        [Column("ProductQuantity")]
        public int Quantity { get; set; }
    }
}
