using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5
{
    class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();
            double value = double.Parse(Console.ReadLine());
            double otg = 0;
            switch (type)
            {
                case "miles":
                    otg = value * 1.6;
                    Console.WriteLine($"{value} miles = {otg:F2} kilometers");
                    break;
                case "inches":
                    otg = value * 2.54;
                    Console.WriteLine($"{value} inches = {otg:F2} centimeters");
                    break;
                case "feet":
                    otg = value * 30;
                    Console.WriteLine($"{value} feet = {otg:F2} centimeters");
                    break;
                case "yards":
                    otg = value * 0.91;
                    Console.WriteLine($"{value} yards = {otg:F2} meters");
                    break;
                case "gallons":
                    otg = value * 3.8;
                    Console.WriteLine($"{value} gallons = {otg:F2} liters");
                    break;
            }
        }
    }
}
