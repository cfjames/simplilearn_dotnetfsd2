// See https://aka.ms/new-console-template for more information
using Phase1Section6._6;

DoApp();

void DoApp()

{
    Console.WriteLine("Adapter Pattern====");
    string[,] employeesArray = new string[5, 4]
    {
                {"101","John","SE","10000"},
                {"102","Smith","SE","20000"},
                {"103","Dev","SSE","30000"},
                {"104","Pam","SE","40000"},
                {"105","Sara","SSE","50000"}
    };

    ITarget target = new EmployeeAdapter();
    Console.WriteLine("HR system passes employee string array to Adapter\n");
    target.ProcessCompanySalary(employeesArray);

    Console.WriteLine();
    Console.WriteLine("Adapter Pattern Ex2====");
    string replyFromDavid = new John().AskQuestion("how are you?");
    Console.WriteLine("Reply From David [French Speaker can Speak and Understand only French] :  " + replyFromDavid);
    Console.WriteLine();
    string replyFromJohn = new David().AskQuestion("où êtes-vous?");
    Console.WriteLine("Reply From John [English Speaker can Speak and Understand only English] :  " + replyFromJohn);

    Console.WriteLine();
    Console.WriteLine("Bridge Pattern====");
    UniversalLEDRemoteControl remote1 = new UniversalLEDRemoteControl(new SonyLedTv());
    remote1.PressOnButton();
    remote1.SetChannel(101);
    remote1.PressOffButton();

    Console.WriteLine();
    UniversalLEDRemoteControl remote2 = new UniversalLEDRemoteControl(new SamsungLedTv());
    remote2.PressOnButton();
    remote2.SetChannel(202);
    remote2.PressOffButton();

    Console.WriteLine();
    Console.WriteLine("Proxy Pattern====");
    ATM atm = new ATM();
    try
    {
        Console.WriteLine("Current Balance is " + atm.Balance);
    }
    catch (Exception e)
    {
        Console.WriteLine(e.Message);
    }
    string validateResult = null;
    do
    {
        validateResult = atm.ValidateBankCard(123);
        Console.WriteLine(validateResult);
    } while (validateResult == "Please Insert Valid Card" || validateResult == "Invalid Card / Pin combination");

    Console.WriteLine("Current Balance is " + atm.Balance);
    Console.WriteLine(atm.Deposit(100));
    Console.WriteLine(atm.Withdraw(50));

    Console.WriteLine();
    Console.WriteLine("Decorator Pattern====");
    Teacher t1 = new Teacher();
    t1.Name = "Teacher 1";
    t1.Subject = "Geometry";
    Console.WriteLine(t1.Display());
    Teacher t2 = new Teacher()
    {
        Name = "Teacher 2",
        Subject = "Physics"
    };
    Console.WriteLine(t2.Display());
    MiddleSchoolTeacher t1Middle = new MiddleSchoolTeacher(t1);
    Console.WriteLine(t1Middle.Display());
    HighSchoolTeacher t2High = new HighSchoolTeacher(t2);
    Console.WriteLine(t2High.Display());
    LevelTeacher t1Level = t1Middle;
    Console.WriteLine(t1Level.Display());
    SubsituteTeacher st1 = new SubsituteTeacher();
    st1.Name = "Sub 1";
    MiddleSchoolTeacher st1Middle = new MiddleSchoolTeacher(st1);
    Console.WriteLine(st1Middle.Display());

    Console.WriteLine();
    Console.WriteLine("Composite Pattern====");
    //Creating Leaf Objects
    IComponent hardDisk = new Leaf("Hard Disk", 2000);
    IComponent ram = new Leaf("RAM", 3000);
    IComponent cpu = new Leaf("CPU", 2000);
    IComponent mouse = new Leaf("Mouse", 2000);
    IComponent keyboard = new Leaf("Keyboard", 2000);
    //Creating composite objects
    Composite motherBoard = new Composite("MotherBoard");
    Composite cabinet = new Composite("Cabinet");
    Composite peripherals = new Composite("Peripherals");
    Composite computer = new Composite("Computer");
    //Creating tree structure
    //Ading CPU and RAM in Mother board
    motherBoard.AddComponent(cpu);
    motherBoard.AddComponent(ram);
    //Ading mother board and hard disk in Cabinet
    cabinet.AddComponent(motherBoard);
    cabinet.AddComponent(hardDisk);
    //Ading mouse and keyborad in peripherals
    peripherals.AddComponent(mouse);
    peripherals.AddComponent(keyboard);
    //Ading cabinet and peripherals in computer
    computer.AddComponent(cabinet);
    computer.AddComponent(peripherals);
    //To display the Price of Computer
    int computerTotal = computer.DisplayPrice();
    Console.WriteLine("Computer Total: " + computerTotal);
    Console.WriteLine();
    //To display the Price of Keyboard
    keyboard.DisplayPrice();
    Console.WriteLine();
    //To display the Price of Cabinet
    int cabinetTotal = cabinet.DisplayPrice();
    Console.WriteLine("Cabinet Total: " + cabinetTotal);
}