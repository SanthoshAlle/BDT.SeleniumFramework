using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BDT.SeleniumTests
{
    public class LaunchingPage: BasePage
    {
        public LaunchingPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        public LandingPage openApplication()
        {
            driver.Url = "https://www.bestdotnettraining.com/";
            LandingPage lpage = new LandingPage(driver);
            PageFactory.InitElements(driver, lpage);
            return lpage;
        }
     
    }
}
