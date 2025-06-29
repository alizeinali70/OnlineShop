using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Product
{
    [Table("T_ProductType")]
    public class ProductType
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name = "ردیف")]
        public int ID { get; set; }
        [Display(Name = "نوع محصول")]
        public string Name { get; set; }
        [Display(Name = "توضیحات")]
        public string? Description_Type { get; set; }
        public ICollection<ProductUnit> products { get; set; } = new HashSet<ProductUnit>();
        [Display(Name = "فعال / غیرفعال")]
        public bool Is_Active { get; set; }
    }
}
