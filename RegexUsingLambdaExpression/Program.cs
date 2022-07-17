using System;

namespace RegexUsingLambdaExpression
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the password that should have min 8 characters, atleast 1 UpperCase & 1 Numeric Number");
            UserRegistration.CheckUserPassword();
        }
    }
}
