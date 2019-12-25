using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// Форматирует данные представляющие х и у- координаты местоположения объекта
/// </summary>

namespace Task01_Net_Framework

{
    class Program
    {
        static void Main(string[] args)
        {
            /// <summary>
            /// Ввод данных
            /// </summary>                  
            Console.WriteLine("Input first number");
            var InputFirstNumber = Console.ReadLine();
            /// <summary>
            ///Логическое значение на проверку ввода данных
            /// </summary>
            bool Result1Number = double.TryParse(InputFirstNumber, out double ParseNumber1ToDouble);
            /// <summary>
            /// Ввод второго числа    
            /// </summary>
            Console.WriteLine("Input second number");
            var InputSecondNumber = Console.ReadLine();

            bool Result2Number = double.TryParse(InputSecondNumber, out double ParseNumber2ToDouble);

            if (Result1Number && Result2Number)//Проверяет ввод данных 
            {
                //Отформатированный вид данных после ввода чисел
                Console.WriteLine($"X: {ParseNumber1ToDouble} Y: {ParseNumber2ToDouble}");
            }
            else //Есои ввод был не корректный то выводит строку
            {
                Console.WriteLine("Please write numbers!");
            }
            Console.ReadKey();

        }
    }
}
