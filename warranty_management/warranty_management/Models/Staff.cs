using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace warranty_management.Models
{
    public class Staff
    {
        public virtual int Id { get; set; }
        public virtual string StaffName { get; set; }
        public virtual string UserName { get; set; }
        public virtual string Password { get; set; }
        public virtual string Department { get; set; }
    }
}