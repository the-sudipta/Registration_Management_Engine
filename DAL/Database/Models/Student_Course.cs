using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Database.Models
{
    internal class Student_Course
    {

        public int Student_Course_ID { get; set; }



        //#region Relationship

        [ForeignKey("Student")]
        public int Student_ID { get; set; }
        public virtual Student Student { get; set; }

        [ForeignKey("Course")]
        public int Course_ID { get; set; }
        public virtual Course Course { get; set; }

        //#endregion Relationship


    }
}
