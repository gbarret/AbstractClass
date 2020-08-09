using System;

namespace AbstractClass
{
    class Program
    {
        static void Main(string[] args)
        {
            // Show FullTime Employee Data **************************
            FullTimeEmployee fe = new FullTimeEmployee();
            fe.FirstName = "Peter";
            fe.LastName = "Smith";
            fe.AnnualSalary = 60000;

            Console.WriteLine("Full Time Employee: {0} \nMonthly Salary: {1}", fe.GetFullName(), fe.GetMonthlySalary() );

            // Show Contract Employee Data **************************
            ContractEmployee ce = new ContractEmployee();

            ce.FirstName = "Mary";
            ce.LastName = "Thompson";
            ce.HourlyPay = 40;
            ce.TotalHoursWorked = 160;

            Console.WriteLine("***************************************************************");
            Console.WriteLine("Contract Employee: {0} \nMonthly Salary: {1}", ce.GetFullName(), ce.GetMonthlySalary());

            Console.ReadKey();
        }
    }
}
