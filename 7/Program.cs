using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7
{
    class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();
            int n = int.Parse(Console.ReadLine());
            long number = 0;
            long nearestL = long.MinValue;
            int nearestI = int.MinValue;
            sbyte nearestS = sbyte.MinValue;
            long answ = 0;
            switch (type)
            {
                case "sbyte":
                    for (int s1 = 0; s1 < n; s1++)
                    {
                        number = long.Parse(Console.ReadLine());
                        if (number >= sbyte.MinValue && number <= sbyte.MaxValue)
                        {
                            if(number > nearestS)
                            {
                                nearestS = (sbyte)number;
                                answ = number;
                            }
                        }
                    }
                    break;
                case "int":
                    for (int s1 = 0; s1 < n; s1++)
                    {
                        number = long.Parse(Console.ReadLine());
                        if (number >= int.MinValue && number <= int.MaxValue)
                        {
                            if (number > nearestI)
                            {
                                nearestI = (int)number;
                                answ = number;
                            }
                        }
                    }
                    break;
                case "long":
                    for (int s1 = 0; s1 < n; s1++)
                    {
                        number = long.Parse(Console.ReadLine());
                        if (number >= long.MinValue && number <= long.MaxValue)
                        {
                            if (number > nearestL)
                            {
                                nearestL = number;
                                answ = number;
                            }
                        }
                    }
                    break;
            }
            Console.WriteLine(answ);
        }
    }
}
