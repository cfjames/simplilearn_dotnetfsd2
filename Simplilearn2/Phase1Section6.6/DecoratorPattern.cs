
namespace Phase1Section6._6
{
    public interface ITeacher
    {
        public string Display();
    }

    public class Teacher : ITeacher
    {
        public string Subject { get; set; }
        public string Name { get; set; }

        public string Display()
        {
            return $"{Name} is a {Subject} Teacher";
        }
    }

    public class SubsituteTeacher : ITeacher
    {
        public string Name { get; set; }

        public string Display()
        {
            return $"Hi I am {Name}.  Today we are watching a movie.";
        }
    }

    public abstract class LevelTeacher : ITeacher
    {
        protected ITeacher _teacher;
        public LevelTeacher(ITeacher teacher)
        {
            _teacher = teacher;
        }

        public virtual string Display()
        {
            return _teacher.Display();
        }
   
    }

    public class MiddleSchoolTeacher : LevelTeacher
    {
        public MiddleSchoolTeacher(ITeacher teacher) : base(teacher) { }

        public override string Display()
        {
            if (_teacher is Teacher)
            {
                Teacher t = (Teacher)_teacher;
                return $"{t.Name} is a Middle School {t.Subject} Teacher";
            }
            else
                return base.Display();
        }
    }

    public class HighSchoolTeacher : LevelTeacher
    {
        public HighSchoolTeacher(ITeacher teacher) : base(teacher) { }

        public override string Display()
        {
            if (_teacher is Teacher)
            {
                Teacher t = (Teacher)_teacher;
                return $"{t.Name} is a High School {t.Subject} Teacher";
            }
            else
                return base.Display();
        }
    }
}
