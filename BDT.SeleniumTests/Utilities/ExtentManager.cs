using RelevantCodes.ExtentReports;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BDT.SeleniumTests.Utilities
{


    public class ExtentManager
    {
        private static ExtentReports extent;

        public static ExtentReports getInstance()
        {
            if (extent == null)
            {
                string fileName = DateTime.UtcNow.ToString("yyyy-MM-dd-mm-ss") + ".html";
                string reportPath = "C:\\Users\\sa7admin\\Downloads\\reports" + fileName;
                extent = new ExtentReports(reportPath, true, DisplayOrder.NewestFirst);
                extent.LoadConfig(@"C:\Users\sa7admin\source\repos\BDT.SeleniumFramework\BDT.SeleniumTests\Extent-Config.xml");
                extent.AddSystemInfo("tester", "santosh").AddSystemInfo("version", "3.0");
            }
            return extent;


        }
    }

}
