using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Database.Models
{
    internal class Course
    {
        [Key]
        public int Course_ID { get; set; }

        [Required]
        public string Title { get; set; }
    }
}
