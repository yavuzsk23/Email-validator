using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        string email = "test@example.com";

        if (Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
        {
            Console.WriteLine("valid ");
        }
        else
        {
            Console.WriteLine("invalid ");
        }
    }
}
