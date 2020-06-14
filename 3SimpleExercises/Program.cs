using System;

namespace _3SimpleExercises
{
    class Program

    {
        public static void Main(string[] args)
        {
            double newFahrenheit = TempConverter.CtoF(30);
            double roundedFahrenheit = Math.Round(newFahrenheit, 2);
            Console.WriteLine(roundedFahrenheit);

            double newCelsius = TempConverter.FtoC(75);
            double roundedCelsius = Math.Round(newCelsius, 2);
            Console.WriteLine(roundedCelsius);

            newCelsius = TempConverter.FtoC(105);
            roundedCelsius = Math.Round(newCelsius, 2);
            Console.WriteLine(roundedCelsius);

            newFahrenheit = TempConverter.CtoF(12);
            roundedFahrenheit = Math.Round(newFahrenheit, 2);
            Console.WriteLine(roundedFahrenheit);
        }
    }
}
