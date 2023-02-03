using System;
public class Program
{
    public static void Main()
    {
        Console.Write("Enter the first Integer : ");
        int fi = Convert.ToInt16(Console.ReadLine());
        Console.Write("Enter the second Integer : ");
        int si = Convert.ToInt16(Console.ReadLine());
        Console.WriteLine("Here are the options :\n1-Addition\n2-Substraction\n3-Multiplication.\n4-Division.\n5-Exit.\n");
        Console.Write("Input your Choice : ");
        int choice = Convert.ToInt16(Console.ReadLine());
        if (choice == 1){
            Console.WriteLine($"The Addition of {fi} and {si} is : {fi+si}");
        }
        else if (choice == 2){
            Console.WriteLine($"The Subtraction of {fi} and {si} is : {fi-si}");
        }
        else if (choice == 3){
            Console.WriteLine($"The Multiplication of {fi} and {si} is : {fi*si}");
        }
        else if (choice == 4){
            Console.WriteLine($"The Division of {fi} and {si} is : {fi/si}");
        }
        else if (choice == 5){
            Console.WriteLine("Thank you");
        }
        else{
            Console.WriteLine("You have entered wrong number");
        }
    }
}