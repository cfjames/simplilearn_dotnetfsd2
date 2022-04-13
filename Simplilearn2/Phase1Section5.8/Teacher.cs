using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phase1Section5._8
{
    internal class Teacher
    {
        public string Name { get; private set; }
        public string ContactAddress { get; set; }
        public DateTime HireDate { get; private set; }

        public Teacher() { }

        public Teacher(string name, string contactAddress, DateTime hireDate)
        {
            Name = name;
            ContactAddress = contactAddress;
            HireDate = hireDate;
        }
    }
}
