https://www.interviewbit.com/problems/operators-in-c/

using System;
using System.IO;

class MAIN  {
    public static void Main(string[] args) {
        // YOUR CODE GOES HERE
        // Please take input and print output to standard input/output (stdin/stdout)
        // DO NOT USE ARGUMENTS FOR INPUT
        // E.g. 'StreamReader' for input & 'StreamWriter' for output
        /***Don't change anything here***/
        string s = Console.ReadLine();
        int a = Convert.ToInt16(s);
        s = Console.ReadLine();
        int b = Convert.ToInt16(s);
        
        int add, sub, multi, div;
        
        /***Don't change anything here***/
        //Start coding from here
        add=a+b;
        
        sub=a-b;
        
        multi=a*b;
        
        div=a/b;
      
        /***Don't change anything here***/
        Console.WriteLine(add);
        Console.WriteLine(sub);
        Console.WriteLine(multi);
        Console.WriteLine(div);
        
        
        /***Don't change anything here***/
 
    }
}
