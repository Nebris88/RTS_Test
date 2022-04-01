using System;
using System.Collections.Generic;

namespace RTS_Test
{
    public static class Test
    {        
        public static Dictionary<string, int> aboveBelow(int[] ints, int value)
        {
            //create counter variables for above and below, initialized to 0.
            int aboveCount = 0;
            int belowCount = 0;

            //loops through array 
            foreach (int element in ints)
            {
                //increment above or below count when the element is above or below the passed value, respectively
                if (element > value)
                {
                    aboveCount++;
                }
                else if (element < value) //cant be just else, as equal values would be counted
                {
                    belowCount++;
                }
                //do nothing if element == value
            }

            /*
              If the passed array was sorted, you could perform a binary search (logn) to find the point at which
              every element is below and the point at which every element is above (not necessarily the same, as
              some elements could be equal) and simply find the distance between the 'last below and the start'
              for the below count and the 'first above and the length' for the above count.  This method is faster,
              as we would not always need to loop through the entire array.
            */

            //create answer dictionary and add key/value pairs ofr the above and below counts
            Dictionary<string, int> answer = new Dictionary<string, int>();
            answer.Add("above", aboveCount);
            answer.Add("below", belowCount);

            return answer;
        }

        public static string stringRotation(string word, int rotation)
        {
            //check to see if we can save time if word is empty or isn't being rotated (also error protects later opterations)
            if (String.IsNullOrEmpty(word) || rotation < 1)
            {
                //maybe throw InvalidArgumentException?
                return word;
            }

            //create a character array the same size as the string, as we can't edit the string itself (immutable)
            char[] characterArray = new char[word.Length];

            //create int for holding the index of the character we're swapping to
            int destinationIndex;

            //loop through each character in the word
            for (int i = 0; i < word.Length; i++)
            {
                //calculate the spot in the new array which will receive the character in the word at the current index
                destinationIndex = (i + rotation) % word.Length;

                //place the character in the string at the current index into the characterArray at its new destination index
                //this operation is protected from the empty check earlier
                characterArray[destinationIndex] = word[i];
            }

            return new string(characterArray);
        }
    }
}
