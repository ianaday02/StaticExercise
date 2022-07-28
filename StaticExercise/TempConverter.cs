using System;
namespace StaticExercise
{
    public static class TempConverter
    {
        public static double FahrenheightToCelsius(double fahrenheight)
        {
            return (fahrenheight -32) / 1.8;
        }
        public static double CelsiusToFahrenheight(double celsius)
        {
            return (celsius * 9) / 5 + 32;
        }
    }
}

