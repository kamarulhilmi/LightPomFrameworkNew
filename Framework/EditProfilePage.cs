using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace Framework.Pages
{
    public class EditProfilePage
    {
        #region Constants
        private static int PAGE_LOAD_TIMEOUT = 10;

        #endregion

        
        public bool IsAt()
        {
            By element = By.XPath("//h1[contains(text(),'Edit Profile')]");
            if (!Browser.WaitUntilElementIsDisplayed(element, 3))
                //Browser.SwitchTabs(1);
            return Browser.WaitUntilElementIsDisplayed(element, PAGE_LOAD_TIMEOUT);
        }
    }
}
