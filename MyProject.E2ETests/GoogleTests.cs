using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace MyProject.E2ETests;

public class GoogleTests : IDisposable
{
    private readonly IWebDriver _driver;

    public GoogleTests()
    {
        _driver = new ChromeDriver();
    }

    [Fact]
    public void OpenGoogle_ShouldHaveCorrectTitle()
    {
        // Open browser
        _driver.Navigate().GoToUrl("https://www.google.com");

        // Verify title
        Assert.Contains("Google", _driver.Title);
    }

    public void Dispose()
    {
        _driver.Quit();
    }
}