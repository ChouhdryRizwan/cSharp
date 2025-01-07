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
            newcar.fullRace();

            Console.WriteLine("------------------");

            Car mycar = new Car();
            mycar.company = "Honda";
            mycar.model = "Civic";

        Console.WriteLine("{0} is the model of {1} company.", mycar.model, mycar.company);

            Console.ReadKey();
        }
    }

}
