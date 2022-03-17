using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace MAQFurni.Models
{
    [Table("Product")]
    public partial class Product
    {
        public Product()
        {
            OrderDetails = new HashSet<OrderDetail>();
        }

        [Key]
        [Column("ProductID")]
        [DisplayName("Product ID")]
        [StringLength(50)]
        public string ProductId { get; set; }
        [Required]
        [StringLength(120)]
        [DisplayName("Product Name")]
        public string ProductName { get; set; }
        [Required]
        [Column(TypeName = "ntext")]
        [DisplayName("Product Image")]
        public string ProductImage { get; set; }
        [Column(TypeName = "decimal(16, 2)")]
        [DisplayName("Product Price")]
        public decimal ProductPrice { get; set; }
        [DisplayName("Product Quantity")]
        public int Quantity { get; set; }
        [Required]
        [Column(TypeName = "ntext")]
        [DisplayName("Discription")]
        public string Description { get; set; }
        [Column("AvailableID")]
        [DisplayName("Available")]
        public int AvailableId { get; set; }
        [Column("CategoryID")]
        [DisplayName("Category")]
        public int CategoryId { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? CreateDate { get; set; }

        [ForeignKey(nameof(AvailableId))]
        [InverseProperty(nameof(ProductAvailable.Products))]
        public virtual ProductAvailable Available { get; set; }
        [ForeignKey(nameof(CategoryId))]
        [InverseProperty("Products")]
        public virtual Category Category { get; set; }
        [InverseProperty(nameof(OrderDetail.Product))]
        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
    }
}
