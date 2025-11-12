using LaptopBMT.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LaptopBMT.Models
{
    public class OrderDetail
    {
        [Key]
        public int OrderDetailId { get; set; }

        [ForeignKey("Order")]
        public int OrderId { get; set; }

        [ForeignKey("Product")]
        public int ProductId { get; set; }

        public int Quantity { get; set; }
        public decimal UnitPrice { get; set; }

        // Navigation
        public Order? Order { get; set; }
        public Product? Product { get; set; }
    }
}
