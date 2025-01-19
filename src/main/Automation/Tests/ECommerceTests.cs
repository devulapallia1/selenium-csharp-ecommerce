using Automation.Drivers;
using Automation.Pages;
using NUnit.Framework;

namespace Automation.Tests
{
    public class ECommerceTests
    {
        private IWebDriver _driver;
        private HomePage _homePage;
        private SearchResultsPage _searchResultsPage;
        private ProductPage _productPage;
        private CartPage _cartPage;
        private CheckoutPage _checkoutPage;

        [SetUp]
        public void Setup()
        {
            _driver = WebDriverSetup.InitializeDriver();
            _driver.Navigate().GoToUrl("https://example-ecommerce.com");
            _homePage = new HomePage(_driver);
            _searchResultsPage = new SearchResultsPage(_driver);
            _productPage = new ProductPage(_driver);
            _cartPage = new CartPage(_driver);
            _checkoutPage = new CheckoutPage(_driver);
        }

        [Test]
        public void CompletePurchaseWorkflowTest()
        {
            _homePage.SearchForProduct("Laptop");
            _searchResultsPage.SelectFirstProduct();
            _productPage.AddToCart();
            _cartPage.ProceedToCheckout();
            _checkoutPage.PlaceOrder();

            Assert.IsTrue(_checkoutPage.IsOrderSuccessful(), "Order placement failed!");
        }

        [TearDown]
        public void Teardown()
        {
            _driver.Quit();
        }
    }
}
