using System;

namespace rus_OOP_3._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введіть рядок");
            string s = Console.ReadLine();
            string[] s1 = s.Split();
            for (int i = 0; i < s1.Length; i += 2)
            {
                Console.Write(s1[i] + " ");
            }



        
        }
    }
}

