using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    abstract class Employee
    {
        public Employee(String FirstName, String LastName, DateTime StartDate, DateTime EndDate)
        {
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.StartDate = StartDate;
            this.EndDate = EndDate;
        }
        protected String Id { set; get; }
        protected String FirstName { set; get; }

        protected String LastName { set; get; }

        protected DateTime StartDate { set; get; }

        protected DateTime EndDate { set; get; }

        protected Double Salary { set; get; }

        public String GetFullName() { return FirstName + " " + LastName; }
        public Boolean IsActive()
        {
            DateTime CurrentTime = DateTime.UtcNow;
            return StartDate.Ticks < CurrentTime.Ticks && EndDate.Ticks >= CurrentTime.Ticks;
        }
        public abstract String Salutation();
    }
}
