using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.IO;

namespace NUnitTestProject1
{
    public class DriverHelper
    {
        private IWebDriver driver;
        public DriverHelper()
        {
            driver = new ChromeDriver(Path.Combine(Directory.GetCurrentDirectory(), "../../../Resources" ));
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
        }

        public void Navigate(string url)
        {
            driver.Navigate().GoToUrl(url);
        }

        internal IWebElement FindElementByName(string v)
        {
            return driver.FindElement(By.Name(v));
        }
        internal IWebElement FindElementByID(string id)
        {
            return driver.FindElement(By.Id(id));
        }
        public string GetPageSource()
        {
            return driver.PageSource;
        }

        public void Quit()
        {
            driver.Quit();
        }
    }
}