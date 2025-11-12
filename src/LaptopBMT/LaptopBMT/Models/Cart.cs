using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LaptopBMT.Models
{
    public class Cart
    {
        [Key]
        public int CartId { get; set; }
        [ForeignKey("User")]
        public int UserId { get; set; }   // Khóa ngoại

        public User? User { get; set; }    // Điều hướng tới entity User

        public string? UserName { get; set; }
        // ✅ Đánh dấu giỏ hàng đã thanh toán hay chưa
        public bool IsCheckedOut { get; set; } = false;
        public ICollection<CartItem> CartItems { get; set; } = new List<CartItem>();

        public DateTime? CreatedAt { get; set; } = DateTime.Now;
        public DateTime? UpdatedAt { get; set; } = DateTime.Now;
    }
}
