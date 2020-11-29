using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names; // Can reference any array of strings

            // Allocating memory for four string in an array
            names = new string[4];

            // Storing items at indices
            names[0] = "Kate";
            names[1] = "Jon";
            names[2] = "Al";
            names[3] = "Zach";

            // Looping through the names
            for (int i = 0; i < names.Length; i++)
            {
                // Output
                Console.WriteLine(names[i]);
            }
        }
    }
}

// #53
