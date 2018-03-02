using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] numbers = new int[4];

            numbers[0] = 286;
            numbers[1] = 287;
            numbers[2] = 288;
            numbers[3] = 289;

            foreach (int k in numbers)
            {
                Console.WriteLine(k);
                Console.ReadLine();
            }
        }
    }
}
