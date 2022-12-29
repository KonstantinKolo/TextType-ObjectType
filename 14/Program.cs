using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14
{
    class Program
    {
        static void Main(string[] args)
        {
            int century = int.Parse(Console.ReadLine());
            int years = century * 100;
            double days = Math.Round(years * 365.2422);
            double hours = days * 24;
            double minutes = hours * 60;
            double seconds = minutes * 60;
            double milliseconds = seconds * 100;
            double microseconds = milliseconds * 100;
            double nanoseconds = microseconds * 100;
            Console.WriteLine($"{century} centuries = {years} years = {days} days = {hours} hours = {minutes} minutes = {seconds} seconds = {milliseconds} milliseconds = {microseconds} microseconds = {nanoseconds} nanoseconds");
        }
    }
}
