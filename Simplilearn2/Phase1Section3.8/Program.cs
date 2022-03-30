// See https://aka.ms/new-console-template for more information
DoApp();

void DoApp()
{
    DateTime now = DateTime.Now;
    Console.WriteLine("Current date and time are: " + now.ToString());
    Console.WriteLine("Default short date string " +
        now.ToShortDateString());
    Console.WriteLine("Default short time string " +
        now.ToShortTimeString());
    Console.WriteLine("Default long date string " +
        now.ToLongDateString());
    Console.WriteLine("Custom Date Strings:");
    Console.WriteLine(now.ToString("d"));
    Console.WriteLine(now.ToString("D"));
    Console.WriteLine(now.ToString("F"));
    Console.WriteLine(now.ToString("y"));
    Console.WriteLine(now.ToString("MM-dd-yyyy"));
    Console.WriteLine(now.ToString("dddd, MMMM d yyyy"));

    Console.WriteLine("Add 5 days to today: " +
        now.AddDays(5).ToShortDateString());
    Console.WriteLine("Subtract 5 days from today: " +
        now.AddDays(-5).ToShortDateString());

    DateTime date1 = new DateTime(2022, 1, 4, 4, 0, 15);
    DateTime date2 = new DateTime(2022, 1, 2, 14, 0, 15);
    TimeSpan time1 = date1 - date2;
    Console.WriteLine(
        $"Timespan between date1 and date2 is {time1.Days} days and {time1.Hours} hours = {time1.TotalHours} total hours");
}