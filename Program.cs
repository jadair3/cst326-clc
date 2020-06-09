using System;
using System.IO.Enumeration;

namespace cst326_clc
{
    class Program
    {
        static void Main(string[] args)
        {
            string filename = "";
            string sort = "";
            string filter = "";

            Console.WriteLine($"parameter count = {args.Length}");

            for (int i = 0; i < args.Length; i++)
            {
                Console.WriteLine($"Arg[{i}] = [{args[i]}]");

                if (args[i] == "-f")
                {
                    filename = args[i + 1];
                }
                else if (args[i] == "-sa")
                {
                    sort = "a-z";
                }
                else if (args[i] == "-sz")
                {
                    sort = "z-a";
                }
                else if (args[i] == "-d")
                {
                    filter = args[i + 1];
                }
                else
                {
                    Console.WriteLine("Only the following commands are currently functional:\n");
                    Console.WriteLine("-f <filename>");
                    Console.WriteLine("-sa for a-z");
                    Console.WriteLine("-sz for z-a");
                    Console.WriteLine("-d <yyyy/mm/dd filter");



                }
            }

            Console.WriteLine($"The Filename is: { filename }");
            Console.WriteLine($"The Sort is: { sort }");
            Console.WriteLine($"The Filter is: { filter }");
        }
    }
}
