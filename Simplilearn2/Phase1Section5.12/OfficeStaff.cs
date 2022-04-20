using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phase1Section5._12
{
    public class OfficeStaff : IPerson
    {
        public string Name { get; init; }
        public string Address { get; set; }
        public DateTime HireDate { get; init; }
        public string GetInfo()
        {
            return "Name: " + Name + ", Address= " + Address + ", Hire Date = " + HireDate.ToShortDateString();
        }

        public string GetTypeOfPerson()
        {
            return "OfficeStaff";
        }

    }
}
