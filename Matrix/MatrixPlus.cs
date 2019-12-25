using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// Метод по сложению матриц
/// </summary>

namespace Matrix
{
    class MatrixPlus
    {
        public static double[,] Plus(double[,] N, double[,] L)
        {
            double[,] resultPlus = new double[N.GetLength(0), N.GetLength(1)];
            /// <summary>
            /// Цикл для складывания матриц
            /// </summary>
            for (int line = 0; line < N.GetLength(0); line++)
            {
                for (int col = 0; col < N.GetLength(1); col++)
                {
                    resultPlus[line, col] = N[line, col] + L[line, col];

                }
            }
            return resultPlus;

        }
    }
}
