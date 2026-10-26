using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using creatematrix;
namespace MatrixProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CreateMatrix myMatrix = new CreateMatrix(4, 1, 20);
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Ստեղծված մատրիցան՝");
            myMatrix.ShowMatrix();
            int odds = myMatrix.GetOddNumbersCount();
            Console.WriteLine($"\nԿենտ թվերի քանակը մատրիցայում՝ {odds}");
            Console.ReadLine();
        }
    }
}