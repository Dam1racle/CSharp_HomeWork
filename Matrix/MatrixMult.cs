using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// Метод по умножению матриц
/// </summary>
namespace Matrix
{
    class MatrixMult
    {
        public static double[,] Mult(double[,] N, double[,] L)
        {
            
            double[,] resultMult = new double[N.GetLength(0), N.GetLength(1)];
            /// <summary>
            /// Цикл для умножения матриц
            /// </summary>
            for (int line = 0; line < N.GetLength(0); line++)
            {
                for (int col = 0; col < N.GetLength(1); col++)
                {
                    resultMult[line, col] = N[line, col] * L[line, col];

                }
            }
            return resultMult;

        }
    }
}
