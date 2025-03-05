using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NRecordTypes
{
    class myStack
    {

        public  myStack() {
            int a = 10;
            int b = a;  // Copy ban gaya

            b = 20;

            Console.WriteLine("Puranii Value : " + a);  // Output: 10  (Original value change nahi hui)
            Console.WriteLine("New Value : "+ b);  // Output: 20  (Copy change ho gayi)
        }
    }
}
