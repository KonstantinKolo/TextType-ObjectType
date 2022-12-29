using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10
{
    class Program
    {
        static void Main(string[] args)
        {
            byte n = byte.Parse(Console.ReadLine());
            char word;
            string answ = null;
            if (n >= 1 && n <= 20)
            {
                for (sbyte s1 = 0; s1 < n; s1++)
                {
                    word = char.Parse(Console.ReadLine());
                    answ = $"{answ}{word}";
                }
            }
            Console.WriteLine(answ);
        }
    }
}
