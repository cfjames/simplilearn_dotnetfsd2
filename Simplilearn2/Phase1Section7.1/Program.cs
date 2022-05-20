// See https://aka.ms/new-console-template for more information
using Newtonsoft.Json.Linq;
using Phase1Section7._9JRH;

DoApp();

void DoApp()
{
    //[{some jason object}]
    JArray array = new JArray();
    JValue text = new JValue("Manual text");
    JValue date = new JValue(new DateTime(2022, 5, 23));

    array.Add(text);
    array.Add(date);

    string json = array.ToString();
    Console.WriteLine(json);

    MyPackage myPck = new MyPackage();
    myPck.DisplayText("Hello Class");
    myPck.DisplayCurrentJsonDate();
}