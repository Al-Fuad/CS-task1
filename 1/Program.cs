using System;

public class Program
{
    public static void Main()
    {
        int num1 = Convert.ToInt32(Console.ReadLine());
        int num2 = Convert.ToInt32(Console.ReadLine());
        
        if ( num1 == num2){
            Console.WriteLine("The numbers are equal.");
        }
        else{
            Console.WriteLine("The numbers are not equal.");
        }
    }
}