using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.PageObjects;
using RelevantCodes.ExtentReports;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BDT.SeleniumTests
{
    public class LaunchingPage: BasePage
    {
        public LaunchingPage(IWebDriver driver, ExtentTest test)
        {
            this.driver = driver;
            this.test = test;
        }

        public LandingPage openApplication()
        {
            driver.Url = "https://www.bestdotnettraining.com/";
            //span[contains(text(),'×')]
            driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(60);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(60);
            //Thread.Sleep(10000);
            //driver.FindElement(By.XPath("span[contains(text(),'×')]")).Click();
            //driver.FindElement(By.XPath("div[@id='modalAd']/div/div/div/button")).Click();
            driver.FindElement(By.XPath("//div[@id='modalAd']/div/div/div/button")).Click();
            LandingPage lpage = new LandingPage(driver);
            PageFactory.InitElements(driver, lpage);
            return lpage;
        }
     
    }
}
