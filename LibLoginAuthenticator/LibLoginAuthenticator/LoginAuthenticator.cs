using System;

namespace LibLoginAuthenticator
{
    public class LibLoginAuthenticator
    {
        public string Username { get; set; }
        public string Password { get; set; }

        public LibLoginAuthenticator()
        {
            Username = null;
            Password = null;
        }

        public bool? Authenticate()
        {
            if (string.IsNullOrEmpty(Username) || string.IsNullOrEmpty(Password))
                return null;

            string[] validUsernames = { "john", "will", "jane" };
            string[] validPasswords = { "doe", "james", "smith" };

            for (int i = 0; i < validUsernames.Length; i++)
            {
                if (string.Equals(Username, validUsernames[i], StringComparison.OrdinalIgnoreCase) && Password == validPasswords[i])
                    return true;
            }

            return false;
        }
    }
}