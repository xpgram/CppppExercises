using System.Text;
using System.Numerics;
using System;

namespace CppppExercises
{
    class Collection01
    {
        // Given an array of integers, write a method to total the odd numbers.
        public static int TotalAllOddNumbers(int[] numbers)
        {
            int total = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if ((numbers[i] & 1) == 1)
                    total += numbers[i];
            }
            return total;
        }

        // Given an array of ints, write a method to sum the elements in the array, knowing that some of the elements may be very large integers.
        public static BigInteger SumLargeInts(int[] numbers)
        {
            BigInteger sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }
            return sum;
        }

        // Given a string, reverse it.
        public static string ReverseString(string str)
        {
            char c;
            StringBuilder result = new StringBuilder(str);

            int j;
            for (int i = 0; i < (result.Length >> 1); i++)
            {
                j = result.Length - (i + 1);
                c = result[i];
                result[i] = result[j];
                result[j] = c;
            }

            return result.ToString();
        }

        // Give a string, remove any repeated letters.
        public static string RemoveRepeatedLetters(string str)
        {
            StringBuilder result = new StringBuilder(str);
            char c;

            for (int i = 0; i < result.Length; i++)
            {
                c = result[i];
                for (int j = i+1; j < result.Length; j++)
                    if (result[j] == c)
                    {
                        result.Remove(j, 1);
                        j--;
                    }
            }

            return result.ToString();
        }

        // FizzBuzz
        public static void FizzBuzz()
        {
            bool fizz, buzz;
            for (int i = 1; i <= 100; i++) {
                fizz = (i % 3 == 0);
                buzz = (i % 5 == 0);
                Console.WriteLine( ((fizz) ? "Fizz" : "") + ((buzz) ? "Buzz" : "") + ((!(fizz || buzz)) ? i.ToString() : "") );
            }
        }
    }
}
