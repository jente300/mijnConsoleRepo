using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VBConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Hello world!");
            Console.WriteLine("Druk op een toets om te stoppen...");
            Console.ReadKey();
        }
    }
}
