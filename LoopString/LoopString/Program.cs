using System;
using System.IO;
using System.Collections.Generic;

namespace LoopString
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = File.ReadAllText("D:\\Progs\\LoopString\\INPUT.TXT");

            // Максимально возможная длина подстроки будет равно количеству уникальных (неповторяющихся) значений этой строки

            HashSet<char> set = new HashSet<char>(); // Поэтому создадим коллекцию множество
           

            for (int i = 0; i < text.Length; i++)
            {
                set.Add(text[i]); // Добавим туда значения 

            }

            File.WriteAllText("D:\\Progs\\LoopString\\OUTPUT.TXT", set.Count.ToString()); //Запишем в файл длину множества, т.е. результат


           

            Console.ReadLine();
            
        }
    }
}
