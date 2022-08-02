using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anagram
{
    public class Anagram
    {
        static int NO_OF_CHARS = 256;

        static bool areAnagram(char[] str1, char[] str2)
        {
            
            int[] count1 = new int[NO_OF_CHARS];
            int[] count2 = new int[NO_OF_CHARS];
            int i;

            for (i = 0; i < str1.Length && i < str2.Length;
                 i++)
            {
                count1[str1[i]]++;
                count2[str2[i]]++;
            }

            if (str1.Length != str2.Length)
                return false;

            for (i = 0; i < NO_OF_CHARS; i++)
                if (count1[i] != count2[i])
                    return false;

            return true;
        }

        public static void Main()
        {
            char[] str1 = ("abcd").ToCharArray();
            char[] str2 = ("dcba").ToCharArray();

            if (areAnagram(str1, str2))
                Console.WriteLine("The two strings are anagram of each other");
            else
                Console.WriteLine("The two strings are not  anagram of each other");

        }
    }
}
