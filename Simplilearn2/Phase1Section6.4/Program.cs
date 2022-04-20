// See https://aka.ms/new-console-template for more information
using Phase1Section6._4;

DoApp();

void DoApp()
{
    Console.WriteLine("Abstract Factory Pattern======");
    Kitchen k = new MyKitchen();
    k.CreateItems();
    //List<KitchenItem> items = k.Items;
    foreach (KitchenItem ki in k.Items)
    {
        Console.WriteLine(ki.Print());
    }

    Console.WriteLine("Singleton Pattern======");
    ThisApplication app1 = ThisApplication.Instance;
    app1.Name = "App1";
    Console.WriteLine(app1.Name);
    ThisApplication app2 = ThisApplication.Instance;
    app1.Name = "App2";
    Console.WriteLine(app2.Name);
    Console.WriteLine(app1.Name + " = " + app2.Name);

    Console.WriteLine("Prototype Pattern======");
    BookingType seat1 = new Booking();
    seat1.Seat = "14b";
    Console.WriteLine(seat1.Seat);
    BookingType seat2 = seat1.Clone();
    Console.WriteLine(seat2.Seat);
    seat2.Seat = "14b-2";
    Console.WriteLine(seat1.Seat + " != " + seat2.Seat);
}