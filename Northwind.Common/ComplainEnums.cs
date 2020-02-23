using System;
using System.Collections.Generic;
using System.Text;

namespace Northwind.Common
{
    public enum ComplainType
    {
        Electrical, 
        Plumbing, 
        Capentry, 
        Tiling, 
        MasonWork, 
        Others
    }

    public enum ComplainStatus
    {
        Pending, 
        Closed
    }
}
