using NUnit.Framework;
using System.Threading;

namespace NUnitTestProject1
{
    public class Tests
    {
        private DriverHelper helper;

        [SetUp]
        public void Setup()
        {
            helper = new DriverHelper();
        }

        [TearDown]
        public void TearDown() 
        {
            helper.Quit();
        } 

        [TestCase("youtube")]
        [TestCase("yahoo")]

        public void IShouldBeAbleToEnterTextInSearchBoxGoogle(string test)
        {
            GoogleSearchPage googleSearchPage = new GoogleSearchPage(helper);
            googleSearchPage.EnterTextInSearchBar(test);
            Thread.Sleep(4 * 1000);
            Assert.True(!helper.GetPageSource().Contains("nu a returnat niciun document."));
        }

       
        public void IShouldBeAbleToEnterTextInSearchBoxYahoo(string test)
        {
            YahooSearchPage yahooSearchPage = new YahooSearchPage(helper);
            yahooSearchPage.EnterTextInSearchBar(test);
            Thread.Sleep(4 * 1000);
            Assert.True(!helper.GetPageSource().Contains("Nu am găsit rezultate pentru:"));
        }
    }
}