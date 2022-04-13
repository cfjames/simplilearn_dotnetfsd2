using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phase1Section5._6
{
    internal class CourseList
    {
        internal int NumberOfCourses { get { return Courses.Count; } }
        internal List<Course> Courses { get; set; }

        internal Course this[int i]
        {
            get { return Courses[i]; }
            set { Courses[i] = value; }
        }

    }
}
