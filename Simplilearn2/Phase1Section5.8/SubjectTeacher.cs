using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phase1Section5._8
{
    internal class SubjectTeacher : Teacher
    {
        public Subject FocusSubject { get; private set; }

        public SubjectTeacher() { }

        public SubjectTeacher(string name, string contactAddress, DateTime hireDate, Subject focusSubject) : base(name, contactAddress, hireDate)
        {
            FocusSubject = focusSubject;
        }

        public SubjectTeacher(Teacher teacher, Subject focusSubject) : this(teacher.Name, teacher.ContactAddress, teacher.HireDate, focusSubject) { }
    }
}
