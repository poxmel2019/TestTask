using System;
using System.IO;
namespace HairyBuisness
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string[] arrayOfStrings = null;
            // Считываем текстовой файл состоящий из двух строк
            string path = "C:\\testTask\\TestTask\\HairyBuisness\\INPUT.txt";
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
            int max = arrayOfNumbers[0];
            
            int unit = 0, luk = -1, sum = 0;
            
            while (unit < arrayOfNumbers.Length)
            {
                for (int z = unit + 1; z < arrayOfNumbers.Length; z++) if (arrayOfNumbers[z] > max)
                    {
                        max = arrayOfNumbers[z]; unit = z;
                    }
                sum += (unit - luk) * arrayOfNumbers[unit];
                luk = unit;
                if (unit < arrayOfNumbers.Length) unit++;
                if (unit < arrayOfNumbers.Length) max = arrayOfNumbers[unit];
            }

            //Console.WriteLine(sum);
            // Выгружаем в файл
            File.WriteAllText("C:\\testTask\\TestTask\\HairyBuisness\\OUTPUT.txt", sum.ToString());
            Console.ReadLine();
            
        }
    }
}
