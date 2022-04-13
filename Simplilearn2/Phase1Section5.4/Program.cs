// See https://aka.ms/new-console-template for more information
RunApp();

void RunApp()
{
    Student[] students = new Student[3];
    for (int i = 0; i < students.Length; i++)
    { 
        students[i].Name = "Name " + i.ToString();
        students[i].Address = "1 Elm St";
        students[i].RollNumber = i;
        students[i].ClassName = "C1";
        students[i].DateOfBirth = new DateOnly(1992, 9, 10);
    }

    foreach (Student student in students)
    {
        Console.Write(student.Name + ",");
        Console.Write(student.Address + ",");
        Console.Write(student.RollNumber + ",");
        Console.Write(student.ClassName + ",");
        Console.Write(student.DateOfBirth);
        Console.WriteLine("------------------------");
    }

    Student student1 = new Student
    {
        Name = "Name 200",
        Address = "5 Oak St",
        RollNumber = 200,
        ClassName = "C1",
        DateOfBirth = new DateOnly(1992, 9, 10)
    };

    Student student2 = student1;
    Console.WriteLine($"Student1 is the same as Student2: {student1.Equals(student2)}");
    student2.Name = "Name 201";
    Console.WriteLine($"Student1 is the same as Student2: {student1.Equals(student2)}");
}

public struct Student
{
    public string Name { get; set; }
    public string Address { get; set; }
    public int RollNumber { get; set; }
    public string ClassName { get; set; }
    public DateOnly DateOfBirth { get; set; }

}