using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Edge.SeleniumTools;
using OpenQA.Selenium.Chrome;

namespace BDT.SeleniumTests
{
    
    public class BaseTest: BasePage
    {

        public void setup(string browser)
        {
            if (browser == "edge")
            { 
            var options = new EdgeOptions();
            options.UseChromium = true;
            driver = new EdgeDriver(options);

        }
            else if (browser=="chrome")
            {
                driver = new ChromeDriver();

            }


        }
    }
}
