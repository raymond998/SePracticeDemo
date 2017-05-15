using System;
using System.Collections.Generic;

namespace SePracticeDemo.Models
{
    public partial class Student
    {
        public int ObjId { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public int TheSchool { get; set; }

        public virtual School TheSchoolNavigation { get; set; }
    }
}
