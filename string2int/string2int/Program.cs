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
            int value = 0; // Set variable type to int so it can store decimal value when subtract ascii dec
            foreach(char c in str) // looping every char in string
            {
                if(c >= 48 && c <= 57) // check if ascii decimal of char is between 48 - 57 so it will be number 0-9
                //This if statement only take number in to process otherwise it ignore.
                {   
                value = value * 10 + (c - '0'); // (c-'0') is get decimal of ascii decimal of first char subtract with ascii decimal of '0' 
                    //what will return is distance of ascii decimal of two chars. So the distance between them is equal to int value
                    //Then store in value * 10, this will increase digits number of value in every loop process start with 1 digit since value is initial by 0
                }
            }

            return value;
        }
    }
}
