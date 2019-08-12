using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CppppExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(
                Collection01.TotalAllOddNumbers( new int[] { 1, 2, 3, 5, 3, 1, 8, 8, 12, 15, 7, 6, 2 } )
                );
            Console.WriteLine(
                Collection01.SumLargeInts( new int[] {Int32.MaxValue, Int32.MaxValue, Int32.MaxValue} )
                );
            Console.WriteLine(
                Collection01.ReverseString("This string.")
                );
            Console.WriteLine(
                Collection01.RemoveRepeatedLetters("aaaabbbbccccaabbcceeffaavvcccbbbbbcccc")
                );

            Collection01.FizzBuzz();

            Console.ReadKey();
        }
    }
}
