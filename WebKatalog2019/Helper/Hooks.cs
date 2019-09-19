using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Text;
using BoDi;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using TechTalk.SpecFlow;
using WebKatalog2019.Pages;

namespace WebKatalog2019.Helper
{

    [Binding]
    public sealed class Hooks
    {
        private IObjectContainer container;
        public IWebDriver Driver => container.Resolve<IWebDriver>();

        private SeleniumHelper seleniumHelper;
        public Hooks(IObjectContainer container)
        {
            this.container = container;
        }

        [BeforeScenario]
        public void BeforeScenario()
        {
            var driver = new ChromeDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location));
            container.RegisterInstanceAs<IWebDriver>(driver);
        }

        [BeforeScenario("LoginUser")]
        public void LoginUser()
        {
            var driver = container.Resolve<IWebDriver>();
            driver.Navigate().GoToUrl(TestSettings.LoginPageUrl);
            LoginPage loginPage = new LoginPage(container);
            loginPage.LoginTextBox.SendKeys("demo12");
            loginPage.PasswordTextBox.SendKeys("demo12");
            loginPage.SubmitButton.Click();
        }

        [AfterScenario]
        public void AfterScenario()
        {
            var driver = container.Resolve<IWebDriver>();
            driver.Close();
            driver.Dispose();
            container.Dispose();
        }
    }
}
