using NUnit.Framework;
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
            setup("edge");
            driver.Quit();
        }
    }
}
