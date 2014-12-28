using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace warranty_management.Models
{
    public class Warranty
    {
        public int Id { get; set; }

        public int CustomerId { get; set; }

        public int OrderDetailsId { get; set; }

        [Display(Name = "Thời gian hẹn trả")]
        public DateTime ReceivedDate { get; set; }

        public DateTime ReturnDate { get; set; }

        public string Status { get; set; }

        [Display(Name = "Nguyên nhân hỏng")]
        public string Reason { get; set; }

        public virtual Customer Customer { get; set; }

        public virtual OrderDetail OrderDetail { get; set; }
    }
}