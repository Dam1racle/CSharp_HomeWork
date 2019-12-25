using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// Создан отдельный класс для взятия значений
/// </summary>
namespace Matrix
{
    class GetValue
    {
        private double[,] fristMatrix = { { 2, 3 }, { 4, 5 } };
        private double[,] secondMatrix = { { 2, 3 }, { 4, 5 } };

        public double[,] GetFirstMatrix()
        {
            return fristMatrix;
        }

        public double[,] GetSecondMatrix()
        {
            return secondMatrix;
        }
    }
}
