using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Support.PageObjects;

namespace Framework.Pages
{
    public static class Pages
    {
        private static T GetPages<T>() where T : new()
        {
            var page = new T();
            PageFactory.InitElements(Browser.Driver, page);
            return page;
        }

        public static LoginPage Login
        {
            get { return GetPages<LoginPage>(); }
        }

        public static MyMembershipPage MyMembership
        {
            get { return GetPages<MyMembershipPage>(); }
        }

        public static EditProfilePage EditProfile
        {
            get { return GetPages<EditProfilePage>(); }
        }
    }
}
