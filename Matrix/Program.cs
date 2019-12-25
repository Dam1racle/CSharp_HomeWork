using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// 
/// </summary>
namespace Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            /// <summary>
            /// создан отдельный экземпляр для взятия значения
            /// </summary>
            /// <param name="firstMatrixValue">Возврощает значение первой матрицы</param>
            /// <param name="secondMatrixValue">Возврощает значение второй матрицы</param>
            
            var getValue = new GetValue();
            double[,] firstMatrixValue = getValue.GetFirstMatrix();
            double[,] secondMatrixValue = getValue.GetFirstMatrix();

            double[,] resultPlusMatrix = MatrixPlus.Plus(firstMatrixValue, secondMatrixValue);

            /// <summary>
            /// Цикл созданый для складывания матриц
            /// </summary>

            for (int i = 0; i < resultPlusMatrix.GetLength(0); i++)
            {
                for (int j = 0; j < resultPlusMatrix.GetLength(1); j++)
                {
                    Console.Write(resultPlusMatrix[i, j] + "\t");
                }
                Console.WriteLine("\n");
            }


           
            double[,] resultMultMatrix = MatrixMult.Mult(firstMatrixValue, secondMatrixValue);

            /// <summary>
            /// Цикл выводит результат умножения матриц 
            /// </summary>
           
            for (int i = 0; i < resultMultMatrix.GetLength(0); i++)
            {
                for (int j = 0; j < resultMultMatrix.GetLength(1); j++)
                {
                    Console.Write(resultMultMatrix[i, j] + "\t");
                }
                Console.WriteLine("\n");
            }
            Console.ReadKey();
        }
    }
       

}
    
