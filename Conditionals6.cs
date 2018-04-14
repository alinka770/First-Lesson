//Author: Мария Дегтяренко
//Task: Программа, которая спрашивает количество километров и количество минут простоя и считает общую сумму оплаты так:
//до 5 км - 20 грн., кажды следующий км - 3 грн., плюс 1 грн. за минуту простоя. 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conditionals6
{
    class Conditionals6
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Distance (km): ");
                uint km = Convert.ToUInt32(Console.ReadLine());
                Console.Write("Waiting (min): ");
                uint min = Convert.ToUInt32(Console.ReadLine());
                uint sum;
                if (km<=5)
                {
                    sum = 20+min;
                }
                else
                {
                    sum = 20 + (km - 5) * 3 + min;
                }
                Console.WriteLine("Sum: " + sum);
            }

            catch(Exception)
            {
                Console.WriteLine("Input string was not in a correct format.");
            }
            Console.ReadKey();
        }
    }
}
