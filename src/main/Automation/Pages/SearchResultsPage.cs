using OpenQA.Selenium;

namespace Automation.Pages
{
    public class SearchResultsPage
    {
        private readonly IWebDriver _driver;

        public SearchResultsPage(IWebDriver driver)
        {
            _driver = driver;
        }

        private IWebElement FirstProduct => _driver.FindElement(By.CssSelector(".product-item:first-child"));

        public void SelectFirstProduct()
        {
            FirstProduct.Click();
        }
    }
}
