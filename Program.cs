/*
LCM and HCF from Coding Challenges
by Silvio Duka

Last modified date: 2018-02-25 

LCM is the least common multiple of a set of numbers. 
HCF is the highest common factor of a set of numbers. 

Consider 10 and 15: 
Multiples of 10 are: 10, 20, 30, 40, ... 
Multiples of 15 are: 15, 30, 45, 60, ... 
=> 30 is the LCM of 10 and 15. 

Factors of 10 are: 1, 2, 5, 10 
Factors of 15 are: 1, 3, 5, 15 
=> 5 is the HCF of 10 and 15. 

Tasks: 
(Easy) Write a program to find the LCM and HCF of 2 numbers. 
(Medium) Write a program to find the LCM and HCF of 3 numbers. 
(Hard) Write a program to find the LCM and HCF of 4 or more numbers.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LCMandHCF
{
    class Program
    {
        static int[] numbers = { 10, 15 }; //Insert a list of N-numbers (minimum 2 numbers)

        static void Main(string[] args)
        {
            Console.WriteLine($"The LCM of [{ String.Join(",", numbers) }] is {LCM()}");
            Console.WriteLine($"The HCF of [{ String.Join(",", numbers) }] is {HCF()}");
        }

        static int LCM()
        {
            Array.Sort(numbers);

            long multipliedAll = 1;

            foreach (int number in numbers)
            {
                multipliedAll *= number;
            }

            for (int i = numbers[numbers.Length - 1]; i < multipliedAll + 1; i += numbers[numbers.Length - 1])
            {
                int t = 0;

                for (int j = 0; j < numbers.Length; j++)
                {
                    t += i % numbers[j];
                }

                if (t == 0) return i;
            }

            return 0;
        }

        static int HCF()
        {
            Array.Sort(numbers);

            for (int i = numbers[0]; i > 0; i--)
            {
                int t = 0;

                for (int j = 0; j < numbers.Length; j++)
                {
                    t += numbers[j] % i;
                }

                if (t == 0) return i;
            }

            return 0;
        }
    }
}