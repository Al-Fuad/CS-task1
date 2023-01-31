using System;

public class Program
{
    public static void Main()
    {
        uint year = Convert.ToUInt32(Console.ReadLine());
        
        if ( year % 4 == 0){
            Console.WriteLine(year+" is a leap year.");
        }
        else{
            Console.WriteLine(year+" is not a leap year.");
        }
    }
}