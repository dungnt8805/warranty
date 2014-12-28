using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace warranty_management.Models
{
    public class Order
    {
        public int Id { get; set; }


        public int CustomerId { get; set; }

        public string Status { get; set; }
        public DateTime OrderDate { get; set; }

        public virtual Customer Customer { get; set; }

        public virtual List<OrderDetail> OrderDetails { get; set; } 
    }
}