using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentDATA.DataAccess.Models
{
    [Table("Student", Schema = "students")]
    internal class Student
    {
        [Key]
        public int student_id { get; set; } 
        public string student_name{ get; set; }
        public int student_rollno { get; set; }
        public string student_address { get; set; }
        public int course_id { get; set; }
        [ForeignKey("course_id")]

        public Course course { get; set; }

    }
}
