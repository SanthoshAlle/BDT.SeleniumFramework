using NUnit.Framework;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BDT.SeleniumTests
{   
    [TestFixture]
    public class LoginTC: BaseTest
    {
        [Test]
        public void login()
        {
            setup("chrome");
            LaunchingPage lp = new LaunchingPage(driver);
            PageFactory.InitElements(driver, lp);
            LandingPage lpage1= lp.openApplication();
            PageFactory.InitElements(driver, lpage1);
           HomePage hp1= lpage1.SignIn();
            PageFactory.InitElements(driver, hp1);
            PackagesMenu pm = hp1.Packages();
            PageFactory.InitElements(driver, pm);
            pm.goldmembership();

            // driver.Quit();
        }
    }
}
