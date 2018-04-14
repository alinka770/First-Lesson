//Author: Мария Дегтяренко
//Task: Программа загадывает число от 1 до 146, пользователь пытается его отгадать с помощью подсказок "Больше" или "Меньше".

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops3
{
    class Loops3
    {
        static void Main(string[] args)
        {
            int unknownNumber = new Random().Next(1, 146);
            Console.Write("I've picked a number!\nYour guess: ");
            try
            {
                int guess = Convert.ToInt32(Console.ReadLine());
                while (guess != unknownNumber)
                {
                    Console.WriteLine(guess > unknownNumber ? "Less" : "Greater");
                    guess = Convert.ToInt32(Console.ReadLine());
                }
                Console.WriteLine("Congratulations! You're right!");
            }
            catch (Exception exp)
            {
                Console.WriteLine(exp.Message);
            }
            
            Console.ReadKey();

        }
    }
}
