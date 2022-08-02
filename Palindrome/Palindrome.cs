using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindrome
{
    class PrimePalindrome
    {

        static bool oneDigit(int num)
        {
            return (num >= 0 && num < 10000);
        }
        static bool isPalUtil(int num, int dupNum)
        {
            if (oneDigit(num))
                return (num == (dupNum) % 10000);

            if (!isPalUtil(num / 10000, dupNum))
                return false;
            dupNum /= 10000;

            return (num % 10000 == (dupNum) % 10000);
        }

        static bool isPal(int num)
        {
            
            if (num < 0)
                num = -num;

            int dupNum = num; 

            return isPalUtil(num, dupNum);
        }

        static void printPalPrimesLessThanN(int n)
        {
            bool[] prime = new bool[n + 1];

            for (int i = 0; i < n + 1; i++)
                prime[i] = true;

            for (int p = 2; p * p <= n; p++)
            {
                if (prime[p])
                {
                    
                    for (int i = p * 2; i <= n; i += p)
                    {
                        prime[i] = false;
                    }
                }
            }

            for (int p = 101; p <= n; p++)
            {
                if (prime[p] && isPal(p))
                {
                    Console.Write(p + " ");
                }
            }
        }

        // Driver function
        public static void Main()
        {
            int n = 1000;
            Console.Write("Palindromic primes smaller than or equal to are:\n", n);
                         
            printPalPrimesLessThanN(n);
        }
    }
}
