using OpenQA.Selenium;

namespace Automation.Pages
{
    public class HomePage
    {
        private readonly IWebDriver _driver;

        public HomePage(IWebDriver driver)
        {
            _driver = driver;
        }

        private IWebElement SearchBox => _driver.FindElement(By.Id("search-input"));
        private IWebElement SearchButton => _driver.FindElement(By.Id("search-button"));

        public void SearchForProduct(string productName)
        {
            SearchBox.SendKeys(productName);
            SearchButton.Click();
        }
    }
}
