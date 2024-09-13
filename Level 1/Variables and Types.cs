https://www.interviewbit.com/problems/variables-and-types-in-c/

using System;
using System.IO;

class MAIN  {
    public static void Main(string[] args) {
        // YOUR CODE GOES HERE
        // Please take input and print output to standard input/output (stdin/stdout)
        // DO NOT USE ARGUMENTS FOR INPUT
        // E.g. 'StreamReader' for input & 'StreamWriter' for output
        int intValue = Convert.ToInt32(Console.ReadLine());
        long longValue = Convert.ToInt64(Console.ReadLine());
        char charValue = Convert.ToChar(Console.ReadLine());
        float floatValue = Convert.ToSingle(Console.ReadLine());
        double doubleValue = Convert.ToDouble(Console.ReadLine());
        
        Console.WriteLine(intValue);
        Console.WriteLine(longValue);
        Console.WriteLine(charValue);
        Console.WriteLine(floatValue);
        Console.WriteLine(doubleValue);
    }
}
