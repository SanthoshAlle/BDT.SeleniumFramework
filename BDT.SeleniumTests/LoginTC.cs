using NUnit.Framework;
using OpenQA.Selenium.Support.PageObjects;
using RelevantCodes.ExtentReports;
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

        string testcaseName = "LoginTC";



        [Test]
        public void login()
        {
            test = extent.StartTest(testcaseName);

            setup("chrome");
            LaunchingPage lp = new LaunchingPage(driver,test);
            PageFactory.InitElements(driver, lp);
            LandingPage lpage1= lp.openApplication();
            PageFactory.InitElements(driver, lpage1);
           HomePage hp1= lpage1.SignIn();
            PageFactory.InitElements(driver, hp1);
            PackagesMenu pm = hp1.Packages();
            PageFactory.InitElements(driver, pm);
            pm.goldmembership();
            test.Log(LogStatus.Pass, "goldmembership page open");

            // driver.Quit();
        }
    }
}
