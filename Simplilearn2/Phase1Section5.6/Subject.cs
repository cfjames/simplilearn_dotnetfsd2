using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phase1Section5._6
{
    public class Subject
    {
        public string Name { get; private set; }
        public string ShortName { get; private set; }

        public Subject() { }

        public Subject(string name, string shortName)
        {
            Name = name;
            ShortName = shortName.ToUpper();
        }
    }
}
