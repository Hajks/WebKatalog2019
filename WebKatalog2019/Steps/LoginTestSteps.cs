using System;
using System.IO;
using System.Reflection;
using System.Threading;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using TechTalk.SpecFlow;

namespace WebKatalog2019
{
    [Binding]
    public class LoginTestSteps
    {
        private IWebDriver _driver;

        [Given(@"I Navigate to the Login page '(.*)'")]
        public void GivenINavigateToTheLoginPage(string LoginPageUrl)
        {
            _driver = new ChromeDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location));
            _driver.Manage().Window.Maximize();
            _driver.Url = LoginPageUrl;
        }
        
        [When(@"I Login with Username '(.*)' and Password '(.*)' on the Login Page")]
        public void WhenILoginWithUsenameAndPasswordOnTheLoginPage(string Login, string Password)
        {
            IWebElement LoginTextBox = _driver.FindElement(By.XPath("//*[@id='LoginInput']"));
            LoginTextBox.SendKeys(Login);
            IWebElement PasswordTextBox = _driver.FindElement(By.XPath("//*[@id='HasloInput']"));
            PasswordTextBox.SendKeys(Password);
            _driver.FindElement(By.XPath("//*[@id='panelLogowaniaContainer']/div[2]/form/input[2]")).Click();
        }

        [Then(@"the page should contain element like this '(.*)'")]
        public void ThenThePageShouldContainElementLikeThis(string TextToFind)
        {
            Assert.True(_driver.PageSource.Contains(TextToFind));
        }

        [AfterScenario]
        public void CloseBrowser()
        {
            _driver.Dispose();
        }
    }
}
