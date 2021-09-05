using System;
namespace BethanyPieShop
{
    public class Employee
    {
        private string firstName;
        private string lastName;
        private string email;

        private int numberOfHoursWorked;
        private double wage;
        private double hourlyRate;
        private DateTime birthDay;
        private EmployeeType employeeType;
        private double rate;

        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public string Email { get => email; set => email = value; }
        public int NumberOfHoursWorked { get => numberOfHoursWorked; set => numberOfHoursWorked = value; }
        public double Wage {
            get => wage;
            set {
                if (value < 0)
                {
                    wage = 0;
                } else
                {
                    wage = value;
                }
            }
        }
        public double HourlyRate { get => hourlyRate; set => hourlyRate = value; }
        public DateTime BirthDay { get => birthDay; set => birthDay = value; }
        public EmployeeType EmployeeType { get => employeeType; set => employeeType = value; }

        public Employee(string first, string last, string em, DateTime bd, EmployeeType empType, double rate)
        {
            FirstName = first;
            LastName = last;
            Email = em;
            BirthDay = bd;
            EmployeeType = empType;
            HourlyRate = rate;
        }
        public Employee(string first, string last, string em, DateTime bd, EmployeeType empType): this(first,last, em,bd,empType,0)
        { }

        public Employee(string first, string last, double rate)
        {
            FirstName = first;
            LastName = last;
            HourlyRate = rate;
        }

        public void PerformWork()
        {
            NumberOfHoursWorked++;
            Console.WriteLine($"{FirstName} {LastName} is now working");
        }

        public int PerformWork(int hours)
        {
            NumberOfHoursWorked += hours;
            return NumberOfHoursWorked;
        }

        public void StopWorking()
        {
            NumberOfHoursWorked++;
            Console.WriteLine($"{FirstName} {LastName} has stopped working");
        }

        public double ReceiveWage()
        {
            Wage = NumberOfHoursWorked * HourlyRate;
            Console.WriteLine($"The wage for {NumberOfHoursWorked} hours of work is {Wage}.");
            NumberOfHoursWorked = 0;

            return Wage;

        }

        public double ReceiveWage(out int hoursWorked)
        {
            Wage = NumberOfHoursWorked * HourlyRate;

            Console.WriteLine($"The wage for {NumberOfHoursWorked} hours of work is {Wage}.");

            NumberOfHoursWorked = 0;
            hoursWorked = NumberOfHoursWorked;

            return Wage;
        }

        public void DisplayEmployeeDetails() => Console.WriteLine($"\nFirst name: {FirstName}\nLast name: {LastName}\nEmail: {Email}\nBirthday: {BirthDay.ToShortDateString()}\nEmployee type: {EmployeeType}\n");
    }
}
