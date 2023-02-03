using System;

public class Program
{
    public static void Main()
    {
        Console.Write("Input Digit (0-9) : ");
        int digit = Convert.ToInt16(Console.ReadLine());

        switch (digit)
        {
            case 0:
                Console.Write("Zero\n");
                break;
            case 1:
                Console.Write("one\n");
                break;
            case 2:
                Console.Write("Two\n");
                break;
            case 3:
                Console.Write("Three\n");
                break;
            case 4:
                Console.Write("Four\n");
                break;
            case 5:
                Console.Write("Five\n");
                break;
            case 6:
                Console.Write("Six\n");
                break;
            case 7:
                Console.Write("Seven\n");
                break;
            case 8:
                Console.Write("Eight\n");
                break;
            case 9:
                Console.Write("Nine\n");
                break;
            default:
                Console.Write("You have entered wrong number");
                break;
        }
    }
}