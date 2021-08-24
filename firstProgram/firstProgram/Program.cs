using System;

namespace firstProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            float result = FahrenheitToCelsius(76);
            Console.WriteLine("Hello World! {0}", result);

        }

        static float FahrenheitToCelsius(float temperatureFahrenheit)
        {
            float temperatureCelsius = (temperatureFahrenheit - 32) / 1.8f;
            return temperatureCelsius;
        }
    }
}
