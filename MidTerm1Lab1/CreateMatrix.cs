using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MatrixProgram;
namespace creatematrix
{
    internal class CreateMatrix
    {
        private int[,] matrix;
        public int N { get; set; }
        public int A { get; set; }
        public int B { get; set; }
        public CreateMatrix(int n, int a, int b)
        {
            N = n;
            A = a;
            B = b;
            matrix = new int[N, N]; 
            FillMatrix();           
        }

        private void FillMatrix()
        {
            Random rand = new Random();
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    matrix[i, j] = rand.Next(A,B+1);
                }
            }
        }
        public void ShowMatrix()
        {
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    Console.Write(matrix[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }
        public int GetOddNumbersCount()
        {
            int count = 0;
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    if (matrix[i, j] % 2 != 0){
                        count++;
                    }
                }
            }
            return count;
        }
    }
}
