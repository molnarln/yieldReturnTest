using System;
using System.Collections;
using System.Collections.Generic;

namespace yieldReturnTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            foreach (var number in GetNumbers()) Console.WriteLine(number);
            foreach (var number in GetNumbers2()) Console.WriteLine(number);



            IEnumerable GetNumbers()
            {
                yield return 1; yield return 2; yield return 3;
            }

            IEnumerable GetNumbers2()
            {
                return new List<int>() { 1, 2, 3 };
            }

        }
    }
}
