using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RTS_Test
{
    class Program
    {
        static void Main(string[] args)
        {
            TestAboveBelow(new int[] { 1, 5, 2, 1, 10 }, 6);
            TestAboveBelow(new int[] { }, 0);
            TestAboveBelow(new int[] { 0, 1, 2, 3, 4, 5, 6 }, 3);
            TestAboveBelow(new int[] { 10, 9, 8, 7, 6 }, 5);
            TestAboveBelow(new int[] { 10, 9, 8, 7, 6 }, 8);
            TestAboveBelow(new int[] { 10, 9, 8, 7, 6 }, 11);

            TestStringRotation("MyString", 1);
            TestStringRotation("MyString", 2);
            TestStringRotation("MyString", 5);
            TestStringRotation("MyString", 10);
            TestStringRotation("MyString", 0);
            //TestStringRotation("MyString", -2);
            //TestStringRotation("", 1);
        }

        private static void TestAboveBelow(int[] ints, int value)
        {
            Console.WriteLine($"Testing Above/Below with values {ConvertIntArray(ints)} and {value}");
            PrintAboveBelowDictionary(Test.aboveBelow(ints, value));
        }

        private static void TestStringRotation(string word, int rotation)
        {
            Console.WriteLine($"Testing StringRotation with values {word} and {rotation}");
            Console.WriteLine(Test.stringRotation(word, rotation));
        }

        //For displaying the int array contents in console.
        private static string ConvertIntArray(int[] ints)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append('[');
            for (int i = 0; i < ints.Length; i++)
            {
                sb.Append(ints[i]);
                if (i + 1 < ints.Length)
                {
                    sb.Append(", ");
                }
            }
            sb.Append(']');
            return sb.ToString();
        }

        //For displaying the aboveBelow dictionary contents in console.
        private static void PrintAboveBelowDictionary(Dictionary<string, int> answer)
        {
            answer.Keys.ToList().ForEach(key =>
            {
                Console.WriteLine($"{key} : {answer[key]}");
            });
        }
    }
}
