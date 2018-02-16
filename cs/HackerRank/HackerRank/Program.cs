using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace HackerRank
{
    // Hacker Rank: Summing N series problem
    public class SummingSeries
    {
        private static readonly ulong DIVISOR = 1000000007;

        public static void CalculateSummingSeries()
        {
            ulong[] inputs = GetUserInput();
            foreach (ulong number in inputs)
            {
                Console.WriteLine(CalculateSeriesModulo(number, DIVISOR));
            }
        }

        private static ulong[] GetUserInput()
        {
            int T = int.Parse(Console.ReadLine());
            ulong[] numbers = new ulong[T];

            for (int i = 0; i < T; i++)
            {
                numbers[i] = ulong.Parse(Console.ReadLine());
            }

            return numbers;

        }

        private static ulong CalculateSeriesModulo(ulong dividend, ulong divisor)
        {
            // The sum of the series reduces to Sn = n^2 by simple calculations.
            // (n^2 % x) is calculated by (((n %x)^2)%x) to avoid overflow of ulong type
            return (((dividend % divisor) * (dividend % divisor)) % divisor);            
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            SummingSeries.CalculateSummingSeries();
            Console.ReadKey();
        }
    }
}
