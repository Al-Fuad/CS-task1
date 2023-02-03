using System;

public class Program
{
    public static void Main()
    {
        Console.Write("Enter a alphabet : ");
        char alphabet = Convert.ToChar(Console.ReadLine());
        if (alphabet == 'a' || alphabet == 'e' || alphabet == 'i' || alphabet =='o' || alphabet == 'u'){
            Console.WriteLine("The alphabet is a vowel");
        }
        else{
            Console.WriteLine("The alphabet is a consonant");
        }
    }
}