
using System;

namespace Lab1
{
    class Manager : Employee
    {
        public Manager(String FirstName, String LastName, DateTime StartDate, DateTime EndDate): 
            base(FirstName, LastName, StartDate, EndDate)
        {
            
        }
        public override string Salutation()
        {
            return "Hello manager " + GetFullName(); 
        
        }
    }
}
