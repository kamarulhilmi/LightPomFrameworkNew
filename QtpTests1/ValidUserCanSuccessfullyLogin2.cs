using System;
using System.Drawing.Printing;
using Framework.Pages;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace QtpTests1
{
    [TestClass]
    public class ValidUserCanSuccessfullyLogin2 : TestBase
    {
        [TestMethod]
        public void RunTest()
        {
            Pages.Login.GoTo();
            Pages.Login.Login("seleniumTestUser", "Test12345!!$");
            Assert.IsTrue(Pages.MyMembership.IsAt(), "A valid user was not able to login. ");

             
        }
    }
}
