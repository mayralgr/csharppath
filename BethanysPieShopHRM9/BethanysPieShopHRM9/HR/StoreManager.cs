﻿using System;

namespace BethanysPieShopHRM9.HR
{
    public class StoreManager : Employee
    {
        public StoreManager(int id, string first, string last, string em, DateTime bd, double? rate) : base(id, first, last, em, bd, rate)
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
}