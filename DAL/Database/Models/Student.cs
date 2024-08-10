using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Database.Models
{
    internal class Student
    {
        [Key]
        public int Student_ID { get; set; }

        [Required]
        public string Name { get; set; }


        #region Relationship

        //[ForeignKey("Student")]
        //public int Student_ID { get; set; }
        //public virtual Student Student { get; set; }

        public virtual ICollection<Student_Registration> Student_Registrations { get; set; }
        public Student()
        {
            Student_Registrations = new List<Student_Registration>();
        }
        #endregion Relationship
    }
}
