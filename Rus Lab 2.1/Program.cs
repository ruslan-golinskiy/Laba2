using System;

namespace Rus_Lab_2._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введіть номер знака зодіака:  ");
            int n = int.Parse(Console.ReadLine());
            switch (n)
            {
                case 1:
                    Console.WriteLine("Ви Овен");break;
                case 2:
                    Console.WriteLine("Ви Телець");break;
                case 3:
                    Console.WriteLine("Ви Близнюки"); break;
                case 4:
                    Console.WriteLine("Ви Рак"); break;
                case 5:
                    Console.WriteLine("Ви Лев"); break;
                case 6:
                    Console.WriteLine("Ви Діва"); break;
                case 7:
                    Console.WriteLine("Ви Терези"); break;
                case 8:
                    Console.WriteLine("Ви Скорпіон"); break;
                case 9:
                    Console.WriteLine("Ви Стрілець"); break;
                case 10:
                    Console.WriteLine("Ви Козеріг"); break;
                case 11:
                    Console.WriteLine("Ви Водолій"); break;
                case 12:
                    Console.WriteLine("Ви Риби"); break;
                default:
                    Console.WriteLine("Ви ввели некоректне значення");break;


            }
        }
    }
}
