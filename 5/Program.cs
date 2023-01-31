using System;

public class Program
{
    public static void Main()
    {
        uint age = Convert.ToUInt16(Console.ReadLine());
        
        if ( age >= 18){
            Console.WriteLine("Congratulation! You are eligible for casting your vote.");
        }
        else{
            Console.WriteLine("Sorry! You are not eligible for casting your vote.");
        }
    }
}