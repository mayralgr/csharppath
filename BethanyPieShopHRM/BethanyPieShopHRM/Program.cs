using System;
using System.Globalization;
using System.Text;

namespace BethanyPieShopHRM
{
    class Program
    {
        static void Main(string[] args)
        {
            // TypesAndStrings();
            int montlyWage = 1234;
            int months = 12;
            int yearlyWage = CalculateYearlyWage(montlyWage, months);
            Console.WriteLine($"Yearly wage: {yearlyWage}");
            Console.ReadLine();
        }

        private static void TypesAndStrings()
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

            DateTime hiredDate = new DateTime(2021, 3, 28, 14, 30, 0);

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
            var rate = something;

            // strings are reference but a primitive type
            string fistName = "Bethany";
            string lastName = "Smith";

            System.String fullname = "Bethany Smith";

            string noValueString = null;
            // same as
            string s;

            s = fistName;

            var userName = "Bethany";

            // concatenate strings
            // +
            // string.concat
            // string.Format
            // interpolation with $""

            string fullNameConcat = fistName + "" + lastName;
            string stringConcatFullName = string.Concat(fistName, lastName);
            string empId = fistName.ToLower() + ":" + lastName.Trim().ToLower();
            int longOfString = empId.Length;
            if (fullname.Contains("Beth"))
            {
                Console.WriteLine("it is");
            }
            string substring = fullname.Substring(1, 3);

            Console.WriteLine("Characters 2 to 4 of fullname are " + substring);

            string namingInterpolation = $"{fistName} {lastName}";

            // escaping characters
            // \n new line
            // \t add a tab
            // \\ escape slash

            string displayName = $"Welcome \n{fistName}\t{lastName}";

            Console.WriteLine(displayName);

            string invalidFilePath = "C:\\data\\employeelist.xlsx";

            string stringWithQuote = "Baking the \"best pies\" ever";

            string verbaitin = @"C:\data\employeelist.xlsx";

            // equality tests
            string name1 = "Bethany";
            string name2 = "BETHANY";
            Console.WriteLine("Are both name equal? " + (name1 == name2));
            Console.WriteLine("Are both name equal? " + (name2.Equals("BETHANY")));
            Console.WriteLine("Are both name equal? " + (name1.ToLower() == "bethany"));

            // inmutability of strings
            // String builder
            string name = "Bethany";
            string anotherName = name;

            name += " Smith";

            Console.WriteLine("NAME" + name);
            Console.WriteLine("Another " + anotherName);

            string lowerCase = name.ToLower();

            StringBuilder stringBuilder = new StringBuilder();

            stringBuilder.Append("Las name ");
            stringBuilder.Append(lastName);
            stringBuilder.Append("First name: ");
            stringBuilder.Append(fistName);

            string result = stringBuilder.ToString();
            Console.WriteLine(result);

            Console.WriteLine("Enter wage");
            string wage = Console.ReadLine();
            //int wageValue = int.Parse(wage);
            int wageValue;
            if (int.TryParse(wage, out wageValue))
            {
                Console.WriteLine("Parse success " + wageValue);
            }
            else
            {
                Console.WriteLine("Parsing failed");
            }
            // same with datetime
            string hireDateString = "12/12/2020";
            DateTime hireDate = DateTime.Parse(hireDateString);
            Console.WriteLine("Parsed date: " + hireDate);
            //TryParse also exists for dates

            var cultureInfo = new CultureInfo("nl-BE");
            string birthDateString = "28 Maart 1984";//Dutch, spoken in Belgium
            var birthDate = DateTime.Parse(birthDateString, cultureInfo);
            Console.WriteLine("Birth date: " + birthDate);
        }


        public static int CalculateYearlyWage(int monthlyWage, int numberOfMonthsWorked)
        {
            // Console.WriteLine($"Yearly wage: {monthlyWage * numberOfMonthsWorked}");
            if (numberOfMonthsWorked == 12)
            {
                return monthlyWage * (numberOfMonthsWorked + 1);
            }
            return monthlyWage * numberOfMonthsWorked;
        }
    }
}
