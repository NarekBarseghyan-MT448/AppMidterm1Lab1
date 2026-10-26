using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overloading
{
    internal class Program
    {
        public static int ToMultiplicate(int x, int N = 2) => x * N;
        public static double ToMultiplicate(double x, int N = 2) => x * N;
        public static string ToMultiplicate(string x, int N = 2)
        {
            string result = "";
            for (int i = 0; i < N; i++) result += x;
            return result;
        }
        static void Main(string[] args)
        {
            Console.Write(ToMultiplicate(2, 3) + "\n");
            Console.WriteLine(ToMultiplicate(3.2, 4) + "\n");
            Console.WriteLine(ToMultiplicate("A",3));
        }
    }
}
