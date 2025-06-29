using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShop.Domain.Entities.Product
{
    [Table("T_ProductCategory")]
    public class ProductCategory
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name = "ردیف")]
        public int ID { get; set; }
        [Display(Name = "نام مدل")]
        public string Name { get; set; }
        public ICollection<Product> Products { get; set; } = new HashSet<Product>();
        [Display(Name = "فعال / غیرفعال")]
        public bool Is_Active { get; set; }
    }
}
