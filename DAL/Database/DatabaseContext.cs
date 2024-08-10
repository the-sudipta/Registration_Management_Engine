using DAL.Database.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Database
{
    internal class DatabaseContext : DbContext
    {
        DbSet<Registration> Registrations { get; set; }
        DbSet<Student> Students { get; set; }
        DbSet<Student_Course> Student_Courses { get; set; }
        DbSet<Student_Registration> Student_Registrations { get; set; }
        DbSet<Course> Courses { get; set; }

    }
}
