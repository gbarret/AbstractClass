using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractClass
{
    class ContractEmployee: BaseEmployee
    {
        // Some properties were moved to the BaseEmployee class ...
        // public int ID { get; set; }
        // public string FirstName { get; set; }
        // public string LastName { get; set; }

        public int HourlyPay { get; set; }
        public int TotalHoursWorked { get; set; }

        /* This is a common method define in more than one class and has be moved to the abstract class ...
        public string GetFullName()
        {
            return this.FirstName + " " + this.LastName;
        }
        */

        //This method must be defined in this implementation because it is defined 
        // as an abstract method in the base class and also need the keyword override ...
        public override int GetMonthlySalary()
        {
            return this.TotalHoursWorked * this.HourlyPay;
        }
    }
}
