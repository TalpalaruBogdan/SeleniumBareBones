using OpenQA.Selenium;

namespace NUnitTestProject1
{
    public class YahooSearchPage
    {
        DriverHelper driverHelper;

        static string baseURL = "https://ro.yahoo.com/?p=us";

        public YahooSearchPage(DriverHelper YH)
        {
            driverHelper = YH;
        }

        public void EnterTextInSearchBar(string input)
        {
            driverHelper.Navigate(baseURL);
            IWebElement searchBox = driverHelper.FindElementByID("header-search-input");
            searchBox.SendKeys(input);
            searchBox.SendKeys(Keys.Enter);
        }

    }
}
