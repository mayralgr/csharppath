using System;
namespace BethanysPieShopHRM9.HR
{
    public interface IEmployee
    {
        double ReceiveWage();

        void GiveBonus();

        void PerformWork();

        void StopWorking();

        void DisplayEmployeeDetails();

        void GiveCompliment();
    }
}
