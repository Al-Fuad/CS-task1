using System;

public class Program
{
    public static void Main()
    {
        Console.Write("Input the grade : ");
        char grade = Convert.ToChar(Console.ReadLine());
        if (grade == 'f' || grade == 'F'){
            Console.WriteLine("You have chosen : Fail");
        }
        else if (grade == 'a' || grade == 'A'){
            Console.WriteLine("You have chosen : Average");
        }
        else if (grade == 'g' || grade == 'G'){
            Console.WriteLine("You have chosen : Good");
        }
        else if (grade == 'v' || grade == 'V'){
            Console.WriteLine("You have chosen : Very Good");
        }
        else if (grade == 'e' || grade == 'E'){
            Console.WriteLine("You have chosen : Excellent");
        }
        else{
            Console.WriteLine("You have chosen : Wrong Grade");
        }
    }
}