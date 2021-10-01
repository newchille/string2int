using System;

namespace string2int
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter string : ");
            string input = Console.ReadLine();
            Console.WriteLine(String2Int(input));
        }

        static int String2Int(string str)
        {
            int value = 0;
            foreach(char c in str)
            {
                if(c >= 48 && c <= 57)
                {
                value = value * 10 + (c - '0');
                }
            }

            return value;
        }
    }
}
