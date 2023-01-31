using System;

public class Program
{
    public static void Main()
    {
        int m = Convert.ToInt16(Console.ReadLine());
        
        if (m < 0){
            Console.WriteLine("n = -1");
        }
        else if (m == 0){
            Console.WriteLine("n = 0");
        }
        else{
            Console.WriteLine("n = 1");
        }
    }
}