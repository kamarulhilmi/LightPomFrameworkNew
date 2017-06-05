using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace Framework.Pages
{
    class LoginPage
    {
        public void GoTo()
        {
            Browser.GoTo("/wp-login.php");
        }

        public void Login(string userName, string password)
        {
            //find LoginWithPassword button
            var startLogin = Browser.Driver.FindElement(By.LinkText("log in with a password"));
            startLogin.Click();

            //find the field for the username
            var userNameField = Browser.Driver.FindElement(By.Id("user_login"));
            userNameField.SendKeys("seleniumTestUser");

            //find the field for the password
            var passwordField = Browser.Driver.FindElement(By.Id("user_pass"));
            passwordField.SendKeys("Test12345!!$");

            //find log in button and perform click action
            Browser.Driver.FindElement(By.Id("wp-submit")).Click();

        }
    }
}
