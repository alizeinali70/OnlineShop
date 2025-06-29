using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.User
{
    [Table("T_SpecialMember")]

    public class SpecialMember
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        [Display(Name = "کد نمایندگی")]
        public string Branch_Code { get; set; }
        [Display(Name = "نام فروشگاه")]
        public string Store_Name { get; set; }
        [Display(Name = "مدیر فروشگاه")]
        public string Manager_Name { get; set; }
        [Display(Name = "کدملی")]
        public string Mellicode { get; set; }
        [Display(Name = "استان")]
        public string Provience { get; set; }
        [Display(Name = "شهر")]
        public string City { get; set; }
        [Display(Name = "منطقه")]
        public string Zone { get; set; }
        [Display(Name = "آدرس پستی")]
        public string Address { get; set; }
        [Display(Name = "کد پستی")]
        public string Postal_Code { get; set; }
        [Display(Name = "تلفن ثابت")]
        public string? Telephone { get; set; }
        [Display(Name = "موبایل 1")]
        public string? Mobile1 { get; set; }
        [Display(Name = "موبایل واتساپ")]
        public string Mobile_Whatsup { get; set; }
        [Display(Name = "وضعیت ملک")]
        public string? Property_Status { get; set; }
        [Display(Name = "موقعیت فروشگاه")]
        public string? Store_Location { get; set; }
        [Display(Name = "متراژ ملک")]
        public string? Store_Size { get; set; }
        [Display(Name = "نوع فروشگاه")]
        public string? Store_Type { get; set; }
        [Display(Name = "تاریخ شروع همکاری")]
        public string? Start_Date { get; set; }
        [Display(Name = "مدت فعالیت در صنف")]
        public string? Working_Duration { get; set; }
        [Display(Name = "نحوه فروش")]
        public string? Sell_Type { get; set; }
        [Display(Name = "وضعیت حسابداری")]
        public string? Accounting_Status { get; set; }
        [Display(Name = "تعداد فروشنده")]
        public string? Seller_Count { get; set; }
        [Display(Name = "سایر برند های همکار")]
        public string? Other_Brands { get; set; }
        [Display(Name = "توضیحات ")]
        public string? Details { get; set; }
        [Display(Name = "سطح دسترسی")]
        public int PermissionId { get; set; }
        [ForeignKey("PermissionId")]
        public virtual Role? Permission { get; set; }
        [Display(Name = "وضعیت فعال / غیرفعال کاربر")]
        public bool Is_Active { get; set; }
    }
}
