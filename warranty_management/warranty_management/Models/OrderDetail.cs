using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace warranty_management.Models
{
    public class OrderDetail
    {
        public int Id { get; set; }
        public int OrderId { get; set; }

        [Display(Name = "Sản phẩm")]
        public int ProductionId { get; set; }
        [Display(Name = "Serial")]
        public string Serial { get; set; }


        public string Status { get; set; }
        public virtual Production Production { get; set; }

        public virtual Order Order { get; set; }
    }
}