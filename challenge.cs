using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    internal class Challenge
    {
        public static void ShowOutput()
        {
            int fahrenheit = 94;
            decimal celsius = (fahrenheit - 32m) * (5m / 9m);
            Console.WriteLine("The temperature is " + celsius + " Celsius.");
        }
    }
}
