using System;
using System.Collections.Generic;
using System.Text;

namespace ArithmeticProgression
{
    public class CheckAP
    {
        public static bool IsArithmeticProgression(List<int> numbers)
        {
            numbers.Sort();
            var diff = numbers[1] - numbers[0];
            //Console.WriteLine($"The difference is {diff}");

            for (var index = 2; index < numbers.Count; index++)
            {
               if (numbers[index] - numbers[index - 1] != diff)
               {

                    return false;
                    
               }

                      
              
            }
            return true; 
        }
        
    }
}
