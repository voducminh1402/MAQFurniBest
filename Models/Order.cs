using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace MAQFurni.Models
{
    [Table("Order")]

    public partial class Order
    {
        public Order()
        {
            OrderDetails = new HashSet<OrderDetail>();
        }

        [Key]
        [Column("OrderID")]
        [StringLength(50)]
        [Display(Name ="Order Name")]
        public string OrderId { get; set; }
        [Required]
        [Column("UserID")]
        [StringLength(450)]
        [Display(Name ="User Name")]
        public string UserId { get; set; }
        [Column(TypeName = "decimal(16, 2)")]
        public decimal TotalPrice { get; set; }
        [Column(TypeName = "datetime")]
        [Display(Name ="Create Date")]
        public DateTime CreateDate { get; set; }

        [ForeignKey(nameof(UserId))]
        [InverseProperty("Orders")]
        public virtual User User { get; set; }
        [InverseProperty("Order")]
        public virtual ShippingInfo ShippingInfo { get; set; }
        [InverseProperty(nameof(OrderDetail.Order))]
        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
    }
}
