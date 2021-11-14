using System;
using System.Collections.Generic;

namespace ArithmeticProgression
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new List<int>();
            Console.WriteLine("Please enter the number of elements for the sequence (greater than 4):");
            int n = int.Parse(Console.ReadLine());

            if (n >= 4)
            {
                Console.WriteLine("Please enter the elements (each one in new line):");
                for (var index = 0; index < n; index++)
                {
                    int x=int.Parse(Console.ReadLine());
                    numbers.Add(x);
                }

                if (CheckAP.IsArithmeticProgression(numbers) == true)
                {
                    Console.WriteLine("YES");
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("NO");
                    Console.ReadLine();
                }
                
            }
            else Console.WriteLine("Sorry, the number you provided is less than 4");
        }
    }
}
