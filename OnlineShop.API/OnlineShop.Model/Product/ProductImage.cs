using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Product
{
    [Table("T_ProductImage")]

    public class ProductImage
    {
        [Key]
        public int Id { get; set; }
        public string? ImageUrl { get; set; }
        public int ProductId { get; set; }
        public ProductUnit? Product { get; set; }
    }
}
