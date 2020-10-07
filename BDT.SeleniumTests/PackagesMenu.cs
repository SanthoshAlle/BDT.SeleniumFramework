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
    public class PackagesMenu:BasePage
    {

        [FindsBy(How = How.XPath, Using = "//div[@id='collapsibleNavbar']/ul/li[2]/div/a")]
        public IWebElement goldMembership;

        public PackagesMenu(IWebDriver driver)
        {
            this.driver = driver;
        }

        public void goldmembership()
        {           

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);
            Actions enterGold = new Actions(driver);
            enterGold.MoveToElement(goldMembership).Click().Build().Perform();
        }
    }
}
