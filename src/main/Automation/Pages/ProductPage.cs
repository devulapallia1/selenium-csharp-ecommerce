using OpenQA.Selenium;

namespace Automation.Pages
{
    public class ProductPage
    {
        private readonly IWebDriver _driver;

        public ProductPage(IWebDriver driver)
        {
            _driver = driver;
        }

        private IWebElement AddToCartButton => _driver.FindElement(By.Id("add-to-cart"));

        public void AddToCart()
        {
            AddToCartButton.Click();
        }
    }
}
