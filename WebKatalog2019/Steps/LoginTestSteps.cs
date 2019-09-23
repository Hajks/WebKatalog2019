using System;
using System.IO;
using System.Reflection;
using System.Threading;
using BoDi;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using TechTalk.SpecFlow;
using WebKatalog2019.Helper;
using WebKatalog2019.Pages;

namespace WebKatalog2019
{
    [Binding]
    public sealed class LoginTestSteps
    {

        private IObjectContainer container;
        public IWebDriver Driver => container.Resolve<IWebDriver>();
        private LoginPage loginPage;
        private SeleniumHelper seleniumHelper;
        private WaitHelper waitHelper;
        private ScenarioContext scenarioContext;

        public LoginTestSteps(IObjectContainer container, LoginPage loginPage, SeleniumHelper seleniumHelper, WaitHelper waitHelper, ScenarioContext scenarioContext)
        {
            this.container = container;
            this.loginPage = loginPage;
            this.seleniumHelper = seleniumHelper;
            this.scenarioContext = scenarioContext;
            this.waitHelper = waitHelper;
        }

        [Given(@"I navigate to the login page")]
        public void GivenINavigateToTheLoginPage()
        {
            seleniumHelper.GoToPage(TestSettings.LoginPageUrl);
        }

        [When(@"I Login with Username '(.*)' and Password '(.*)' on the Login Page")]
        public void WhenILoginWithUsenameAndPasswordOnTheLoginPage(string Login, string Password)
        {
            loginPage.Login(Login);
            loginPage.Password(Password);
            loginPage.SubmitButton.Click();
        }

        [Then(@"the page should contain element like this '(.*)'")]
        public void ThenThePageShouldContainElementLikeThis(string TextToFind)
        {
            Assert.True(seleniumHelper.Contains(TextToFind));
        }


    }
}
