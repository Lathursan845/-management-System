using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Management.Models
{
    internal class Course
    {
        public int CourseId { get; set; }
        public string CourseName { get; set; }
        public string CourseDuration { get; set; }
        public string CourseDescription { get; set; }
    }
}
