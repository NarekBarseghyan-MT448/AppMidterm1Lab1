using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InOutRef
{
    internal class Program
    {
        public static void A(in int number)
        {
            Console.WriteLine($"Մեթոդ A (in): Թիվը միայն կարդացվում է -> {number}");
        }

        public static void B(out int result)
        {
            result = 100;
            Console.WriteLine($"Մեթոդ B (out): Արժեքը սահմանվեց մեթոդի ներսում -> {result}");
        }

        public static void C(ref int number)
        {
            Console.WriteLine($"Մեթոդ C (ref) սկզբում: Ստացված արժեքը -> {number}");
            number = number * 2; 
            Console.WriteLine($"Մեթոդ C (ref) վերջում: Փոփոխված արժեքը -> {number}");
        }

        public static int SumValues(params int[] numbers)
        {
            int sum = 0;
            foreach (int num in numbers)
            {
                sum += num;
            }
            return sum;
        }

        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            int myInValue = 25;
            A(myInValue); 

            Console.WriteLine(new string('-', 40));

            int myOutValue; 
            B(out myOutValue); 
            Console.WriteLine($"Main-ում B-ից հետո myOutValue = {myOutValue}");

            Console.WriteLine(new string('-', 40));

            int myRefValue = 10;
            Console.WriteLine($"Main-ում C-ից առաջ myRefValue = {myRefValue}");
            C(ref myRefValue); 
            Console.WriteLine($"Main-ում C-ից հետո myRefValue = {myRefValue} (Արժեքը փոխվեց)");

            Console.WriteLine(new string('-', 40));

            int sum1 = SumValues(1, 2, 3); 
            int sum2 = SumValues(5, 10, 15, 20, 25); 
            int sum3 = SumValues(); 

            Console.WriteLine($"SumValues(1, 2, 3) -> {sum1}");
            Console.WriteLine($"SumValues(5, 10, 15, 20, 25) -> {sum2}");
            Console.WriteLine($"SumValues() դատարկ -> {sum3}");

            Console.ReadLine();
        }
    }
}
