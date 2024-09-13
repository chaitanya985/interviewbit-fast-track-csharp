https://www.interviewbit.com/problems/loops-in-c/

using System;
using System.IO;

class MAIN  {
    public static void Main(string[] args) {
        int num1 = Convert.ToInt32(Console.ReadLine());
        
        // Find the factorial of num1 and print it in a separate line
        
        long factorial=1;
        
        for(int i=1;i<=num1;i++){
            
            factorial*=i;
        }
        Console.WriteLine(factorial);
    
        int num2 =  Convert.ToInt32(Console.ReadLine());
        
        // Find the highest power of 2 that divides num2
        // and print it in a separate line
        int power=0;
        
        while(num2 % 2 == 0){
            
            num2 /= 2;
            
            power++;
        }
        Console.WriteLine(power);
    }
}
