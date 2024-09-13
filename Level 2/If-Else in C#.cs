https://www.interviewbit.com/problems/if-else-in-c/

using System;
using System.IO;

class MAIN  {
    public static void Main(string[] args) {
        int number = Convert.ToInt32(Console.ReadLine());
        
        // Use if - else to print the required statements
        
        if (number % 2 == 1)
        {
            Console.WriteLine("Odd");
        }
        else{
            
            Console.WriteLine("Even");
        }
    }
}
