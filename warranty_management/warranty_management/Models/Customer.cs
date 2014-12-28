using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace warranty_management.Models
{
    public class Customer
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Bạn phải điền tên khách hàng")]
        [StringLength(50, ErrorMessage = "{0} phải có ít nhất {2} kí tự", MinimumLength = 2)]
        [DataType(DataType.Text)]
        [Display(Name = "Tên khách hàng")]
        public string CustomerName { get; set; }

        [DataType(DataType.Text)]
        [Display(Name = "Địa chỉ")]
        public string Address { get; set; }

        [DataType(DataType.PhoneNumber)]
        [Display(Name = "Số điện thoại")]
        public string Phone { get; set; }
    }
}