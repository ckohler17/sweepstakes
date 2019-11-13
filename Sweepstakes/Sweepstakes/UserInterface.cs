﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    public static class UserInterface
    {
        private static string firstName;
        private static string lastName;
        private static string email;
        private static int registrationNum;

        public static string GetFirstName()
        {
            Console.WriteLine("What is your first name?");
            firstName = Console.ReadLine();
            return firstName;
        }
        public static string GetLastName()
        {
            Console.WriteLine("What is your last name?");
            firstName = Console.ReadLine();
            return lastName;
        }
        public static string GetEmail()
        {
            Console.WriteLine("What is your email address");
            email = Console.ReadLine();
            return email;
        }
        public static string GetStackOrQueue()
        {
            Console.WriteLine("Do you want to use 'stack' or 'queue'");
            string input = Console.ReadLine();
            return input;
        }
        public static string SweepstakesName()
        {
            Console.WriteLine("What is the name of your sweepstakes.");
            string answer = Console.ReadLine();
            return answer;
        }
    }
}
