// See https://aka.ms/new-console-template for more information
using Phase1Section5._10;

DoApp();

void DoApp()
{
    ElementarySchoolGradeCard elementary = new ElementarySchoolGradeCard(90, 78, 80, 67);
    Console.WriteLine("Total grade Elementary = " + elementary.GradeTotal);

    MiddleSchoolGradeCard middle = new MiddleSchoolGradeCard(90, 78, 80, 87, 76);
    Console.WriteLine("Total grade Middle School = " + middle.GradeTotal);

    HighSchoolGradeCard high = new HighSchoolGradeCard(90, 78, 80, 87, 76, 90, 76, 70);
    Console.WriteLine("Total grade High School = " + high.GradeTotal);

    high.Mathematics = 80;
    Console.WriteLine("Updated total grade High School = " + high.GradeTotal);
    Console.WriteLine("High School grade average = " + high.GradeAverage);

    List<BasicGradeCard> gradeCards = new List<BasicGradeCard> { elementary, middle, high };

    foreach(BasicGradeCard card in gradeCards)
        Console.WriteLine(card.GradeAverage);
}