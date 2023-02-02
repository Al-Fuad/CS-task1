using System;
public class Program
{
    public static void Main()
    {
        Console.Write("Enter Temperature : ");
        int temp = Convert.ToInt32(Console.ReadLine());
        if (temp >= 40){
            Console.WriteLine("Its Very Hot");
        }
        else if (temp < 40 && temp >= 30){
            Console.WriteLine("Its Hot");
        }
        else if (temp < 30 && temp >= 20){
            Console.WriteLine("Normal in Temp");
        }
        else if (temp < 20 && temp >= 10){
            Console.WriteLine("Cold weather");
        }
        else if (temp < 10 && temp >= 0){
            Console.WriteLine("Very Cold weather");
        }
        else if (temp < 0){
            Console.WriteLine("Freezing weather");
        }
    }
}