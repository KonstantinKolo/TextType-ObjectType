using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11
{
    class Program
    {
        static void Main(string[] args)
        {
            byte n = byte.Parse(Console.ReadLine());
            char word;
            string answ = null;
            int sum = 0;
            if (n >= 1 && n <= 20)
            {
                for (sbyte s1 = 0; s1 < n; s1++)
                {
                    word = char.Parse(Console.ReadLine());
                    answ = $"{answ}{word}";
                }
            }
            byte[] asciiBytes = Encoding.ASCII.GetBytes(answ);
            for (int s2 = 0; s2 < n; s2++)
            {
                sum = sum + asciiBytes[s2];
            }
            Console.WriteLine($"The sum equals: {sum}");
        }
    }
}
