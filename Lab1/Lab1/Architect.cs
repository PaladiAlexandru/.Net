using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    class Architect: Employee
    {
        public Architect(String FirstName, String LastName, DateTime StartDate, DateTime EndDate):
            base(FirstName, LastName, StartDate, EndDate)
        { }

        public override string Salutation()
        {
            return "Hello architect " + GetFullName();
        }
    }
}
