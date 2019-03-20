using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodilityFrogJmp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(solution(10, 85, 30).ToString());

            Console.ReadLine();
        }

        public static int solution(int X, int Y, int D)
        {
            int minimalNumber = 0;

            if (X < 1 || X > 1000000000 || Y < 1 || Y > 1000000000 || D < 1 || D > 1000000000 || X >= Y)
                return minimalNumber;

            minimalNumber = ((Y - X) / D);

            if (((Y - X) % D) != 0) minimalNumber++;

            return minimalNumber;
        }
    }
}
