using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace Northwind.Common.Model
{
    public class Complain
    {
        [Key]
        public int ComplainID { get; set; }
        
        //public Complain()
        //{
        //    //ComplainID = User.GetHashCode() + 
        //    //    Description.Substring(0, 5).GetHashCode();
        //}
        public virtual MainUser User { get; set; }
        public string Description { get; set; }
        public ComplainType Type { get; set; }
        public DateTime Time { get; set; }
        public ComplainStatus Status { get; set; }
        public Location Location { get; set; }
    }
}
