using System;

namespace HomeWork
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] array = { -7, 5, -1, 3, 9 };
            int[] array = { 3, 14, -9, 4, -5, 1, -12, 4 };
            
            int emptyVar;
            int j;
            int max, min;
            int sum=0;
            int multiple = 1;


            // Находим сумму положительных чисел

            foreach (int el in array)
            {
                if (el > 0)
                {
                    sum += el;
                }
            }

            Console.WriteLine(sum);

            // Сортируем массив 
            for (int k = 0; k < array.Length; k++)
            {
                for (int i = 0; i < array.Length; i++)
                {
                    j = i + 1;
                    if (j == array.Length) { j = i; }
                    if (array[i] > array[j])
                    {
                        emptyVar = array[i];
                        array[i] = array[j];
                        array[j] = emptyVar;
                    }

                }
            }
            
            // Находим произведение чисел от минимального до максимального значения без их учета

            for(int i = 1; i < array.Length-1; i++)
            {
                multiple *= array[i];
            }
            Console.WriteLine(multiple);


            Console.ReadLine();
        }
    }
}
