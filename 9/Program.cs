using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9
{
    class Program
    {
        static void Main(string[] args)
        {
            sbyte a1;
            int b1;
            var m = int.Parse(Console.ReadLine());
            int sumSbyte = 0;
            long sumInt = 0;
            for (int i = 1; i <= m; i++)
{
                var n = int.Parse(Console.ReadLine());
                if (n >= 0 && n <= sbyte.MaxValue)
{
                    a1 = (sbyte)n;
                    sumSbyte = a1 * 4;
                }
                if (n >= 128 && n <= int.MaxValue)
{
                    b1 = n;
                    sumInt = (long)b1 * 10;
                }
            }
            long totalSum = sumSbyte + sumInt;
            Console.WriteLine(totalSum);
        }
    }
}
