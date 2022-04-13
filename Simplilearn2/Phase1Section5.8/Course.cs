using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phase1Section5._8
{
    internal class Course
    {
        public string Name { get; private set; }
        public CourseTeacher CourseTeacher { get; private set; }
        public List<SubjectTeacher> SubjectTeachers { get; private set; }

        public Course() { }

        public Course(string name, List<SubjectTeacher> subjectTeachers)
        {
            Name = name;

            SubjectTeachers = subjectTeachers != null ? subjectTeachers : new List<SubjectTeacher>();
        }

        public void AddSubjectTeacher(SubjectTeacher subjectTeacher)
        {
            if (subjectTeacher != null)
                SubjectTeachers.Add(subjectTeacher);
        }

        public void SwitchTeacher(CourseTeacher courseTeacher)
        {
            if (!SubjectTeachers.Any(st => st.Name == courseTeacher.Name))
                throw new Exception($"{courseTeacher.Name} is not a vaild teacher for this course.");
            else
                CourseTeacher = courseTeacher;
        }
    }
}
