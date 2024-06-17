using Microsoft.EntityFrameworkCore;
using Singleton.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    class DBContext : DbContext // DbContext overriden
    {
        // Product entites can be accessed by this context

        public virtual DbSet<Class1> classes { get; set; }
        public virtual DbSet<Class2> classes2 { get; set; }
        // OnConfiguring is a hook that executes while the context configures itself
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // I add a connection to a database instance while the context configures
            optionsBuilder.UseSqlServer(
                @"Server=127.0.0.1;Database=Singleton;user id=sa;pwd=Toto123*;TrustServerCertificate=True;MultipleActiveResultSets=true;Integrated Security=False");
        }
    }
}
