using System;
using System.Diagnostics;
using BoDi;
using NUnit.Framework;
using NUnit.Framework.Internal;
using OpenQA.Selenium;
using TechTalk.SpecFlow;
using WebKatalog2019.Helper;
using WebKatalog2019.Pages;

namespace WebKatalog2019
{
    [Binding]
    public class LoginToWebKatalogSteps
    {

        private IObjectContainer container;
        public IWebDriver Driver => container.Resolve<IWebDriver>();
        private LoginPage loginPage;
        private DashboardPage dashboardPage;
        private SeleniumHelper seleniumHelper;
        private WaitHelper waitHelper;
        private ScenarioContext scenarioContext;

        public LoginToWebKatalogSteps(IObjectContainer container, LoginPage loginPage, DashboardPage dashboardPage,SeleniumHelper seleniumHelper, WaitHelper waitHelper, ScenarioContext scenarioContext)
        {
            this.container = container;
            this.loginPage = loginPage;
            this.dashboardPage = dashboardPage;
            this.seleniumHelper = seleniumHelper;
            this.scenarioContext = scenarioContext;
            this.waitHelper = waitHelper;
        }

        [Given(@"the user has an open browser")]
        public void GivenTheUserHasAnOpenBrowser()
        {
            Assert.True(container != null);
        }
        
        [Given(@"the user is on the '(.*)' page")]
        public void GivenTheUserIsOnThePage(string pageType)
        {
            switch (pageType.ToLower())
            {
                case "login":
                    seleniumHelper.GoToPage(TestSettings.LoginPageUrl);
                    break;
                default:
                    seleniumHelper.GoToPage("google.pl");
                    break;
            }
        }
        
        [When(@"the user navigates to login page")]
        public void WhenTheUserNavigatesToLoginPage()
        {
            seleniumHelper.GoToPage(TestSettings.LoginPageUrl);
        }
        
        [When(@"the user enters '(.*)' in the login field")]
        public void WhenTheUserEntersInTheLoginField(string login)
        {
            loginPage.Login(login);
        }
        
        [When(@"the user enters '(.*)' in the password field")]
        public void WhenTheUserEntersInThePasswordField(string password)
        {
            loginPage.Password(password);
        }
        
        [When(@"the user clicks login button")]
        public void WhenTheUserClicksLoginButton()
        {
            loginPage.SubmitButton.Click();
        }
        
        [Then(@"the '(.*)' page should be displayed")]
        public void ThenThePageShouldBeDisplayed(string pageType)
        {
            string currentUrl = "";
            switch (pageType.ToLower())
            {
                case "login":
                    currentUrl = TestSettings.LoginPageUrl;
                    Assert.True(seleniumHelper.GetUrl() == currentUrl);
                    break;
                case "dashboard":
                    if (seleniumHelper.GetUrl().Contains("logowanie"))
                    {
                        Assert.Fail();
                    }
                    else
                    {
                        Assert.Pass();
                    }
                    break;
                default:
                    seleniumHelper.GoToPage("www.google.pl");
                    break;
            }
        }
        
        [Then(@"the logout button should be visible")]
        public void ThenTheLogoutButtonShouldBeVisible()
        {
            Assert.True(dashboardPage.LogoutButton.Enabled);
        }

        [Then(@"validation '(.*)' error should be displayed")]
        public void ThenValidationErrorShouldBeDisplayed(string validationType)
        {
            switch (validationType.ToLower())
            {
                case "any":
                    Assert.True(loginPage.NotSuccessfullLoginValidation.Count != 0 || loginPage.LoginValidationError.Count != 0 || loginPage.PasswordValidationError.Count != 0);
                    break;
                case "emptypassword":
                    Assert.True(loginPage.PasswordValidationError.Count != 0);
                    break;
                case "emptylogin":
                    Assert.True(loginPage.LoginValidationError.Count != 0);
                    break;
                case "badloginandpassword":
                    Assert.True(loginPage.NotSuccessfullLoginValidation.Count != 0);
                    break;
                case "emptyloginandpassword":
                    Assert.True(loginPage.LoginValidationError.Count != 0 || loginPage.PasswordValidationError.Count != 0);
                    break;
                default:
                    throw new Exception("Bad validationType included - check scenario type");
            }

        }


    }
}
