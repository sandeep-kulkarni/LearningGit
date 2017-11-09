using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstGitApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Console.WriteLine("Sum of 10, 20 is "+ add(10,20));
            Console.ReadKey();
        }

        static int add(int x, int y)
        {
            return x + y;
        }
    }
}
