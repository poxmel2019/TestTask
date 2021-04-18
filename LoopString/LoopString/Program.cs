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
            HashSet<char> set = new HashSet<char>();
           

            for (int i = 0; i < text.Length; i++)
            {
                set.Add(text[i]);

            }

            File.WriteAllText("D:\\Progs\\LoopString\\OUTPUT.TXT", set.Count.ToString());


           

            Console.ReadLine();
            
        }
    }
}
