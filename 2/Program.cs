using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2
{
    class Program
    {
        static void Main(string[] args)
        {
            string fname = Console.ReadLine();
            string lname = Console.ReadLine();
            byte age = byte.Parse(Console.ReadLine());
            char gender = char.Parse(Console.ReadLine());
            long id = long.Parse(Console.ReadLine());
            uint emnum = uint.Parse(Console.ReadLine());
            Console.WriteLine($"First name : {fname}");
            Console.WriteLine($"Last name : {lname}");
            Console.WriteLine($"Age : {age}");
            Console.WriteLine($"Gender : {gender}");
            Console.WriteLine($"Personal id : {id}");
            Console.WriteLine($"Unique employee number : {emnum}");
        }
    }
}
