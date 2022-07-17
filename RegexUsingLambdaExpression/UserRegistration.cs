using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegexUsingLambdaExpression
{
    public class UserRegistration
    {
        public static void CheckEmail()
        {
            Console.WriteLine("Enter Email- ");
            string email = Console.ReadLine();
            string emailpattern = @"^([A-Za-z]{3,}([.a-z]*)@[a-z]{2,}[.][a-z]{2,3}([.a-z]*))$"; 

            //using lambda expression to validate the Email
            Func<string, bool> Validfirstname = p => Regex.IsMatch(email, emailpattern);

            bool result = Validfirstname(email);
            Console.WriteLine(result);



        }
    }
}