using Xunit;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

public class AutomatedTest
{
    public IWebDriver driver;

    [Fact]
    public void CssDemo()
    {
        ChromeOptions options = new ChromeOptions();
        options.AddArgument("tests-type");

        using(var driver = new ChromeDriver(options))
        {
            driver.Url = "http://demo.guru99.com/test/guru99home";
            driver.Manage().Window.Maximize();

            IWebElement emailTextBox = driver.FindElementById("philadelphia-field-email");
            IWebElement signupButton = driver.FindElementById("philadelphia-field-submit");

            emailTextBox.SendKeys("ddd@test.com");
            signupButton.Click();

        }
    }

    [Fact]
    public void CssDemo2()
    {

    }
}