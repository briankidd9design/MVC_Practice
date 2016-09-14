using Cars_MVC.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Cars_MVC.Context
{
    public class CarContext : DbContext
    {
        public DbSet<CarModel> Cars { get; set; }

    }
}