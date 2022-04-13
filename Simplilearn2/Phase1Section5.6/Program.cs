// See https://aka.ms/new-console-template for more information
using Phase1Section5._6;

DoApp();

void DoApp()
{
    string[] arrTopics = { "Journalism", "Writing", "Communications" };
    string[] arrTopicShorts = { "jour", "WRIT", "COMM" };


    string[] arrStudents = { "Rahul Gandhi", "Vijay Mallya", "Lady Gaga", "Arun Jaitley", "MS Dhoni", "Kim Kardashian" };
    List<Student> listStudents = new List<Student>();
    List<Subject> listSubjects = new List<Subject>();

    for (int i = 0; i < arrTopics.Length; i++)
    {
        Subject subject = new Subject(arrTopics[i], arrTopicShorts[i]);
        listSubjects.Add(subject);
    }

    for (int i = 0; i < arrStudents.Length; i++)
    {
        Student student = new Student(arrStudents[i], new DateTime(2004, 5, 15), "Some address", "My Guardian", "555-444-3333");
        listStudents.Add(student);
    }

    Teacher classTeacher = new Teacher("Mr.RadheShyam", "Some address", Convert.ToDateTime("2010-09-11 00:00:00"));

    Course class1A = new Course("1A", classTeacher, listStudents, listSubjects);
    class1A.AddStudent(new Student("Bob Villa", new DateTime(2004, 5, 15), "Some address", "My Guardian", "5554443333"));

    CourseList courses = new CourseList();
    courses.Courses = new List<Course> { class1A };
    courses[0] = new Course();
}
