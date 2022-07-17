﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegexUsingLambdaExpression
{
    public class UserRegistration
    {
        public static void CheckFirstName()
        {
            Console.WriteLine("Enter your First Name- ");
            string firstname = Console.ReadLine();
            string firstnamepattern = @"^[A-Z]{1}[a-z]{2,}$";

            //using lambda expression to validate the first name
            Func<string, bool> Validfirstname = p => Regex.IsMatch(firstname, firstnamepattern);

            bool result = Validfirstname(firstname);
            Console.WriteLine(result);



        }
    }
}