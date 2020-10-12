using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BDT.SeleniumTests.Utilities;
using Microsoft.Edge.SeleniumTools;
using OpenQA.Selenium.Chrome;
using RelevantCodes.ExtentReports;

namespace BDT.SeleniumTests
{
    
    public class BaseTest: BasePage
    {

        public ExtentReports extent = ExtentManager.getInstance();
        


        public void setup(string browser)
        {
            if (browser == "edge")
            { 
            var options = new EdgeOptions();
            options.UseChromium = true;
            driver = new EdgeDriver(options);
            driver.Manage().Window.Maximize();

            }
            else if (browser=="chrome")
            {
                driver = new ChromeDriver();
                driver.Manage().Window.Maximize();
                test.Log(LogStatus.Info, "Chrome browser should be open");
            }


        }
    }
}
