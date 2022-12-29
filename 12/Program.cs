using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12
{
    class Program
    {
        static void Main(string[] args)
        {
            char simbol =
            char.Parse(Console.ReadLine());
            string type = Console.ReadLine();
            byte n =
            byte.Parse(Console.ReadLine());
            string oddNiz = null;
            string evenNiz = null;
            for (int i = 1; i <= n; i++)
            {
                string word = Console.ReadLine();
                if (i % 2 == 0)
                {
                    evenNiz = evenNiz + word + simbol;
                }
                else
                {
                    oddNiz = oddNiz + word + simbol;
                }
            }
            if (type == "even")
            {
                Console.WriteLine(evenNiz.Remove(evenNiz.LastIndexOf(simbol)));
            }
            else
            {
                Console.WriteLine(oddNiz.Remove(oddNiz.LastIndexOf(simbol)));
            }
        }
    }
}
