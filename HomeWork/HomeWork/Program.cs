using System;
using System.IO;

namespace HomeWork
{
    class Program
    {
        static void Main(string[] args)
        {
          
            int emptyVar;
            int j;

            int sum = 0; // переменные, которые будут хранить 
            int multiple = 1; // результат
            
            string[] arrayOfStrings = null; // массив хранящий строку с числами из текстового файла


            // Считываем текстовой файл состоящий из двух строк
            string path = "C:\\testTask\\TestTask\\HomeWork\\INPUT.txt";
            using (StreamReader sr = new StreamReader(path, System.Text.Encoding.Default))
            {
                string line;
                int count = 0;
                while ((line = sr.ReadLine()) != null)
                {
                    
                    Console.WriteLine(line);
                    count++;
                    
                    if (count == 2)
                    {
                        arrayOfStrings = line.Split(new char[] { });
                    }
                }
            }
            
          
            int[] arrayOfNumbers = new int[arrayOfStrings.Length]; // числовой список в нужном нам формате

         
            for (int i = 0; i < arrayOfStrings.Length; i++)
            {
                try
                {
                    arrayOfNumbers[i] = Convert.ToInt32(arrayOfStrings[i]); // Нам нужны числовые значения из строк
                }
                catch (FormatException)
                {
                    continue;
                }
                
            }
            
            // Находим сумму положительных чисел  
            foreach (int el in arrayOfNumbers)
            {
                if (el > 0)
                {
                    sum += el;
                }
            }

            // Сортируем массив 
            for (int k = 0; k < arrayOfNumbers.Length; k++)
            {
                for (int i = 0; i < arrayOfNumbers.Length; i++)
                {
                    j = i + 1;
                    if (j == arrayOfNumbers.Length) { j = i; }
                    if (arrayOfNumbers[i] > arrayOfNumbers[j])
                    {
                        emptyVar = arrayOfNumbers[i];
                        arrayOfNumbers[i] = arrayOfNumbers[j];
                        arrayOfNumbers[j] = emptyVar;
                    }

                }
            }
           
            // Находим произведение чисел от минимального до максимального значения без учета соответстующих значений
            for (int i = 1; i < arrayOfNumbers.Length-1; i++)
            { 
                multiple *= arrayOfNumbers[i];
            }

            //Делаем запись в файл
            string writePath = "C:\\testTask\\TestTask\\HomeWork\\OUTPUT.txt";
            string writeText = $"{sum} {multiple}";
            File.WriteAllText(writePath,writeText);
           

            Console.ReadLine();
        }
    }
}
