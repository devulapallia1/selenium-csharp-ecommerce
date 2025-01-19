using OpenQA.Selenium;

namespace Automation.Pages
{
    public class CartPage
    {
        private readonly IWebDriver _driver;

        public CartPage(IWebDriver driver)
        {
            _driver = driver;
        }

        private IWebElement CheckoutButton => _driver.FindElement(By.Id("checkout"));

        public void ProceedToCheckout()
        {
            CheckoutButton.Click();
        }
    }
}
