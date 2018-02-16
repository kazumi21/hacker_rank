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

    class Input
    {
        public ulong N;
        public ulong m;

        public Input(ulong N, ulong m)
        {
            this.N = N;
            this.m = m;
        }
    }

    public class EasySum
    {
        private static Input[] GetUserInput()
        {
            int T = int.Parse(Console.ReadLine());
            Input[] inputs = new Input[T];           

            for (int i=0; i<T; i++)
            {
                string[] line = (Console.ReadLine()).Split(new char[0]);
                inputs[i] = new Input(ulong.Parse(line[0]), ulong.Parse(line[1]));
            }

            return inputs;
        }

        private static ulong CalculateSum(ulong N, ulong m)
        {
            return m*(m-1)/2*(N/m) + (N%m)*(N%m+1)/2;
        }

        public static void CalculateSolution()
        {
            Input[] inputs = GetUserInput();

            foreach(Input inp in inputs)
            {
                Console.WriteLine(CalculateSum(inp.N, inp.m));
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            EasySum.CalculateSolution();

            //SummingSeries.CalculateSummingSeries();
            Console.ReadKey();
        }
    }
}
