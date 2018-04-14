//Author: Мария Дегтяренко
//Task: С помощью одной строки кода вывести на экран "Хорошо", если пользоваетль ввёл 1, или "Плохо" - если 0.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conditionals4
{
    class Conditionals4
    {
        static void Main(string[] args)
        {
            int input;
            try
            {
                do
            {
                Console.Write("Please, input 0 or 1: ");
                input = Convert.ToInt32(Console.ReadLine());
            }
                
            while (input>1 || input <0);
            Console.Write(input == 1 ? "Хорошо" : "Плохо");
            }
            catch(FormatException exp)
            {
                Console.WriteLine(exp.Message);
            }
            
            Console.ReadKey();

        }
    }
}
