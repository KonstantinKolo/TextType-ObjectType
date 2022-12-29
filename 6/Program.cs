using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6
{
    class Program
    {
        static void Main(string[] args)
        {
            double number = double.Parse(Console.ReadLine());
            double checkd = number * 10;
            if ((int)checkd / 10 != number && number >= int.MinValue && number <= int.MaxValue)
            {
                Console.WriteLine("Rainy");
            }
            else if (number >= sbyte.MinValue && number <= sbyte.MaxValue)
            {
                Console.WriteLine("Sunny");
            }
            else if (number >= int.MinValue && number <= int.MaxValue)
            {
                Console.WriteLine("Cloudy");
            }
            else if (number >= long.MinValue && number <= long.MaxValue)
            {
                Console.WriteLine("Windy");
            }
        }
    }
}
