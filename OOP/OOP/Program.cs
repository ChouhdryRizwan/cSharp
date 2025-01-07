using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car newcar = new Car();
            Console.WriteLine("{0} is the model of {1} company.", newcar.model, newcar.company);

            Console.ReadKey();
        }
    }

}
