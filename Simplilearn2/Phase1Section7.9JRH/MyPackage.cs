using Newtonsoft.Json.Linq;

namespace Phase1Section7._9JRH
{
    public class MyPackage
    {
        public void DisplayText(string text)
        { 
            Console.WriteLine(text);
        }

        public void DisplayCurrentDate()
        {
            Console.WriteLine(DateTime.Now.ToShortDateString());
        }

        public void DisplayCurrentJsonDate()
        {
            JValue date = new JValue(new DateTime(2022, 5, 23));
            Console.WriteLine(date.ToString());
        }
    }
}