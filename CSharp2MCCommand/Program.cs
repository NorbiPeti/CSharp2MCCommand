using Microsoft.CSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp2MCCommand
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Filename:");
            //Converter.ConvertToCommands(Console.ReadLine());
            Converter.ConvertToCommands("TestProject.dll");
            Console.ReadLine();
        }
    }
}
