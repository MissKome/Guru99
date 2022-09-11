using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Guru99
{
    class Guru99Demo
    {
        IWebDriver driver;


        [SetUp]
                public void startBrowser ()
        {
         driver = new
    ChromeDriver(@"C:\Users\Windows 10\source\repos\Guru99\Guru99\Drivers\");

        }
        [Test]
                 public void test ()
        {
            driver.Url = "http://www.google.co.in";

        }

        [TearDown]   
                  public void closeBrowser ()
        {
            driver.Close();
        }
           
 
          
          
           
      
  



    }
}
