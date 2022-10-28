using System;
using System.Linq;

namespace dz4
{
    class Program
    {
        static int A = -50;
        static int B = 50;
        static int n;
        static int a;
        static int b;
        static void Main(string[] args)
        {
            /*
            Console.Write("Введите размерность массива:");
            string R;
            do
            {
                R = Console.ReadLine();
                if (int.TryParse(R, out n))
                {
                    break;
                }
                Console.Write("Введите целое число:");
            } while (true);
            if(n<0)
            {
                Console.WriteLine("Видимо вы случайно поставили знак минуса, поэтому я сделал число положительным!") ;
            }
            int N = Math.Abs(n);
            double[] array = new double[N];
            Random rand = new Random();
            Console.Write("Array[N] =");
            for (int i = 0; i < N; i++)
            {
                array[i] = rand.Next(A,B) + rand.NextDouble();
                Console.Write("{0,7:F2}",array[i]);
            }
            double max = 0;
            int maxIn = 0;
            for (int i = 0; i < N; i++)
            {
                if (Math.Abs(array[i]) > Math.Abs(max))
                {
                    max = array[i];
                    maxIn = i;
                }
            }
            int indpos = 0;
            double sum = 0;
            for (indpos = 0; indpos < N; indpos++)
            {
                if (array[indpos] > 0)
                {
                    break;
                }
            }
            for (int i = indpos + 1; i < n; i++)
            {
                sum += array[i];
            }
            Console.WriteLine("\nMaxIn= {0}", maxIn);
            Console.Write("Sum= ");
            Console.WriteLine("{0,3:F2}", sum);

            Console.Write("Введите интервал a:");
            string K;
            do
            {
                K = Console.ReadLine();
                if (int.TryParse(K, out a))
                {
                    break;
                }
                Console.Write("Введите целое число:");
            } while (true);

            Console.Write("Введите интервал B:");
            string L;
            do
            {
                L = Console.ReadLine();
                if (int.TryParse(L, out b))
                {
                    break;
                }
                Console.Write("Введите целое число:");
            } while (true);

            int count = 0;
            for (int j = 0; j < N; j++)
            {
                if ((array[j] > a) && (array[j] < b))
                {
                     count++;
                }
            }
            double[] array1 = new double[count];
            int p = 0;
            for (int j = 0; j < N; j++)
            {
                if((array[j] > a)&&(array[j] < b))
                {
                    array1[p++] = array[j];
                }
            }
            double[] array2 = new double[N-count];
            int l = 0;
            for (int k = 0; k < N; k++)
            {
                if ((array[k] > A) && (array[k] <= a)) 
                {
                    array2[l++] = array[k];
                }
                else if ((array[k] >= b) && (array[k] < B))
                {
                    array2[l++] = array[k];
                }
            }
            Console.Write("Array[N] = ");
            double[] result = new double[array1.Length + array2.Length];
            array1.CopyTo(result, 0);
            array2.CopyTo(result, array1.Length);
            Console.Write("{0:00}",String.Join("  ",result.Select(x => x.ToString("F2"))));
            */

            string R;
            string K;
            string L;
            int Inach;
            int Jnach;
            int kakoetochislo;
            Console.WriteLine("Задайте размерность двумерного массива:");
            Console.Write("Кол-во строк-");
            do
            {
                R = Console.ReadLine();
                if (int.TryParse(R, out Inach))
                {
                    break;
                }
                Console.Write("Введите целое число:");
            } while (true);
            if (Inach < 0)
            {
                Console.WriteLine("Видимо вы случайно поставили знак минуса, поэтому я сделал число положительным!");
            }
            int I = Math.Abs(Inach);

            Console.Write("Кол-во столбцов-");
            do
            {
                K = Console.ReadLine();
                if (int.TryParse(K, out Jnach))
                {
                    break;
                }
                Console.Write("Введите целое число:");
            } while (true);
            if (Jnach < 0)
            {
                Console.WriteLine("Видимо вы случайно поставили знак минуса, поэтому я сделал число положительным!");
            }
            int J = Math.Abs(Jnach);

            int N = I * J;

            Random random = new Random();
            int[,] array = new int[I, J];
            for (int i = 0; i < I; i++)
            {
                for (int j = 0; j < J; j++)
                {
                    array[i, j] = random.Next(A, B);
                }
            }
            for (int i = 0; i < I; i++)
            {
                for (int j = 0; j < J; j++)
                {
                    Console.Write("{0,3}", array[i, j]);
                }
                Console.WriteLine();
            }
            Console.WriteLine("Массив приведенный к треугольному виду:");
            int[] sum = new int[I];
            double[] srednee = new double[I];
            for (int i = 0; i < I; i++)
            {
                for (int j = i; j < J - i; j++)
                {
                    Console.Write("{0,3}", array[i, j]);
                    sum[i] += array[i, j];
                    srednee[i] = sum[i] / (J - 2 * i);
                }
                Console.WriteLine();
            }
            Console.Write("Введите число, с которым я буду сравнивать строки:");
            do
            {
                L = Console.ReadLine();
                if (int.TryParse(L, out kakoetochislo))
                {
                    break;
                }
                Console.Write("Введите целое число:");
            } while (true);
            int score = 0;
            Console.Write("Кол-во строк удовлетворивших условия:");
            for (int i = 0; i < I; i++)
            {
                if (kakoetochislo > srednee[i])
                {
                    score++;
                }
            }
            Console.Write(score);
        }
    }
}
