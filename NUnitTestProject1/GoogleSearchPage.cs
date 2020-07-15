using OpenQA.Selenium;

namespace NUnitTestProject1
{
    public class GoogleSearchPage
    {
        DriverHelper driverHelper;

        static string baseURL = "https://www.google.com/";

        public GoogleSearchPage(DriverHelper H)
        {
            driverHelper = H;
        }

        public void EnterTextInSearchBar(string input)
        {
            driverHelper.Navigate(baseURL);
            IWebElement searchBox = driverHelper.FindElementByName("q");
            searchBox.SendKeys(input);
            searchBox.SendKeys(Keys.Enter);
        }

    }
}
