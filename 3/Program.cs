using System;

public class Program
{
    public static void Main()
    {
        int num = Convert.ToInt32(Console.ReadLine());
        
        if ( num < 0){
            Console.WriteLine("The number is negative.");
        }
        else{
            Console.WriteLine("The number is positive.");
        }
    }
}