using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Phase1Section5._6
{
    public class Student
    {
        public const string NorthAmericanPhonePattern = @"^(\+?(?<NatCode>1)\s*[-\/\.]?)?(\((?<AreaCode>\d{3})\)|(?<AreaCode>\d{3}))\s*[-\/\.]?\s*(?<Number1>\d{3})\s*[-\/\.]?\s*(?<Number2>\d{4})\s*(([xX]|[eE][xX][tT])\.?\s*(?<Ext>\d+))*$";

        private string _contactNumber;

        public string Name { get; private set; }
        public DateTime DateOfBirth { get; private set; }
        public string Address { get; set; }
        public string GuardianName { get; private set; }
        public string ContactNumber
        {
            get { return _contactNumber; }
            set { _contactNumber = FormatPhoneNumber(value); }
        }

        public Student() { }

        public Student(string name, DateTime dateOfBirth, string address, string guardian, string contactNumber)
        {
            Name = name;
            DateOfBirth = dateOfBirth;
            Address = address;
            GuardianName = guardian;
            _contactNumber = FormatPhoneNumber(contactNumber);
        }

        private static string PhoneNumberMatchEvaluator(Match match)
        {
            // Format to north american style phone numbers "0 (000) 000-0000"
            //                                          OR  "(000) 000-0000"
            if (match.Groups["NatCode"].Success)
            {
                return match.Result("${NatCode} (${AreaCode}) ${Number1}-${Number2}");
            }
            else
            {
                return match.Result("(${AreaCode}) ${Number1}-${Number2}");
            }
        }

        private static string FormatPhoneNumber(string phoneNumber)
        {
            var regex = new Regex(NorthAmericanPhonePattern, RegexOptions.IgnoreCase);
            return regex.Replace(phoneNumber, new MatchEvaluator(PhoneNumberMatchEvaluator));
        }
    }
}
