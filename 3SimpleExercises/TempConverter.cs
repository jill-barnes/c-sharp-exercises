using System;
using System.Collections.Generic;
using System.Text;

namespace _3SimpleExercises
{
    class TempConverter
    {
        public static double FtoC(int F)
        {
            double Fahrenheit = (F - 32) * (0.55556);
            return Fahrenheit;
        }

        public static double CtoF(int C)
        {
            double Celsius = (C * 1.8) + 32;
            return Celsius;
        }

    }
}

