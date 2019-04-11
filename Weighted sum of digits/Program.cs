using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Weighted_sum_of_digits
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number of test-cases: ");
            int n = int.Parse(Console.ReadLine());
            int digitalcount;
            int[] wsd = new int[n];
            int[] cases = new int[n];
            //enter data to work with
            for (int i = 0; i < n; i++)
            {
                Console.Write("Enter number for test-case: ");
                cases[i] = int.Parse(Console.ReadLine());
            }
            //main cycle to calculate weighted sum of digits
            for (int i = 0; i < n; i++)
            {
                digitalcount = (int)Math.Log10(cases[i]) + 1;//calculate number of digits in value
                while (digitalcount > 0)
                {
                    wsd[i] += cases[i] % 10 * digitalcount;
                    cases[i] = cases[i] / 10;
                    digitalcount--;
                }
            }
            //represent results on console
            for (int i = 0; i < n; i++)
            {
                Console.Write(wsd[i] + " ");
            }
            Console.ReadKey();
        }
    }
}
