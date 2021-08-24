using System;
using MyUtilities;
// using WeatherUtilities = MyUtilities.WeatherUtilities
namespace firstProgram
{
    class CheckComfort
    {
        static void Main(string[] args)
        {
            Console.WriteLine("where should we go next?");
            WeatherUtilities.Report("San Francisco", WeatherUtilities.FahrenheitToCelsius(65), 73);
            WeatherUtilities.Report("Denver",WeatherUtilities.FahrenheitToCelsius(77), 55);
            WeatherUtilities.Report("Bologna", 23, 65);
        }

    }
}
