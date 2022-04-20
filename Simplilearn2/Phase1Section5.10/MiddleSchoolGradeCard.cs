using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phase1Section5._10
{
    public class MiddleSchoolGradeCard : BasicGradeCard
    {
        public int Mathematics { get; set; }
        public int English { get; set; }
        public int SecondLanguage { get; set; }
        public int Geography { get; set; }
        public int History { get; set; }
        public override int GradeTotal { get {return Mathematics + English + SecondLanguage + Geography + History; } }
        public override int GradeAverage { get { return GradeTotal / 5; } }

        public MiddleSchoolGradeCard() { }

        public MiddleSchoolGradeCard(int math, int english, int secondLanguge, int geography, int history)
        {
            Mathematics = math;
            English = english;
            SecondLanguage = secondLanguge;
            Geography = geography;
            History = history;
        }

        public static MiddleSchoolGradeCard operator +(MiddleSchoolGradeCard a, MiddleSchoolGradeCard b)
        {
            return new MiddleSchoolGradeCard(a.Mathematics + b.Mathematics, a.English + b.English, a.SecondLanguage + b.SecondLanguage, a.Geography + b.Geography, a.History + b.History);
        }

        public static MiddleSchoolGradeCard operator *(MiddleSchoolGradeCard a, int mul)
        {
            return new MiddleSchoolGradeCard(a.Mathematics * mul, a.English * mul, a.SecondLanguage * mul, a.Geography * mul, a.History * mul);
        }
        public static MiddleSchoolGradeCard operator *(MiddleSchoolGradeCard a, double mul)
        {
            return new MiddleSchoolGradeCard(a.Mathematics * (int)mul, a.English * (int)mul, a.SecondLanguage * (int)mul, a.Geography * (int)mul, a.History * (int)mul);
        }
    }
}
