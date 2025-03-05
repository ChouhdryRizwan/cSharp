 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace NRecordTypes
{
    internal class Exceptions
    {
        void main(string[] args) {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            try
            {
                Console.WriteLine(a / b);
            }
            catch (Exception ex)
            {
                Console.WriteLine("zero sey divide nai huga");
                Console.WriteLine(ex.Message);
            }

            int[] arr = new int[3];

            try
            {
                arr[0] = 10;
                arr[1] = 5;
                arr[2] = 3;
                arr[3] = 9;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Finally block executed!");
            }

            foreach (int i in arr)
            {
                Console.WriteLine(i);
            }
        }
    }
}
