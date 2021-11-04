using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Калькулятор");
            Console.Write("Ведите число Х:");
            int a = 0;
            int b = 0;
            int op=0;
            try
            {
                a = Convert.ToInt32(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("ввдено не верное значение");
            }
            Console.Write("Ведите число Y:");
            try
            {
                b = Convert.ToInt32(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("ввдено не верное значение");
            }
            try
            {
                Console.WriteLine("введите действие");
                Console.WriteLine("1-умножить");
                Console.WriteLine("2-делить");
                Console.WriteLine("3-сложить");
                Console.WriteLine("4-вычесть");
                op = Convert.ToInt32(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Ошибка");
            }
            
            switch (op)
            {
                case 1: 
                        Console.WriteLine(a * b);
                        break;
                case 2:
                        try
                        {
                            Console.WriteLine(a / b);
                        }
                        catch
                        {
                            Console.WriteLine("Ошибка диление на 0");
                        }
                    break;
                case 3: 
                        Console.WriteLine(a + b);
                        break;
                case 4: 
                        Console.WriteLine(a - b); 
                        break;
                default:  
                        Console.WriteLine("неверный выбор");
                        break;
            }
            Console.ReadKey();
        }
    }
}
