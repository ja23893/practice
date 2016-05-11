using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using NUnit.Framework;
using OpenQA.Selenium.Support.UI;



namespace ConsoleApplication4
{
    class Class1
    {
        [Test]

        public static void Main(string[] args)
        {
            IWebDriver driver = new ChromeDriver(@"D:\Users\jafurtad\Downloads\chromedriver_win32");
            driver.Url = "https://dev.mailshotmaker.royalmail.com/";
            driver.FindElement(By.PartialLinkText("Login")).Click();
            driver.FindElement(By.Id("Email")).SendKeys("manvendra.b.singh@capgemini.com");
            driver.FindElement(By.Id("Password")).SendKeys("Welcome@123");
            driver.FindElement(By.XPath("//*[@id='login']/div/form/div[4]/button")).Click();
       
     
        }
    }
}

