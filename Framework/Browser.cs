using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Framework
{
    public static class Browser
    {
        private static IWebDriver webDriver = new ChromeDriver(@"C:\Users\REG-LPT-077\Documents\Visual Studio 2015\Projects\LightPomFrameworkNew\Framework\Drivers");
        private static string baseurl = "http://www.qtptutorial.net";

        public static ISearchContext Driver
        {
            get { return webDriver; }
        }

        public static string Title
        {
            get { return webDriver.Title; }
        }

        public static void Initialize()
        {
            //Goto("");
        }

        public static void Close()
        {
            webDriver.Close();
        }

        public static void GoTo(string relativurl)
        {
            webDriver.Navigate().GoToUrl(string.Format("{0}/{1}", baseurl ,relativurl));
        }

        internal static IWebElement FindElement(By by)
        {
            return webDriver.FindElement(by);
        }

        public static bool ElementIsDisplayed(By element)
        {
            var present = false;
            webDriver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(0));
            try
            {
                present = webDriver.FindElement(element).Displayed;
            }
            catch (NoSuchElementException)
            {
            }
            webDriver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(10));
            return present;
        }

        public static bool WaitUntilElementIsDisplayed(By element, int timeoutInSeconds)
        {
            for (int i = 0; i < timeoutInSeconds; i++)
            {
                if (ElementIsDisplayed(element))
                {
                    return true;
                }
                Thread.Sleep(1000);
            }
            return false;
        }
    }
}
