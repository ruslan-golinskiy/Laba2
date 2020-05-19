using System;

namespace Rus_OOP_Lab_2._3._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            Console.WriteLine("Кількість елементів масиву: ");
            int m = int.Parse(Console.ReadLine());
            float[] a = new float[m];
            for (int i = 0; i < m; i++)
            {
                a[i] = rnd.Next(-100, 100);
                Console.WriteLine("a[{0}] = {1}", i, a[i]);
            }
            float max = Math.Abs(a[0]);
            int n = 0;
            int v = 0;
            float sum = 0;
            for (int i = 0; i < m; i++)
            {
                if (a[i] == 0)
                {
                    v = i;
                }
                if (Math.Abs(a[i]) > Math.Abs(max))
                {
                    max = a[i];
                    n = i;
                }
            }
            for (int i = v; i < m; i++)
            {
                sum += a[i];
            }

            Console.WriteLine("максимальний за модулем елемент масиву:\na[{0}]={1}", n, max);
            Console.WriteLine("сума елементів масиву, розташованих після останнього нульового елемента:\n{0}", sum);
        }
    }
}
