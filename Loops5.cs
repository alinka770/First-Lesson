//Author: Мария Дегтяренко
//Task: Прочитать 5 целых чисел и  посчитать их среднее арифметическое. 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops5
{
    class Loops5
    {
        static void Main(string[] args)
        {
            float sum = 0;
            Console.WriteLine("Please, input 5 integer numbers: ");
            try
            {
                for (int i = 0; i < 5; i++)
                {
                    sum += Convert.ToInt32(Console.ReadLine());
                }
                Console.WriteLine("\nThe mean: " + sum / 5);
            }
            catch (FormatException exp)
            {
                Console.WriteLine(exp.Message);
            }
            Console.ReadKey();
        }
    }
}
