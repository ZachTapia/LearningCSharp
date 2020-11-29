﻿using System;
using System.Linq;
using System.Reflection;

namespace Basics
{
    class Program
    {
        static void Main(string[] args)
        {
            // Loop through the assemblies that this app references
            foreach (var r in Assembly.GetEntryAssembly().GetReferencedAssemblies())
            {
                // Load the assembly to read it
                var a = Assembly.Load(new AssemblyName(r.FullName));

                // Declare a count
                int methodCount = 0;

                // Loop through all the types in the assembly
                foreach (var t in a.DefinedTypes)
                {
                    // Add up the counts of methods
                    methodCount += t.GetMethods().Count();
                }

                // Output the count of types and their methods
                Console.WriteLine("{0:N0} types with {1:N0} methods in {2} assembly.", arg0: a.DefinedTypes.Count(), arg1: methodCount, arg2: r.Name);
            }

            // Using nameof
            double heightInMetres = 1.88;
            Console.WriteLine($"The variable {nameof(heightInMetres) } has the value {heightInMetres}.");


        }
    }
}
