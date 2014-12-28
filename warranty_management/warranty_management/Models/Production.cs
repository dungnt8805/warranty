using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace warranty_management.Models
{
    [Bind(Exclude = "Id")]
    public class Production
    {
        [ScaffoldColumn(false)]
        public int Id { get; set; }

        [Required(ErrorMessage = "Bạn phải nhập tên sản phẩm")]
        [StringLength(50, ErrorMessage = "{0} phải có ít nhất {2} kí tự", MinimumLength = 2)]
        [DataType(DataType.Text)]
        [Display(Name = "Tên sản phẩm")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Bạn phải chọn nhà sản xuất")]
        [Display(Name = "Tên nhà sản xuất")]
        public int ManufacturerId { get; set; }

        [Required(ErrorMessage = "Bạn phải chọn chủng loại")]
        [Display(Name = "Tên chủng loại")]
        public int SpecieId { get; set; }

        [Required(ErrorMessage = "Bạn phải nhập mô tả sản phẩm")]
        [DataType(DataType.Text)]
        [Display(Name = "Mô tả sản phẩm")]
        public string Description { get; set; }

        [Required(ErrorMessage = "Bạn phải nhập thời gian bảo hành")]
        [Range(1, 3, ErrorMessage = "Thời gian bảo hành phải từ 1 đến 3 năm")]
        [Display(Name = "Thời gian bảo hành (năm)")]
        public int WarrantyTime { get; set; }

        [Display(Name = "Kiểu bảo hành")]
        public string WarrantyType { get; set; }

        public virtual Manufacturer Manufacturer { get; set; }
        public virtual Specie Specie { get; set; }
    }
}