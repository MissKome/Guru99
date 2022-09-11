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
    class CSS
    {
        IWebDriver m_driver;

        [Test]
             public void cssDemo ()
        {
            m_driver = new
        ChromeDriver(@"C:\Users\Windows 10\source\repos\Guru99\Guru99\Drivers\");
            m_driver.Url = "http://demo.guru99.com/test/guru99home/";
            m_driver.Manage().Window.Maximize();
            IWebElement element = m_driver.FindElement(By.XPath("/html/body/div[4]/header/div[1]/div/div[2]/div/ul/li[2]/a"));
          element.Click();

            m_driver.Close();
        }
    }
}
