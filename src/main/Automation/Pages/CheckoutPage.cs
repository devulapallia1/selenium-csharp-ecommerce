using OpenQA.Selenium;

namespace Automation.Pages
{
    public class CheckoutPage
    {
        private readonly IWebDriver _driver;

        public CheckoutPage(IWebDriver driver)
        {
            _driver = driver;
        }

        private IWebElement PlaceOrderButton => _driver.FindElement(By.Id("place-order"));
        private IWebElement ConfirmationMessage => _driver.FindElement(By.Id("confirmation"));

        public void PlaceOrder()
        {
            PlaceOrderButton.Click();
        }

        public bool IsOrderSuccessful()
        {
            return ConfirmationMessage.Displayed;
        }
    }
}
