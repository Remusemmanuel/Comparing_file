using System;
using System.IO;
using System.Collections.Generic;
using System.Text;
using System.Linq;


namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {

            var files_name = new List<string>(@"Git_1a.txt", @"Git_2a.txt", @"Git_3a.txt");

            void file_comparation(int f1)
            {
                string a = File.ReadAllText(files_name[f1]);
                string b = File.ReadAllText(files_name[f1 + 3]);
                var sex = new List<int>[];

                if (a.Length == b.Length)
                {
                    for(int i = 0; i < a.Length; i++)
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("The file are match");
                    Console.ResetColor();
                }
                else if(a[i]!= b[i])
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("There are different files");
                    Console.ResetColor();
                }
            }
            
            

            Console.WriteLine("Choose the program for comparation you want : 1a and 1b (A) \n2a and 2b (B) \n3a and 3b (C)");
            

            



           




            
        }
    }
}
