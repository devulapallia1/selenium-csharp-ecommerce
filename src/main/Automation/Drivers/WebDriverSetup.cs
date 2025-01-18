using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Automation.Drivers
{
    public static class WebDriverSetup
    {
        public static IWebDriver InitializeDriver()
        {
            var options = new ChromeOptions();
            options.AddArgument("--start-maximized");
            return new ChromeDriver(options);
        }
    }
}
