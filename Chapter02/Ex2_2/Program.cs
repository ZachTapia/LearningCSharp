using System;
using static System.Console;

namespace Ex2_2
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("------------------------------------------------------------------------------------------------------------------------");
            Write(
                format: "{0, -10} {1, -20}",
                arg0: "Type",
                arg1: "Byte(s) of memory"
            );
            WriteLine(
               format: "{0, 40} {1, 40}",
               arg0: "Min",
               arg1: "Max"
           );
            WriteLine("------------------------------------------------------------------------------------------------------------------------");
            Write(
                format: "{0, -10} {1, -20}",
                arg0: "sbyte",
                arg1: sizeof(sbyte)
            );
            WriteLine(
               format: "{0, 40} {1, 40}",
               arg0: sbyte.MinValue,
               arg1: sbyte.MaxValue
           );
            Write(
                 format: "{0, -10} {1, -20}",
                 arg0: "byte",
                 arg1: sizeof(byte)
             );
            WriteLine(
               format: "{0, 40} {1, 40}",
               arg0: byte.MinValue,
               arg1: byte.MaxValue
           );
            Write(
                 format: "{0, -10} {1, -20}",
                 arg0: "short",
                 arg1: sizeof(short)
             );
            WriteLine(
               format: "{0, 40} {1, 40}",
               arg0: short.MinValue,
               arg1: short.MaxValue
           );
            Write(
                format: "{0, -10} {1, -20}",
                arg0: "ushort",
                arg1: sizeof(ushort)
            );
            WriteLine(
               format: "{0, 40} {1, 40}",
               arg0: ushort.MinValue,
               arg1: ushort.MaxValue
           );
            Write(
                format: "{0, -10} {1, -20}",
                arg0: "int",
                arg1: sizeof(int)
            );
            WriteLine(
               format: "{0, 40} {1, 40}",
               arg0: int.MinValue,
               arg1: int.MaxValue
           );
            Write(
               format: "{0, -10} {1, -20}",
               arg0: "uint",
               arg1: sizeof(uint)
           );
            WriteLine(
               format: "{0, 40} {1, 40}",
               arg0: uint.MinValue,
               arg1: uint.MaxValue
           );
            Write(
               format: "{0, -10} {1, -20}",
               arg0: "long",
               arg1: sizeof(long)
           );
            WriteLine(
               format: "{0, 40} {1, 40}",
               arg0: long.MinValue,
               arg1: long.MaxValue
           );
            Write(
               format: "{0, -10} {1, -20}",
               arg0: "ulong",
               arg1: sizeof(ulong)
           );
            WriteLine(
               format: "{0, 40} {1, 40}",
               arg0: ulong.MinValue,
               arg1: ulong.MaxValue
           );
            Write(
               format: "{0, -10} {1, -20}",
               arg0: "float",
               arg1: sizeof(float)
           );
            WriteLine(
               format: "{0, 40} {1, 40}",
               arg0: float.MinValue,
               arg1: float.MaxValue
           );
            Write(
               format: "{0, -10} {1, -20}",
               arg0: "double",
               arg1: sizeof(double)
           );
            WriteLine(
               format: "{0, 40} {1, 40}",
               arg0: double.MinValue,
               arg1: double.MaxValue
           );
            Write(
               format: "{0, -10} {1, -20}",
               arg0: "decimal",
               arg1: sizeof(decimal)
           );
            WriteLine(
               format: "{0, 40} {1, 40}",
               arg0: decimal.MinValue,
               arg1: decimal.MaxValue
           );


        }
    }
}
