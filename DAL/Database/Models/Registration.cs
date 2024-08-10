using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Database.Models
{
    internal class Registration
    {
        [Key]
        public int Registration_ID { get; set; }

        [Required]
        public string Status { get; set; }

        [Required]
        public int Semester_ID { get; set; } // 1 = Spring, 2 = Summer, 3 = Fall

        #region Relationship
        //[ForeignKey("Student")]
        //public int Student_ID { get; set; }
        //public virtual Student Student { get; set; }

        public virtual ICollection<Student_Registration> Student_Registrations { get; set; }
        public Registration()
        {
            Student_Registrations = new List<Student_Registration>();
        }

        #endregion Relationship

    }
}
