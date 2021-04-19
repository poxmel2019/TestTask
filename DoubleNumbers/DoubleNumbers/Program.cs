using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;

namespace DoubleNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string text = File.ReadAllText("C:\\testTask\\TestTask\\DoubleNumbers\\INPUT.txt");
            int number = Convert.ToInt32(text);
            
            string res = null; 

            
            int num = 122;
            int n1 = 1;
            int n2;
            
            
            ArrayList arr = new ArrayList();
            HashSet<int> set = new HashSet<int>();
            
            // Разделим число по разрядам и положим эти значения в множество (уникальные значения)
            while (n1 > 0)
            {
                n1 = num % 10;
                n2 = num / 10;
                if (n1 != 0)
                {
                    set.Add(n1);
                }
                
                num = n2;
            }
            
            // Проверка длины множества
            if (set.Count == 2)
            {
                res = "Двоякое";
            }
            else
            {
                res = "Не двоякое";
            }

            Console.WriteLine(res);
            File.WriteAllText("C:\\testTask\\TestTask\\DoubleNumbers\\OUTPUT.txt",res.ToString()); 

            Console.ReadLine();
           
        }
    }
}
