//Author: Мария Дегтяренко
//Task: Вывести название дня недели по его номеру.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conditionals5
{
    class Conditionals5
    {
        static void Main(string[] args)
        {
            Console.Write("Please, input the day number from 1 to 7: ");
            try
            {
                int day = Convert.ToInt32(Console.ReadLine());
                switch (day)
                {
                    case 1:
                        Console.WriteLine("Monday");
                        break;
                    case 2:
                        Console.WriteLine("Tuesday");
                        break;
                    case 3:
                        Console.WriteLine("Wednesday");
                        break;
                    case 4:
                        Console.WriteLine("Thirsday");
                        break;
                    case 5:
                        Console.WriteLine("Friday");
                        break;
                    case 6:
                        Console.WriteLine("Saturday");
                        break;
                    case 7:
                        Console.WriteLine("Sunday");
                        break;
                    default:
                        Console.WriteLine("Sorry, wrong number");
                        break;

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
