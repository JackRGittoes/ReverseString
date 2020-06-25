using System;
using System.Collections.Generic;

class MainClass
{

    public static string FirstReverse(string str)
    {
        // Converts string to list of char's 
        List<char> StandardString = new List<char>();
        foreach (char c in str)
        {
            StandardString.Add(c);
        }
        // Puts the list in reverse order
        StandardString.Reverse();

        // converts the list to a string of an array
        str = new string(StandardString.ToArray());
        return str;

    }

    static void Main()
    {
        // keep this function call here
        Console.WriteLine(FirstReverse(Console.ReadLine()));
    }

}