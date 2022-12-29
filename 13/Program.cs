using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13
{
    class Program
    {
        static void Main(string[] args)
        {
            int key = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());
            string message = null;
            int simbol;
            for (int i = 1; i <= n; i++)
            {
                char letter = char.Parse(Console.ReadLine());
                simbol = letter + key;
                message = message + (char)simbol;
            }
            Console.WriteLine(message);
        }
    }
}
