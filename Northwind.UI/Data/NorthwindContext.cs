using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Text;

using Northwind.Common;
using Northwind.Common.Model;

namespace Northwind.Logic
{
    public class NorthwindContext : DbContext
    {
        public NorthwindContext() : base("name=Northwind")
        {
            //if (Database.Exists(nameof(Northwind)))
            //{s
            //    //review
            //    Database.SetInitializer(new DropCreateDatabaseAlways<NorthwindContext>());
            //}
        }

        public DbSet<MainUser> Users { get; set; }
        public DbSet<FacilityManager> Managers { get; set; }
        public DbSet<Complain> Complains { get; set; }
    }
}
