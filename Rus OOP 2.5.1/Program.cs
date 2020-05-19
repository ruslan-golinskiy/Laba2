using System;

namespace Rus_OOP_2._5._1
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Кількість рядків та стовпців: ");
            int n = int.Parse(Console.ReadLine());

           
            float[,] a = new float[n, n];
            float[,] b = new float[n, n];
            for (int i = 0; i < n; i++)
                for (int j = 0; j < n; j++)
                {
                    
                    Console.Write("a[{0}][{1}] = ", i + 1, j + 1);
                    a[i,j]=float.Parse(Console.ReadLine());

                }
            for (int i = 0; i < n; i++)
                for (int j = 0; j < n; j++)
                {
                    
                    Console.Write("b[{0}][{1}] = ", i + 1, j + 1);
                    b[i, j] = float.Parse(Console.ReadLine());

                }
            Console.WriteLine("\n");
            for (int i = 0; i < n; i++)
                for (int j = 0; j < n; j++)
                {
                    for (int k = 0; k < n; k++)
                        for (int c = 0; c < n; c++)
                        {
                            int i1 = i + 1;
                            int j1 = j + 1;
                            int k1 = k + 1;
                            int c1 = c + 1;
                            if (j1 % 2 == 0 && k1 % 2 != 0 && i1 == c1 && (j1 - k1) == 1)


                                a[i, j] = b[k, c];
                        }
                    Console.WriteLine("A[{0}][{1}]={2}\n", i + 1, j + 1, a[i, j]);
                }

        }
    }
}
