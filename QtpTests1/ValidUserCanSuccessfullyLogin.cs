using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;

namespace QtpTests1
{
    [TestClass]
    public class ValidUserCanSuccessfullyLogin
    {
        [TestMethod]
        public void RunTest()
        {
            //Create new instance of chrome Driver
            var driver = new ChromeDriver(@"C:\Users\REG-LPT-077\Documents\Visual Studio 2015\Projects\LightPomFrameworkNew\Framework\Drivers");
            driver.Navigate().GoToUrl("http://www.qtptutorial.net/wp-login.php");

            //find LoginWithPassword button
            var start = driver.FindElement(By.LinkText("log in with a password"));
            start.Click();

            //find the field for the username
            var user = driver.FindElement(By.Id("user_login"));
            user.SendKeys("seleniumTestUser");

            //find the field for the password
            var pass = driver.FindElement(By.Id("user_pass"));
            pass.SendKeys("Test12345!!$");

            //find log in button and perform click action
            driver.FindElement(By.Id("wp-submit")).Click();

        }
    }
}
