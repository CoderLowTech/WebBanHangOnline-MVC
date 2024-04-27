using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebBanHangOnline.Models.EF
{
    [Table("tb_Order")]
    public class Order : Abstract
    {
        public Order()
        {
            this.OrderDetails = new HashSet<OrderDetail>();
        }
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        public string Code { get; set; }
        [Required]
        public string CustomerName { get; set; }
        [Required]
        public string CustomerPhone { get; set; }
        [Required]
        public string Address { get; set; }
        [Required]
        public string Email { get; set; }
        public decimal TotalAmount { get; set; }
        public int Quantity { get; set; }
         public int TypePayment { get; set; }

        public ICollection<OrderDetail> OrderDetails { get; set; }
    }
}