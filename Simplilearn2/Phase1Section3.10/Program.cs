// See https://aka.ms/new-console-template for more information
using System.Text;

DoApp();

void DoApp()
{
    char[] s1 = { 'L', 'e', 't', 't', 'e', 'r', 's' };
    string stringOfChar = new string(s1);

    Console.WriteLine(stringOfChar);
    foreach (char c in stringOfChar)
        Console.Write(c);
    Console.WriteLine();
    Console.WriteLine(stringOfChar[2]);

    string sentence = "This is a sentence";
    Console.WriteLine(sentence);
    foreach (char c in sentence)
        Console.Write(c);
    Console.WriteLine();
    Console.WriteLine(sentence[3]);

    sentence += ", that has addition content";
    Console.WriteLine(sentence);
    Console.WriteLine("The sentence contains the letter h: " +
        sentence.Contains('h'));
    Console.WriteLine(sentence.ToLower());
    Console.WriteLine(sentence.ToUpper());

    string[] words = sentence.Split(" ");

    StringBuilder sb = new StringBuilder();
    foreach (string word in words)
    { 
        sb.Append(word + "; ");
    }
    sb.Length -= 2;
    Console.WriteLine(sb.ToString());
}