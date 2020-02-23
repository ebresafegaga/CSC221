using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Northwind.Common.Model
{
    public class MainUser : User
    {
        [Key]
        public int MainUserID { get; set; }
        public virtual ICollection<Complain> Complains { get; set; }
    }
}
