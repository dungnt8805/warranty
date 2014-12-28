using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace warranty_management.Models
{
    public class Manufacturer
    {
        public int Id { get; set; }

        public int Status { get; set; }

        [Required(ErrorMessage = "Bạn phải nhập tên nhà sản xuất")]
        [StringLength(50, ErrorMessage = "{0} phải có ít nhất {2} kí tự", MinimumLength = 2)]
        [DataType(DataType.Text)]
        [Display(Name = "Tên nhà sản xuất")]
        public string Name { get; set; }

        //[Required(ErrorMessage = "Bạn phải nhập quốc gia")]
        //[StringLength(50, ErrorMessage = "{0} phải có ít nhất {2} kí tự", MinimumLength = 2)]
        //[DataType(DataType.Text)]
        //[Display(Name = "Quốc gia")]
        //public string Nation { get; set; }
    }
}