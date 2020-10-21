using System;

namespace UserRegistrationProblem
{
    class Program
    {
        /// <summary>
        /// main method to switch to type of pattern to be matched.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            //constants for switch condition
            const string FIRST_NAME_CHECK = "a";
            const string LAST_NAME_CHECK = "b";
            const string EMAIL_CHECK = "c";
            const string MOBILE_NO_CHECK = "d";
            const string EXIT = "x";
            const string PASSWORD_CHECK = "e";
            Console.WriteLine("Welcome to User Registration Problem");
            bool flag = true;
            //flag is turned false when exit is called.
            while (flag)
            {
                Console.WriteLine("\nPress A for validating first name \npress B for validating last name\npress C for validating email id\npress D for validating mobile no\npress E to validate Password\nPress X for exit");
                //checktype saves the input from console.
                string checkType = Console.ReadLine();
                //checktype helps in switching between calling of methods.
                switch (checkType.ToLower())
                {
                    case FIRST_NAME_CHECK:
                        //going to userdetailsentry class for taking inputs.
                        UserDetailsEntry.FirstName();
                        break;
                    case LAST_NAME_CHECK:
                        UserDetailsEntry.LastName();
                        break;
                    case EMAIL_CHECK:
                        UserDetailsEntry.Email();
                        break;
                    case MOBILE_NO_CHECK:
                        UserDetailsEntry.MobileNo();
                        break;
                    case EXIT:
                        flag = false;
                        break;
                    case PASSWORD_CHECK:
                        UserDetailsEntry.Password();
                        break;
                    default:
                        Console.WriteLine("Please enter a valid input");
                        break;

                }
            }

        }
    }
}