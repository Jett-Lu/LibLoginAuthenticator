using System;

namespace Login_Autehnticator_Console
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Please enter your username here:");
                string username = Console.ReadLine();

                Console.WriteLine("\nPlease enter your password here:");
                string password = Console.ReadLine();

                username = string.IsNullOrWhiteSpace(username) ? null : username;
                password = string.IsNullOrWhiteSpace(password) ? null : password;

                var authenticator = new LibLoginAuthenticator.LibLoginAuthenticator()
                {
                    Username = username,
                    Password = password
                };

                bool? authenticationResult = authenticator.Authenticate();

                if (authenticationResult == null)
                {
                    Console.WriteLine("\nError... You must enter both username and password...\n");
                }
                else if (authenticationResult == false)
                {
                    Console.WriteLine("\nAuthentication failed... Please try again...\n");
                }
                else
                {
                    Console.WriteLine("\nAuthentication successful... Press any key to exit...\n");
                    Console.ReadKey();
                    break;
                }
            }
        }
    }
}