https://www.interviewbit.com/problems/jump-statements-in-c/

using System;
using System.IO;

class MAIN  {
    public static void Main(string[] args) {
        int N = Convert.ToInt32(Console.ReadLine());
        
        // code here
        for(int i=0; i<=N; i++){
            
            if (i % 2 == 0){
                continue;
            }
            Console.WriteLine(i);
        }
    }
}
