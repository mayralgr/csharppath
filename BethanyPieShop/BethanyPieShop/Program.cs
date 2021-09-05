using System;

namespace BethanyPieShop
{
    class Program
    {
        static void Main(string[] args)
        {

            Employee bethany = new Employee("Bethany", "Smith", "bethany@snowball.be",
                new DateTime(1979,1,16), EmployeeType.Manager, 25);
            bethany.DisplayEmployeeDetails();
            bethany.PerformWork();
            bethany.PerformWork();
            bethany.PerformWork();
            bethany.PerformWork();
            bethany.PerformWork();
            bethany.ReceiveWage();

            // REFERENCE TYPE
            Employee testEmployee = bethany;
            testEmployee.firstName = "Gill";
            testEmployee.DisplayEmployeeDetails();

            bethany.DisplayEmployeeDetails();
            Console.ReadLine();

        }
    }
}
