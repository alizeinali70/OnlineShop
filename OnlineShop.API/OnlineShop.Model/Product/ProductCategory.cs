using Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Product
{
    [Table("T_ProductCategory")]
    public class ProductCategory
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name = "ردیف")]
        public int ID { get; set; }
        [Display(Name = "نام مدل")]
        public required string Name { get; set; }
        public ICollection<ProductUnit> Products { get; set; } = new HashSet<ProductUnit>();
        [Display(Name = "فعال / غیرفعال")]
        public bool Is_Active { get; set; }
    }
}
