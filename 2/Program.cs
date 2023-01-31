using System;

public class Program
{
    public static void Main()
    {
        int num = Convert.ToInt32(Console.ReadLine());
        // int num2 = Convert.ToInt32(Console.ReadLine());
        
        if ( num % 2 == 0){
            Console.WriteLine("The number is even.");
        }
        else{
            Console.WriteLine("The number is odd.");
        }
    }
}