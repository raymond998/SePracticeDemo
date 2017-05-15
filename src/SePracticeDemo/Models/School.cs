using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SePracticeDemo.Models
{
    public partial class School
    {
        public School()
        {
            Student = new HashSet<Student>();
        }

        public int ObjeId { get; set; }
        [Required(AllowEmptyStrings =false,ErrorMessage ="学院名不能为空！")]
        public string Name { get; set; }
        public string Place { get; set; }
        public string Header { get; set; }

        public virtual ICollection<Student> Student { get; set; }
    }
}
