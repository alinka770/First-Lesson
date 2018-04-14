using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISD_Initiative_Conditional_number1
{
    class Program
    {
        public static double a, b;
        public static void Delimiter()
        {
            Console.WriteLine();
            Console.WriteLine("*************************************************************************");
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Эта программа сравнивает два числа и выдает большее на экран.");
            Delimiter();
            try
            {
                Console.WriteLine("Ввведите первое число: ");
                a = Convert.ToDouble(Console.ReadLine());
                Delimiter();
                Console.WriteLine("Введите второе число:");
                b = Convert.ToDouble(Console.ReadLine());
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex);
                Console.ReadKey();
                return;        
            }
           
            Delimiter();
            if(a > b)
            {
                Console.WriteLine("Результат: {0}", a);
                
            }
            else if(a< b) Console.WriteLine("Результат: {0}", b);
            else Console.WriteLine("Два числа равны. Ваше число: {0}", a);
            Console.ReadKey();

        }
    }
}
