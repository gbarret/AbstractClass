using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractClass
{
    abstract class BaseEmployee
    {
        // This clas contains common info from FullTimeEmployee and ContactEmployee classes ...
        // This class can be Defined either as a Concret or Abstract Class
        // Abstract classe CAN NOT be instatiated ...
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string GetFullName()
        {
            return this.FirstName + " " + this.LastName;
        }

        // This is an Abstract Method thta forces any class inheriting from this ne to define this method,
        // otherwise a compilation error will show up ...
        public abstract int GetMonthlySalary();
 
    }
}
