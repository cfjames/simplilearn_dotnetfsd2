using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phase1Section5._10
{
    public class HighSchoolGradeCard : BasicGradeCard
    {
        public int Mathematics { get; set; }
        public int English { get; set; }
        public int SecondLanguage { get; set; }
        public int Geography { get; set; }
        public int History { get; set; }
        public int Physics { get; set; }
        public int Chemistry { get; set; }
        public int Biology { get; set; }
        public override int GradeTotal { get { 
                return Mathematics + English + SecondLanguage + Geography + History + Physics + Chemistry + Biology; 
            } }
        public override int GradeAverage { get { return GradeTotal / 8; } }

        public HighSchoolGradeCard() { }

        public HighSchoolGradeCard(int math, int english, int secondLanguge, int geography, int history, int physics, int chemistry, int biology)
        {
            Mathematics = math;
            English = english;
            SecondLanguage = secondLanguge;
            Geography = geography;
            History = history;
            Physics = physics;
            Chemistry = chemistry;
            Biology = biology;
        }

        public static HighSchoolGradeCard operator +(HighSchoolGradeCard a, HighSchoolGradeCard b)
        {
            return new HighSchoolGradeCard(a.Mathematics + b.Mathematics, a.English + b.English, 
                a.SecondLanguage + b.SecondLanguage, a.Geography + b.Geography, a.History + b.History,
                a.Physics + b.Physics, a.Chemistry + b.Chemistry, a.Biology + b.Biology);
        }

        public static HighSchoolGradeCard operator *(HighSchoolGradeCard a, int mul)
        {
            return new HighSchoolGradeCard(a.Mathematics * mul, a.English * mul, a.SecondLanguage * mul, 
                a.Geography * mul, a.History * mul, a.Physics * mul, a.Chemistry * mul, a.Biology * mul);
        }
        public static HighSchoolGradeCard operator *(HighSchoolGradeCard a, double mul)
        {
            return new HighSchoolGradeCard(a.Mathematics * (int)mul, a.English * (int)mul, a.SecondLanguage * (int)mul,
                a.Geography * (int)mul, a.History * (int)mul, a.Physics * (int)mul, a.Chemistry * (int)mul, 
                a.Biology * (int)mul);
        }
    }
}
