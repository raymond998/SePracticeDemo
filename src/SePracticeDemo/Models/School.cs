using System;
using System.Collections.Generic;

namespace SePracticeDemo.Models
{
    public partial class School
    {
        public School()
        {
            Student = new HashSet<Student>();
        }

        public int ObjeId { get; set; }
        public string Name { get; set; }
        public string Place { get; set; }
        public string Header { get; set; }

        public virtual ICollection<Student> Student { get; set; }
    }
}
