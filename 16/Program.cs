using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16
{
    class Program
    {
        static void Main(string[] args)
        {
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());
            char c = ' ';
            string answ = null;
            for (int s1 = start; s1 <= end; s1++)
            {
                c = (char)s1;
                answ = $"{answ} {c}";
            }
            Console.WriteLine(answ);
        }
    }
}
