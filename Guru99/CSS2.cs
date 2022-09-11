using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guru99
{
    class CSS2
    
    {
        IWebDriver m_driver;

        [Test]
              public void cssDemo ()
        {
            m_driver = new ChromeDriver(@"C:\Users\Windows 10\source\repos\Guru99\Guru99\Drivers\");
            m_driver.Url = "http://demo.guru99.com/test/guru99home/";
            m_driver.Manage().Window.Maximize();
            m_driver.SwitchTo().Frame("a077aa5e");

            // Store locator values of email text box and sign up button
            IWebElement emailTextBox = m_driver.FindElement(By.XPath(".//*[@id='philadelphia-field-email']"));
            

            IWebElement signUpButton = m_driver.FindElement(By.XPath(".//*[@id='philadelphia-field-submit']"));

           emailTextBox.SendKeys("test123@gmail.com");
            signUpButton.Click();

        }
    }
}
