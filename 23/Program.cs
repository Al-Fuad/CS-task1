using System;

public class Program
{
    public static void Main()
    {
        Console.Write("Enter a month number (1-12) : ");
        int num = Convert.ToInt16(Console.ReadLine());
        if (num == 1){
            Console.WriteLine("January have 31 days");
        }
        else if (num == 2){
            Console.WriteLine("February have 28 days in a common year and 29 days in leap years");
        }
        else if (num == 3){
            Console.WriteLine("March have 31 days");
        }
        else if (num == 4){
            Console.WriteLine("April have 30 days");
        }
        else if (num == 5){
            Console.WriteLine("May have 31 days");
        }
        else if (num == 6){
            Console.WriteLine("June have 30 days");
        }
        else if (num == 7){
            Console.WriteLine("July have 31 days");
        }
        else if (num == 8){
            Console.WriteLine("August have 31 days");
        }
        else if (num == 9){
            Console.WriteLine("September have 30 days");
        }
        else if (num == 10){
            Console.WriteLine("October have 31 days");
        }
        else if (num == 11){
            Console.WriteLine("November have 30 days");
        }
        else if (num == 12){
            Console.WriteLine("December have 31 days");
        }
        else{
            Console.WriteLine("You have entered wrong number");
        }
    }
}