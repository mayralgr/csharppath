﻿using System;
using System.Collections.Generic;
using System.Text;

namespace BethanysPieShopHRM9.HR
{
    public sealed class Developer : Employee
    {
        public Developer(int id, string first, string last, string em, DateTime bd, double? rate) : base(id, first, last, em, bd, rate)
        {
        }

        /*public override double ReceiveWage()
        {
            double wageBeforeTax = NumberOfHoursWorked * HourlyRate.Value;
            double taxAmount = wageBeforeTax * taxRate;

            Wage = wageBeforeTax - taxAmount;

            Console.WriteLine($"The wage for {NumberOfHoursWorked} hours of work is {Wage}.");
            NumberOfHoursWorked = 0;

            return Wage;
        }*/
    }

    //public class JuniorDeveloper : Developer
    //{
    //    public JuniorDeveloper(string first, string last, string em, DateTime bd, double? rate) : base(first, last, em, bd, rate)
    //    {
    //    }
    //}
}
