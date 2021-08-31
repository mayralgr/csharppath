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

            // Members
            int intMaxValue = int.MaxValue;
            int intMinValue = int.MinValue;

            char userSelection = 'a';

            char upperUserSelection = char.ToUpper(userSelection);
            bool isDigit = char.IsDigit(userSelection);
            bool isLetter = char.IsLetter(userSelection);

            DateTime hiredDate = new DateTime(2021, 3, 28, 14,30,0);

            Console.WriteLine(hiredDate);

            DateTime exitDate = new DateTime(2021, 12, 11);

            // DateTime invalidDate = new DateTime(2021, 15, 11);
            DateTime currentDate = DateTime.Now;
            bool areWeInDst = currentDate.IsDaylightSavingTime();

            DateTime startHour = DateTime.Now;
            TimeSpan workTime = new TimeSpan(8, 35, 0);
            DateTime endHour = startHour.Add(workTime);

            Console.WriteLine(startHour.ToLongDateString());
            Console.WriteLine(endHour.ToLongDateString());

            long verLongMonth = numberOfHoursWorked;
            double d = 123456789;
            int x = (int)d;
            int intVeryLong = (int)verLongMonth;

            var something = 1234;
            var rating = something;
            Console.ReadLine();

        }
    }
}
