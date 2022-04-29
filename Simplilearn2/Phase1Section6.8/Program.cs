// See https://aka.ms/new-console-template for more information
using Phase1Section6._8;

DoApp();

void DoApp()

{
    Console.WriteLine("Observer Pattern=========");
    Tesla tesla = new Tesla("tesla", 190.00M);
    TeslaStockWatcher w1 = new TeslaStockWatcher("person 1", tesla);
    tesla.AddWatcher(w1);
    tesla.AddWatcher(new TeslaStockWatcher("person 2", tesla));
    tesla.AddWatcher(new TeslaStockWatcher("person 3", tesla));

    tesla.Price = 210.14M;
    tesla.Price = 210.14M;

    tesla.RemoveWatcher(w1);
    tesla.Price = 190.00M;

    Console.WriteLine();
    Console.WriteLine("Template Method Pattern=========");
    TransportTemplate car1 = new Car();
    Console.WriteLine(car1.Travel());

    TransportTemplate plane1 = new Plane();
    Console.WriteLine(plane1.Travel());

    Console.WriteLine();
    Console.WriteLine("Strategy Pattern=========");
    CalculateContext calc1 = new CalculateContext(new Addition());
    Console.WriteLine("Using Addition: " + calc1.Double(90));
    calc1.SetDouble(new Multiply());
    Console.WriteLine("Using Multiplication: " + calc1.Double(90));
}