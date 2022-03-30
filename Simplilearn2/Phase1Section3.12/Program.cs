// See https://aka.ms/new-console-template for more information
using System.IO;

DoApp();

void DoApp()
{
    string dir = Directory.GetCurrentDirectory();
    string fileName = dir + @"\data.txt";
    FileInfo testFile = new FileInfo(fileName);

    //if (File.Exists(fileName))
    //   Console.WriteLine($"{fileName} exists");
    //else
    //    Console.WriteLine($"{fileName} does not exist");
    if (testFile.Exists)
        Console.WriteLine($"{testFile.FullName} exists");
    else
        Console.WriteLine($"{testFile.FullName} does not exist");

    //using (StreamWriter sw = new StreamWriter(fileName))
    using (StreamWriter sw = new StreamWriter(testFile.FullName))
    {
        sw.WriteLine("This is line one");
        sw.WriteLine("This is line two");
        sw.WriteLine("This is line three");
        sw.WriteLine("This is line four");
    }
    Console.WriteLine($"{testFile.FullName} created");
    //Console.WriteLine($"{fileName} created");

    //string[] lines = File.ReadAllLines(fileName);
    string[] lines = File.ReadAllLines(testFile.FullName);
    foreach (string line in lines)
        Console.WriteLine(line);

    //string fileText = File.ReadAllText(fileName);
    string fileText = File.ReadAllText(testFile.FullName);
    Console.WriteLine(fileText);

    testFile.Delete();
    //File.Delete(fileName);
    Console.WriteLine($"{testFile.FullName} deleted");
    //Console.WriteLine($"{fileName} deleted");
}
