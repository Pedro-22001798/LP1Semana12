using System;
using System.IO;

namespace WriteStuff2
{
    public class Program
    {
        private static void Main(string[] args)
        {
            if (args.Length == 0)
            {
                Console.WriteLine("Please write a file's name to search.");
                return;
            }            
            string filename = args[0];

            StreamWriter sw = new StreamWriter(filename);     

            while(true)
            {
                string input = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(input))
                {
                    sw.Close();
                    break;
                }

                sw.WriteLine(input);
            }  
   
        }
    }
}
