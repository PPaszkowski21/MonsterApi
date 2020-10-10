using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Kck_FirstProject.Models
{
    public class MonstersContext : DbContext
    {
        public MonstersContext() : base("name=DbConnectionString1")
        {

        }

        public DbSet<Monster> Monsters { get; set; }
    }
}