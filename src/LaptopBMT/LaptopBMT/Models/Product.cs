using System.ComponentModel.DataAnnotations;

namespace LaptopBMT.Models
{
    public class Product
    {
        [Key]
        public int ProductId { get; set; }


        [Display(Name = "Tên sản phẩm")]
        public string? Name { get; set; }

        [Display(Name = "Hãng")]
        public string? Brand { get; set; }
        public string? Description { get; set; }
        [Display(Name = "Giá")]
        public decimal Price { get; set; }

        [Display(Name = "Ảnh")]
        public string? ImageUrl { get; set; }
    }
}
