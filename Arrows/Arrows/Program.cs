using System;
using System.Collections;
using System.IO;

namespace Arrows
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList quantityOfArrows = new ArrayList();
            
            string subString = null;
            int countOfArrows = 0;


            string text = File.ReadAllText("D:\\Progs\\Arrows\\INPUT.txt");
            
            for (int i = 0; i < text.Length; i++)
            {
               
                for (int j = i; j < i+5; j++)
                {
                    if (i+5>text.Length)
                    {
                        break;
                    }
                    subString += text[j];
                    
                    if (subString == ">>-->" || subString == "<--<<")
                    {
                        countOfArrows++;
                    }
                   
                }
                subString = null;
                

            }

            File.WriteAllText("D:\\Progs\\Arrows\\OUTPUT.txt", countOfArrows.ToString());


            

            Console.ReadLine();
        }
    }
}
