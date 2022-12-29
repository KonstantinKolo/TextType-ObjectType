using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int water = 0;
            int[] array = new int[n];
            byte capacity = 255;
            int sum = 0;
            int lasts2 = 0;
            for (int s = 0; s < n; s++) 
            {
                water = int.Parse(Console.ReadLine());
                array[s] = water;
            }
            Array.Sort(array);
            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }
            if (sum > capacity)
            {
                int leftsum = 0;
                if (array[n - 1] + array[0] > capacity)
                {
                    leftsum = array[n - 1];
                }
                else
                {
                    while (leftsum <= capacity)
                    {
                        for (int s2 = 0; s2 < n; s2++)
                        {
                            leftsum = leftsum + array[s2];
                            lasts2 = s2;
                        }
                    }
                    leftsum = leftsum - array[lasts2];
                }
                Console.WriteLine("Insufficient capacity!");
                Console.WriteLine(leftsum);
            }
            else
            {
                Console.WriteLine(sum);
            }
        }
    }
}
