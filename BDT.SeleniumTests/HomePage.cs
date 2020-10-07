using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BDT.SeleniumTests
{
    public class HomePage: BasePage
    {

        [FindsBy(How = How.LinkText, Using = "Packages")]
        public IWebElement packages;

        

        public HomePage(IWebDriver driver)
        {
            this.driver = driver;
        }

        public PackagesMenu Packages()
        {
            driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(30);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            packages.Click();

            PackagesMenu pm = new PackagesMenu(driver);
            PageFactory.InitElements(driver, pm);
            return pm;

        }

    }
}
