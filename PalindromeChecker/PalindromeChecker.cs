using System;
using System.Collections.Generic;
using System.Text;

namespace DSProgram
{
    class CustomLinkedList<T>
    {

        public string input;
        public void IsPalindrome()
        {

            CustomLinkedList<char> linkedList = new CustomLinkedList<char>();
            //Enter the Element to be Checked as Palindrome
            Console.WriteLine("Enter the string to be checked!");
            input = Console.ReadLine();
            for (int i = 0; i < input.Length; i++)
            {
                linkedList.Enqueue(input[i]);
            }
            linkedList.Display();

            string reverseWord = linkedList.DequeuePalindromeChecker();
            if (input == reverseWord)
            {
                Console.WriteLine("\n{0} is a Palindrome!", input);
            }
            else
            {
                Console.WriteLine("\n{0} is not a Palindrome!", input);

            }
        }
        private void Enqueue(char v)
        {
            throw new NotImplementedException();
        }
        private void Display()
        {
            throw new NotImplementedException();
        }
        private string DequeuePalindromeChecker()
        {
            throw new NotImplementedException();
        }
    }
}
