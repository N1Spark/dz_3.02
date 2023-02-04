using System;

namespace dz_3._02
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Зад 1
            int[] A = new int[5];
            double[,] B = new double[3, 4];
            Random r = new Random();
            for (int i = 0; i < B.GetLength(0); i++)
                for (int j = 0; j < B.GetLength(1); j++)
                    B[i, j] = r.NextDouble() * 100;
            Console.WriteLine($"Введите {A.Length} чисел");
            for (int i = 0; i < A.Length; i++)
                A[i] = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            Console.Write("Массив А: ");
            for (int i = 0; i < A.Length; i++)
                Console.Write(A[i] + " ");
            Console.WriteLine("Массив B: ");
            for (int i = 0; i < B.GetLength(0); i++)
            {
                for (int j = 0; j < B.GetLength(1); j++)
                    Console.Write("{0:F2} ", B[i, j]);
                Console.WriteLine();
            }
            double min = A[0], max = 0;
            double sum = 0, multi = 1;
            double sum_pA = 0, sum_upB = 0;
            for (int i = 0; i < A.Length; i++)
            {
                if (min > A[i])
                    min = A[i];
                if (max < A[i])
                    max = A[i];
                sum += A[i];
                multi *= A[i];
                if (A[i] % 2 == 0)
                    sum_pA += A[i];
            }
            for (int i = 0; i < B.GetLength(0); i++)
                for (int j = 0; j < B.GetLength(1); j++)
                {
                    if (min > B[i, j])
                        min = B[i, j];
                    if (max < B[i, j])
                        max = B[i, j];
                    sum += B[i, j];
                    multi *= B[i, j];
                    if (j % 2 != 0)
                        sum_upB += B[i, j];
                }
            Console.WriteLine();
            Console.WriteLine("Min = {0:F2}, Max = {1:F2}, Sum = {2:F2}\nMulti = {3:F2}, Sum_pA = {4}, Sum_upB = {5:F2}", min, max, sum, multi, sum_pA, sum_upB);
            #endregion

            #region Зад 2
            int[,] arr2 = new int[5, 5];
            int sum2 = 0;
            int iMin = 0, iMax = 0;
            int jMin = 0, jMax = 0;
            int min2 = arr2[0, 0];
            int max2 = arr2[0, 0];
            bool count = false;
            Console.WriteLine("---------");
            for (int i = 0; i < arr2.GetLength(0); i++)
            {
                for (int j = 0; j < arr2.GetLength(1); j++)
                {
                    arr2[i, j] = r.Next(-100, 100);
                    Console.Write("{0,4}", arr2[i, j]);

                    if (arr2[i, j] < min2)
                    {
                        min2 = arr2[i, j];
                        iMin = i;
                        jMin = j;
                    }
                    if (arr2[i, j] > max2)
                    {
                        max2 = arr2[i, j];
                        iMax = i;
                        jMax = j;
                    }
                }
                Console.WriteLine();
            }
            for (int i = 0; i < arr2.GetLength(0); i++)
            {
                for (int j = 0; j < arr2.GetLength(1); j++)
                {
                    if ((i == iMax && j == jMax) || (i == iMin && j == jMin))
                    {
                        if (count)
                        {
                            count = false;
                            continue;
                        }
                        else
                        {
                            count = true;
                            continue;
                        }
                    }
                    if (count)
                    {
                        sum2 += arr2[i, j];
                    }
                }
            }
            Console.WriteLine("\nMin: {0}", min2);
            Console.WriteLine("Max: {0}", max2);
            Console.WriteLine("Sum: {0}", sum2);
            #endregion

            #region Зад 3
            Console.WriteLine("Введите текст: ");
            string text = Console.ReadLine();
            char[] mass = new char[256];
            Console.WriteLine("Введите значение: ");
            int crypt = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < text.Length; i++)
            {
                mass[i] = text[i];
                mass[i] += Convert.ToChar(crypt);
            }
            Console.Write("Шифрованный вид: ");
            Console.WriteLine(mass);
            for (int i = 0; i < text.Length; i++)
                mass[i] -= Convert.ToChar(crypt);
            Console.Write($"Расшифрованный вид: ");
            Console.WriteLine(mass);
            #endregion

            #region Задача 4
            Console.WriteLine("\nЗадача 4");
            int[,] arr_1 = new int[3, 3];
            int[,] arr_2 = new int[3, 3];
            for (int i = 0; i < arr_1.GetLength(0); i++)
                for (int j = 0; j < arr_1.GetLength(1); j++)
                {
                    arr_1[i, j] = r.Next(1, 20);
                    arr_2[i, j] = r.Next(1, 20);
                }
            Console.WriteLine("Матрица А");
            for (int i = 0; i < arr_1.GetLength(0); i++)
            {
                for (int j = 0; j < arr_1.GetLength(1); j++)
                    Console.Write("{0} ", arr_1[i, j]);
                Console.WriteLine();
            }
            Console.WriteLine("\nМатрица В");
            for (int i = 0; i < arr_2.GetLength(0); i++)
            {
                for (int j = 0; j < arr_2.GetLength(1); j++)
                    Console.Write("{0} ", arr_2[i, j]);
                Console.WriteLine();
            }
            Console.WriteLine("Выберите дейстивие:\n1 - Умножение матрицы на число\n2 - Сложение матриц\n3 - Произведение матриц");
            int type = Convert.ToInt32(Console.ReadLine());
            if (type == 1)
            {
                Console.Write("Введите число: ");
                int c_multi = Convert.ToInt32(Console.ReadLine());
                for (int i = 0; i < arr_1.GetLength(0); i++)
                    for (int j = 0; j < arr_1.GetLength(1); j++)
                        arr_1[i, j] *= c_multi;
                for (int i = 0; i < arr_2.GetLength(0); i++)
                    for (int j = 0; j < arr_2.GetLength(1); j++)
                        arr_2[i, j] *= c_multi;
                Console.WriteLine("Резульатат: ");
                Console.WriteLine("Матрица А");
                for (int i = 0; i < arr_1.GetLength(0); i++)
                {
                    for (int j = 0; j < arr_1.GetLength(1); j++)
                        Console.Write("{0} ", arr_1[i, j]);
                    Console.WriteLine();
                }
                Console.WriteLine("\nМатрица В");
                for (int i = 0; i < arr_2.GetLength(0); i++)
                {
                    for (int j = 0; j < arr_2.GetLength(1); j++)
                        Console.Write("{0} ", arr_2[i, j]);
                    Console.WriteLine();
                }
            }
            else if (type == 2)
            {
                int[,] arr_res = new int[3, 3];
                for (int i = 0; i < arr_1.GetLength(0); i++)
                    for (int j = 0; j < arr_1.GetLength(1); j++)
                        arr_res[i, j] = arr_1[i, j] + arr_2[i, j];
                Console.WriteLine("Резульатат: ");
                for (int i = 0; i < arr_res.GetLength(0); i++)
                {
                    for (int j = 0; j < arr_res.GetLength(1); j++)
                        Console.Write("{0} ", arr_res[i, j]);
                    Console.WriteLine();
                }
            }
            else if (type == 3)
            {
                int[,] arr_res = new int[3, 3];
                for (int i = 0; i < arr_1.GetLength(0); i++)
                    for (int j = 0; j < arr_1.GetLength(1); j++)
                        for (int k = 0; k < arr_1.GetLength(0); k++)
                            arr_res[i, j] += arr_1[i, k] * arr_2[k, j];
                Console.WriteLine("Резульатат: ");
                for (int i = 0; i < arr_res.GetLength(0); i++)
                {
                    for (int j = 0; j < arr_res.GetLength(1); j++)
                        Console.Write("{0} ", arr_res[i, j]);
                    Console.WriteLine();
                }
            }
            #endregion
        }

    }
}
