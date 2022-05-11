using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentDATA.DataAccess.Models
{
    [Table("Subject", Schema = "courses")]
    internal class Subject
    {
        [Key]

        public int subject_id { get; set; }
        public string subject_code { get; set; }
        public string subject_title { get; set; }
        public string subject_description { get; set; }
        public int course_id { get; set; }
        [ForeignKey("course_id")]

        public  Course course { get; set; }

    }
}
