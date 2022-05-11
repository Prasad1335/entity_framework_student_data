using Microsoft.EntityFrameworkCore;
using StudentDATA.DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentDATA.DataAccess
{
    internal class SampleStoreContext2 :DbContext
    {
        public DbSet<Course> courses { get; set; }
        public DbSet<Subject> subjects { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Mark> marks { get; set; }
      

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=WAIANGDESK13\MSSQLSERVER01;Initial Catalog=student_management_performance;Integrated Security=True");
        }
    }
}
