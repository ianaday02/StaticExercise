using System;

namespace StaticExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            var celsius = TempConverter.FahrenheightToCelsius(90);
            Console.WriteLine($"celcius {celsius}");

            var fahrenheight = TempConverter.CelsiusToFahrenheight(20);
            Console.WriteLine($"fahrenheight {fahrenheight}");
        }
    }
}

