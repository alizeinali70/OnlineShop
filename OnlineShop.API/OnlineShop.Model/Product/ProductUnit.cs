using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShop.Domain.Entities.ProductEntity
{
    [Table("T_Product")]
    public class ProductUnit
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name = "ردیف")]
        public int ID { get; set; }
        [Display(Name = "نام محصول")]
        public required string Name { get; set; }
        [Display(Name = "تعداد")]
        public required int Count { get; set; }
        [Display(Name = "حداکثر فروش")]
        public int Max_Sell { get; set; }
        [Display(Name = "قیمت یک نفره")]
        public decimal Price1 { get; set; }
        [Display(Name = "مبلغ تخفیف")]
        public decimal? Discount_Price1 { get; set; }
        [Display(Name = "قیمت دونفره")]
        public decimal Price2 { get; set; }
        [Display(Name = "مبلغ تخفیف")]
        public decimal? Discount_Price2 { get; set; }
        [Display(Name = "قیمت کاور یک نفره")]
        public decimal Cover_Price1 { get; set; }
        [Display(Name = "قیمت کاور دو نفره")]
        public decimal Cover_Price2 { get; set; }
        [Display(Name = "یک نفره")]
        public bool Single { get; set; }
        [Display(Name = "دو نفره")]
        public bool Double { get; set; }
        [Display(Name = "تاریخ ثبت")]
        public DateTime Save_Date { get; set; }
        [Display(Name = "ارسال فوری")]
        public bool Send_Fast { get; set; }
        [Display(Name = "قابل فروش")]
        public bool Sell_State { get; set; }
        [Display(Name = "نمایش محصول")]
        public bool Is_Active { get; set; }
        [Display(Name = "فروش ویژه")]
        public bool Special_Offer { get; set; }
        [Display(Name = "عکس1")]
        public string? Image1 { get; set; }
        [Display(Name = "عکس2")]
        public string? Image2 { get; set; }
        [Display(Name = "عکس3")]
        public string? Image3 { get; set; }
        [Display(Name = "کد گارانتی")]
        public string? Garanty_Code { get; set; }
        [Display(Name = "تاریخ شروع گارانتی")]
        public DateTime? Garanty_Start_Date { get; set; }
        [Display(Name = "سئو")]
        public string? Seo { get; set; }
        [Display(Name = "تاریخ آخرین ویرایش")]
        public DateTime LastModifiedDate { get; set; }

        [Display(Name = "تعداد بازدید")]
        public int ViewCount { get; set; } = 0;
        public ICollection<ProductImage> Images { get; set; } = new HashSet<ProductImage>();

        [Display(Name = "مدل")]
        public int ModelId { get; set; }
        [ForeignKey(nameof(ModelId))]
        public virtual ProductModel? ProductsModel { get; set; }
        [Display(Name = "دسته بندی")]
        public int CategoryId { get; set; }
        [ForeignKey(nameof(CategoryId))]
        public virtual ProductCategory? ProductsCategory { get; set; }
    }
}
