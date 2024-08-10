using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Database.Models
{
    internal class Student_Registration
    {
        [Key]
        public int Student_Registration_ID { get; set; }

        #region Relationship

        [ForeignKey("Student")]
        public int Student_ID { get; set; }
        public virtual Student Student { get; set; }

        [ForeignKey("Registration")]
        public int Registration_ID { get; set; }
        public virtual Registration Registration { get; set; }

        #endregion Relationship

    }
}
