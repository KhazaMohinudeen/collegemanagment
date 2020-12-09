using collegemanagment.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace collegemanagment
{
    public class ORMclass : DbContext
    {
        public ORMclass()
          : base("name=Collgemanagment")
        {
        }
        public DbSet<studentmodel> Studentmanagement { get; set; }
   
    }
}