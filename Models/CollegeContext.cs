using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MvcDemo.Models
{
    public class CollegeContext : DbContext
    {
        public CollegeContext()
            :base (@"Data Source=(localdb)\mssqllocaldb;Initial Catalog=msdb;Integrated Security=True")
        {
            Database.SetInitializer<CollegeContext>(null);
        }

        public DbSet<Student> Students { get; set; }
    }
}