using System;
using System.Collections;
using System.IO;

namespace Nulls
{
    class Program
    {
        static void Main(string[] args)
        {
            
            // Задаем массив для хранения количества нулей до прерывания
            ArrayList list = new ArrayList();
            

            string str = File.ReadAllText("D:\\Progs\\Nulls\\INPUT.txt");
            Console.WriteLine(str);
            
            // Делаем заглушку 
            str += "1";
            int count = 0;
            
            for (int i = 0; i < str.Length; i++)
            {
               
               // Считаем нули до прерывания 
                if (str[i] == '0')
                {
                    count++;
                }
                else
                {
                    if (count != 0)
                    {
                        list.Add(count);
                    }
                    
                    count = 0;
                    
                }
                
            }
            
           
            // Количества нулей до прерывания записаны в массиве. Выбираем максимальное значение
            int max = 0;
            for (int i = 0; i < list.Count; i++)
            {
                if (Convert.ToInt32(list[i]) > max)
                {
                    max = Convert.ToInt32(list[i]);
                }
            }

            

            File.WriteAllText("D:\\Progs\\Nulls\\OUTPUT.txt", max.ToString());

           
            
        }
    }
}
