using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShop.Domain.Entities.User
{
    [Table("T_Role")]
    public class Role
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name = "ردیف")]
        public int ID { get; set; }
        [Display(Name = "سطح دسترسی")]
        public required string Name { get; set; }
        public ICollection<SpecialMember> SpecialMembers { get; set; } = new HashSet<SpecialMember>();
    }
}

