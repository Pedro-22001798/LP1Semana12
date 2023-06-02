using System;

namespace WriteStuff1
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

            Queue<string> stringsQueue = new Queue<string>();       

            while(true)
            {
                string input = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(input))
                {
                    break;
                }

                stringsQueue.Enqueue(input);
            }  

            File.WriteAllLines(filename,stringsQueue);   
        }
    }
}
