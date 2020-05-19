using System;

namespace Rus_OOP_Lab_2._3._1
{
   
        public class Program
        {
            static public float First(float[] a, int m)
            {
                float max = Math.Abs(a[0]);
                int n = 0;
                for (int i = 0; i < m; i++)
                {
                    if (Math.Abs(a[i]) > Math.Abs(max))
                    {
                        max = a[i];
                        n = i;
                    }
                }

                return max;

            }
            static public float Second(float[] a, int m)
            {
                int v = 0;
                float sum = 0;
                for (int i = 0; i < m; i++)
                {
                    if (a[i] == 0)
                    {
                        v = i;
                    }

                }
                for (int i = v; i < m; i++)
                {
                    sum += a[i];
                }
                return sum;
            }
            static void Main(string[] args)
            {

                Console.WriteLine("Кількість елементів масиву: ");
                int m = int.Parse(Console.ReadLine());
                float[] a = new float[m];
                for (int i = 0; i < m; i++)
                {

                    Console.Write("a[{0}] = ", i);
                    a[i] = float.Parse(Console.ReadLine());
                }
                
                
                

                Console.WriteLine("максимальний за модулем елемент масиву:\n{0}",First(a,m));
                Console.WriteLine("сума елементів масиву, розташованих після останнього нульового елемента:\n{0}", Second(a,m));
            }
        }
}


    
