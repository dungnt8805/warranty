using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace warranty_management.Models
{
    public class Specie
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Bạn phải nhập tên chủng loại")]
        [StringLength(50, ErrorMessage = "{0} phải có ít nhất {2} kí tự", MinimumLength = 2)]
        [DataType(DataType.Text)]
        [Display(Name = "Tên chủng loại")]
        public string Name { get; set; }

    }
}