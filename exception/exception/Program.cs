using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exception
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("num 1");
           int value1 =  int.Parse(Console.ReadLine());

            Console.WriteLine("num 2");
            int value2 = int.Parse(Console.ReadLine());
            try {
                Console.WriteLine(value1 / value2);
            }
            catch {
                Console.WriteLine("divide nai hu sakta");
            }
        }
    }
}
