using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp3
{
    public class ApplicationContext : DbContext
    {
        public DbSet<Student> StudentDB { get; set; }

        public ApplicationContext(DbContextOptions<ApplicationContext> options)
            : base(options)

        {

       
            Database.EnsureCreated();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>().HasKey(x => x.Id);
        }
    }
}
