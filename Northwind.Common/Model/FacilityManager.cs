using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Northwind.Common.Model
{
    public class FacilityManager : User
    {
        [Key]
        public int FacilityManagerID { get; set; }
        public string PhoneNumber { get; set; }
    }
}
