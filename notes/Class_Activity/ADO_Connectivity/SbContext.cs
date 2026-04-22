using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO_Connectivity
{
    internal class SbContext: DbContext
    {
        public DbSet<Student> Students { get; set; }
        public DbSet<Courses> Courses { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(LocalDB)\\MSSQLLocalDB;Database=SampleDB;Trusted_Connection=True");

        }
    }
}
