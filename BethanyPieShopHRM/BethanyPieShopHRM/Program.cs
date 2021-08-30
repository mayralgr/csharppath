using System;

namespace BethanyPieShopHRM
{
    class Program
    {
        static void Main(string[] args)
        {
            int montlyWage = 1234;
            int months = 12, bonus = 1000;
            bool isActive = true;
            double rating = 99.25;
            double ratePerHour = 12.34;
            int numberOfHoursWorked = 165;
            // montlyWage = true;

            /**
             * Operators
             *   +
             *   =
             *   logical
             *   asigned
             */

            // monthly wage of an employee
            double currentMonthWage = ratePerHour * numberOfHoursWorked + bonus;
            Console.WriteLine(currentMonthWage);

            //
            ratePerHour += 3;

            if (currentMonthWage > 2000)
            {
                Console.WriteLine("Top paid employee");
            }

            int numberOfEmployees = 15;

            numberOfEmployees--;

            Console.ReadLine();

        }
    }
}
