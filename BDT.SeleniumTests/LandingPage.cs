using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BDT.SeleniumTests
{
    public class LandingPage: BasePage
    {
        [FindsBy(How = How.LinkText, Using = "Login")]
        public IWebElement loginBtn;
        
        [FindsBy(How = How.Id, Using = "EmailId")]
        public IWebElement username;
        
        [FindsBy(How = How.Id, Using = "signInPassword")]
        public IWebElement password;

        public LandingPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        public HomePage SignIn()
        {


            driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(10);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            loginBtn.Click();
            
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            username.SendKeys("isantha@live.com");
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            password.SendKeys("abc");
            password.SendKeys(Keys.Enter);

            HomePage hp = new HomePage(driver);
            PageFactory.InitElements(driver, hp);
            return hp;



        }

    }


}
