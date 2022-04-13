using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phase1Section5._6
{
    internal class Course
    {
        public string Name { get; private set; }
        public Teacher CourseTeacher { get; private set; }
        public List<Student> Students { get; private set; }
        public List<Subject> Topics { get; private set; }

        public Course()
        {
            Students = new List<Student>();
            Topics = new List<Subject>();
        }

        public Course(string name, Teacher classTeacher, List<Student> students, List<Subject> topics)
        {
            Name = name;
            CourseTeacher = classTeacher;
            Students = students != null ? students : new List<Student>();
            Topics = topics != null ? topics : new List<Subject>();
        }

        public void AddTeacher(Teacher classTeacher)
        {
            if (classTeacher != null)
                CourseTeacher = classTeacher;
        }

        public void AddStudent(Student student)
        {
            if (student != null)
                Students.Add(student);
        }

        public void AddStudents(List<Student> students)
        {
            if (students != null)
                Students.AddRange(students);
        }

        public void RemoveStudent(Student student)
        {
            if (student != null)
                Students.Remove(student);
        }

        public void RemoveStudents(List<Student> students)
        {
            if (students != null)
                Students = Students.Except(students).ToList();
        }

        public void AddTopic(Subject topic)
        {
            if (topic != null)
                Topics.Add(topic);
        }

        public void AddTopics(List<Subject> topics)
        {
            if (topics != null)
                Topics.AddRange(topics);
        }

        public void RemoveTopic(Subject topic)
        {
            if (topic != null)
                Topics.Remove(topic);
        }

        public void RemoveTopics(List<Subject> topics)
        {
            if (topics != null)
                Topics = Topics.Except(topics).ToList();
        }
    }
}
