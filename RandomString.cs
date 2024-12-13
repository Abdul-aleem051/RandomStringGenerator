using System;
using System.Text;

public class RandomStringGenerator
{

    public static void GenerateRandomString()
    {
        try
        {
            Console.BackgroundColor = ConsoleColor.DarkGray;
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.ForegroundColor = ConsoleColor.DarkBlue;

            Console.WriteLine("===>Input the length of your newly generated string: ");
            int input = Convert.ToInt32(Console.ReadLine()!);
            string result = GetRandomString(input);
            Console.WriteLine($"Your newly generated string is : {result}");
        }
        catch (FormatException)
        {
            Console.WriteLine("Invalid format, Try again later!!!");
        }
    }
    public static string GetRandomString(int length, bool includeAlphabets = true, bool includeNumbers = true, bool includeSpecialCharacters = true)
    {

        
        string alphabets = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";
        string numbers = "0123456789";
        string specialCharacters = "!@#$%^&*()-_=+[]{};:'\",.<>?/|\\~`";

        
        StringBuilder charPool = new StringBuilder();

        if (includeAlphabets)
        {
            charPool.Append(alphabets);
        }
        if (includeNumbers)
        {
            charPool.Append(numbers);
        }
        if (includeSpecialCharacters)
        {
            charPool.Append(specialCharacters);
        }

        else
        {
            return string.Empty;
        }
        
        Random rand = new Random();
        StringBuilder randomString = new StringBuilder(length);

        for (int i = 0; i < length; i++)
        {
            int index = rand.Next(charPool.Length);
            randomString.Append(charPool[index]);
        }

    
        return randomString.ToString();
    }

}

