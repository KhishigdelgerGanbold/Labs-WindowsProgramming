using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpConsoleApp___Windows_Programming
{
    class Program
    {
        static void Main(string[] args)
        {
            Khishigdelger.Lab1.Task1 myObj = new Khishigdelger.Lab1.Task1();
            Console.WriteLine("Enter your username: ");
            myObj.NameValue = Console.ReadLine();
            Console.WriteLine(myObj.NameValue);
            Console.WriteLine("Press enter to exit. . .");
            Console.ReadLine();

        }
    }
}
