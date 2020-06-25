using System;
using System.Collections.Generic;

class Progrma
{

    public static string FirstReverse(string str)
    {
        // Converts string to list of char's 
        List<char> reversedString = new List<char>();
        foreach (char c in str)
        {
            reversedString.Add(c);
        }
        // Puts the list in reverse order
        reversedString.Reverse();

        // converts the list to a string of an array
        str = new string(reversedString.ToArray());
        return str;

    }

    static void Main()
    {
        // keep this function call here
        Console.WriteLine(FirstReverse(Console.ReadLine()));
    }

}