using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phase1Section5._8
{
    internal class CourseTeacher : Teacher
    {
        public Course AssignedCourse { get; private set; }

        public CourseTeacher() { }

        public CourseTeacher(string name, string contactAddress, DateTime hireDate, Course assignedCourse) : base(name, contactAddress, hireDate)
        {
            AssignedCourse = assignedCourse;
        }

        public CourseTeacher(Teacher teacher, Course assignedCourse) : this(teacher.Name, teacher.ContactAddress, teacher.HireDate, assignedCourse) { }
    }
}
