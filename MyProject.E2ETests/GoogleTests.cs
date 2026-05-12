using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Xunit;

namespace MyProject.E2ETests
{
    public class GoogleTests : IDisposable
    {
        private readonly IWebDriver driver;

        public GoogleTests()
        {
            var options = new ChromeOptions();

            options.AddArgument("--headless");
            options.AddArgument("--no-sandbox");
            options.AddArgument("--disable-dev-shm-usage");
            options.AddArgument("--remote-allow-origins=*");

            driver = new ChromeDriver(options);
        }

        [Fact]
        public void OpenGoogle_ShouldHaveCorrectTitle()
        {
            driver.Navigate().GoToUrl("https://www.google.com");

            Assert.Contains("Google", driver.Title);
        }

        public void Dispose()
        {
            driver.Quit();
            driver.Dispose();
        }
    }
}