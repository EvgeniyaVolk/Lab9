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
            int a = 0;
            int b = 0;
            Console.WriteLine("Вас приветствует калькулятор!");
            Console.WriteLine("Введите первое целое число");
            try 
            { 
              int c = Convert.ToInt32(Console.ReadLine());
              a = c;
            }
            catch (FormatException fe)
            {
               Console.WriteLine(fe.Message);
               Console.ReadKey();
                return;
            }       
            Console.WriteLine("Введите второе целое число");
            try
            {
                int d = Convert.ToInt32(Console.ReadLine());
                b = d;
            }
            catch (FormatException fe)
            {
                Console.WriteLine(fe.Message);
                Console.ReadKey();
                return;
            }
                    
                Console.WriteLine("Введите код операции:");
                Console.WriteLine("    1-сложение,");
                Console.WriteLine("    2-вычитание,");
                Console.WriteLine("    3-умножение,");
                Console.WriteLine("    4-частное.");
                Console.Write("Ваш выбор=");
                int n = Convert.ToInt32(Console.ReadLine());

                switch (n)
                {
                    case 1:
                        {
                            int S = a + b;

                            Console.WriteLine("Сумма={0}", S);
                        }
                        break;
                    case 2:
                        {
                            int R = a - b;
                            Console.WriteLine("Разница={0}", R);
                        }
                        break;
                    case 3:
                        {
                            int P = a * b;
                            Console.WriteLine("Произведение={0}", P);
                        }
                        break;
                    case 4:
                        {
                            try
                            {
                                float D = a / b;
                                Console.WriteLine("Частное={0}", D);
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine(ex.Message);
                            }
                        }
                        break;
                    default:
                        {
                            Console.WriteLine("Нет операции с указанным номером");
                            break;
                        }

                }
           


            Console.ReadKey();
            {

            }



        }
    }
}
