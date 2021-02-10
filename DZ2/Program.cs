using System;
using System.IO;
namespace DZ2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!:/n");
            using (StreamReader sr = File.OpenText("Staff.csv"))
            {
                string input = null;
                while ((input = sr.ReadLine()) != null)
                {
                    Console.WriteLine(input);
                }
            }
            Console.ReadLine();
        }
    }
            }    
        
