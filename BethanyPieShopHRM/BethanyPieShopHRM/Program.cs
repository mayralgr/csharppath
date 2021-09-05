using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace BethanyPieShopHRM
{
    class Program
    {
        static void Main(string[] args)
        {

            // pasing parameter by value or reference
            /**
             * value: a copy is created for the method
             * value in caller stays the same
             * **/
            // By reference
            /***
             * a reference to the value is passed
             * no copy is made
             * changes on the method affect orginal values
             * ref keyword is used
             * 
             * note: before the method with a ref value is call the ref value must be initialized
             * out if a reference
             * 
             * **/
            // UsingValueParameters();
            // UsingRefParameters();
            // UsingOutParameters();
            // UsingParams();
            // UsingOptionalParameters();
            // UsingNamedArguments();
            // UsingExpressionBodiedSyntax();

            /***
             * Module of types
             * */
            // List<string> list = new List<string>();
            UsingEnumerations();

            Console.ReadLine();
        }

        private static void UsingEnumerations()
        {
            EmployeeType employeeType = EmployeeType.Manager;
            StoreType storeType = StoreType.Seating;

            int baseWage = 1000;
            CalculateWage(baseWage, employeeType, storeType);
        }

        private static void CalculateWage(int baseWage, EmployeeType employeeType, StoreType storeType)
        {
            int calculatedWage = 0;
            if (employeeType == EmployeeType.Manager)
            {
                calculatedWage = baseWage * 3;
            } else
            {
                calculatedWage *= 2;
            }

            if (storeType == StoreType.FullPieRestaurant)
            {
                calculatedWage += 500;
            }

            Console.WriteLine($"The calculted wage is {calculatedWage}");
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

        public static int CalculateYearlyWage(int monthlyWage, int numberOfMonthsWorked, int bonus)
        {
            if (monthlyWage < 2000)
            {
                bonus *= 2;
            }
            Console.WriteLine($"The yearly wage is: {monthlyWage * numberOfMonthsWorked + bonus}");
            Console.WriteLine($"The employee got a bonus of {bonus}");
            return monthlyWage * numberOfMonthsWorked + bonus;
        }

        public static double CalculateYearlyWage(double monthlyWage, double numberOfMonthsWorked, double bonus)
        {
            return monthlyWage * numberOfMonthsWorked + bonus;
        }

        public static void UsingValueParameters()
        {
            // TypesAndStrings();
            // int
            int montlyWage = 1234;
            int months = 12;
            int bonus = 300;
            int montlyWage2 = 2000;
            int months2 = 8;
            // int yearlyWage = CalculateYearlyWage(montlyWage, months, bonus);

            // Console.WriteLine($"Yearly wage: {yearlyWage}");
            double montlyWageDouble = 1500.0;
            double monthsDouble = 12;
            double bonusDouble = 1000;
            double yearlyWageWithBonus = CalculateYearlyWage(montlyWage, months, bonus);
            Console.WriteLine($"The yearly wage for employee 1(Bethany):{yearlyWageWithBonus}");

            double yearlyWageWithBonus2 = CalculateYearlyWage(montlyWage2, months2, bonus);
            Console.WriteLine($"The yearly wage for employee 1(Bethany):{yearlyWageWithBonus2}");
        }

        private static void UsingRefParameters()
        {
            int monthlyWage1 = 1234;
            int monthlyWage2 = 2000;
            int months1 = 12;
            int months2 = 8;
            int bonus = 300;

            int yearlyWageForEmployee1ByRef = CalculateYearlyWageByRef(monthlyWage1, months1, ref bonus);
            Console.WriteLine($"Yearly wage for employee 1 (Bethany): {yearlyWageForEmployee1ByRef}");
            Console.WriteLine($"Employee 1 received a bonus of {bonus}");

            int yearlyWageForEmployee2ByRef = CalculateYearlyWageByRef(monthlyWage2, months2, ref bonus);
            Console.WriteLine($"Yearly wage for employee 2 (John): {yearlyWageForEmployee2ByRef}");
            Console.WriteLine($"Employee 2 received a bonus of {bonus}");

        }

        public static int CalculateYearlyWageByRef(int monthlyWage, int numberOfMonthsWorked, ref int bonus)
        {

            if (monthlyWage < 2000)
            {
                bonus *= 2;
                Console.WriteLine("Bonus doubled!! Yay!!");
            }

            Console.WriteLine($"The yearly wage is: {monthlyWage * numberOfMonthsWorked + bonus}");
            return monthlyWage * numberOfMonthsWorked + bonus;
        }

        private static void UsingOutParameters()
        {
            int monthlyWage1 = 1234;
            int months1 = 12;
            int bonus;//notice: no initial value has been set

            int yearlyWageForEmployee1 = CalculateYearlyWageWithOut(monthlyWage1, months1, out bonus);
            Console.WriteLine($"Yearly wage for employee 1 (Bethany): {yearlyWageForEmployee1}");
        }

        public static int CalculateYearlyWageWithOut(int monthlyWage, int numberOfMonthsWorked, out int bonus)
        {
            bonus = new Random().Next(1000);//C# code to generate a random number smaller than 1000
            if (bonus < 1000)
            {
                bonus *= 2;
                Console.WriteLine("Bonus doubled!! Yay!!");
            }

            Console.WriteLine($"The yearly wage is: {monthlyWage * numberOfMonthsWorked + bonus}");
            return monthlyWage * numberOfMonthsWorked + bonus;
        }

        private static void UsingParams()
        {
            /**
             * Just one parameter can have params
             * need to be the last parameter
             **/

            int monthlyWage1 = 1000, monthlyWage2 = 1234, monthlyWage3 = 1500, monthlyWage4 = 2500;

            int average = CalculateAverageWage(monthlyWage1, monthlyWage2, monthlyWage3, monthlyWage4);
            Console.WriteLine($"The average wage is {average}");
        }

        private static int CalculateAverageWage(params int[] wages)
        {
            int total = 0;
            int numberOfWages = wages.Length;

            for (int i = 0; i < numberOfWages; i++)
            {
                total += wages[i];
            }

            return total / numberOfWages;
        }

        private static void UsingOptionalParameters()
        {
            int monthlyWage1 = 1234;
            int months1 = 12;

            int yearlyWageForEmployee1 = CalculateYearlyWageWithOptional(monthlyWage1, months1);
            Console.WriteLine($"Yearly wage for employee 1 (Bethany): {yearlyWageForEmployee1}");
        }
        // optional parameter need to go at the end of the method signature
        public static int CalculateYearlyWageWithOptional(int monthlyWage, int numberOfMonthsWorked, int bonus = 0)
        {

            Console.WriteLine($"The yearly wage is: {monthlyWage * numberOfMonthsWorked + bonus}");
            return monthlyWage * numberOfMonthsWorked + bonus;
        }

        private static void UsingNamedArguments()
        {
            int monthlyWage = 1234;
            int months = 12;
            int bonus = 500;

            int yearlyWageForEmployee1 = CalculateYearlyWageWithNamed(bonus: bonus, numberOfMonthsWorked: months, monthlyWage: monthlyWage);
            Console.WriteLine($"Yearly wage for employee 1 (Bethany): {yearlyWageForEmployee1}");
        }

        public static int CalculateYearlyWageWithNamed(int monthlyWage, int numberOfMonthsWorked, int bonus)
        {

            Console.WriteLine($"The yearly wage is: {monthlyWage * numberOfMonthsWorked + bonus}");
            return monthlyWage * numberOfMonthsWorked + bonus;
        }

        private static void UsingExpressionBodiedSyntax()
        {
            int monthlyWage = 1234;
            int months = 12;
            int bonus = 500;

            int yearlyWageForEmployee1 = CalculateYearlyWageExpressionBodied(monthlyWage, months, bonus);
            Console.WriteLine($"Yearly wage for employee 1 (Bethany): {yearlyWageForEmployee1}");
        }

        public static int CalculateYearlyWageExpressionBodied(int monthlyWage, int numberOfMonthsWorked, int bonus) => monthlyWage * numberOfMonthsWorked + bonus;

    }

    enum EmployeeType
    {
        Sales, // 0
        Manager, // 1
        Research, // 2
        StoreManager // 3
    }

    enum StoreType
    {
        PieCorner = 10,
        Seating = 20,
        FullPieRestaurant = 100,
        Undefined = 99
    }
}
