using System;

namespace OOPPrinciper
{
    class User
    {
        private string password;

        public void SetPassword(string pwd)
        {
            password = pwd;
        }

        public bool CheckPassword(string input)
        {
            return input == password;
        }
    }
}
