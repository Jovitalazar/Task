using System;

namespace GitPracticeApp
{
    public class LoginService
    {
        public string Login(string username, string password)
        {
            if (username == "admin" && password == "1234")
            {
                return "Login successful";
            }

            return "Invalid username or password";
        }
    }
}