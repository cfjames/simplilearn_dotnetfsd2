// See https://aka.ms/new-console-template for more information
using Phase1Section5._12;

DoApp();

void DoApp()
{
    Teacher teacher = new Teacher()
    {
        Name = "Mr. Teacher",
        Address = "some address",
        HireDate = DateTime.Today
    };

    Student student = new Student()
    {
        Name = "Student name",
        Address = "some address",
        EnrollDate = DateTime.Today
    };

    OfficeStaff staff = new OfficeStaff()
    {
        Name = "Mr. Staff",
        Address = "some address",
        HireDate = DateTime.Today
    };

    List<IPerson> people = new List<IPerson>();
    people.Add(teacher);
    people.Add(student);
    people.Add(staff);

    foreach (IPerson person in people)
        Console.WriteLine(person.GetInfo() + "\n" + person.GetTypeOfPerson());

    Console.WriteLine(teacher.GetInfo() + "\n" + teacher.GetTypeOfPerson());
    Console.WriteLine(student.GetInfo() + "\n" + student.GetTypeOfPerson());
    Console.WriteLine(staff.GetInfo() + "\n" + staff.GetTypeOfPerson());
}