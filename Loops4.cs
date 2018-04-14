//Author: Мария Дегтяренко
//Task: Вывести все квадраты натуральных чисел, которые (квадраты) меньше заданого. 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops4
{
    class Loops4
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Please, input N: ");
                int N = Convert.ToInt32(Console.ReadLine());
                int counter = 1;
                while (counter * counter < N)
                {
                    Console.WriteLine(counter + "^2 = " + counter * counter);
                    counter++;
                }
            }
            catch(Exception exp)
            {
                Console.WriteLine(exp.Message);
            }
            Console.ReadKey();

        }
    }
}
