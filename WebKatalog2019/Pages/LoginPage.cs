using System;
using System.Collections.Generic;
using System.Text;
using BoDi;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;


namespace WebKatalog2019.Pages
{
    public class LoginPage
    {
        [FindsBy(How = How.Id,Using = "LoginInput")]
        public IWebElement LoginTextBox { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='HasloInput']")]
        public IWebElement PasswordTextBox { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='panelLogowaniaContainer']/div[2]/form/input[2]")]
        public IWebElement SubmitButton { get; set; }

        [FindsBy(How = How.Id, Using = "LoginInput-error")]
        public IList<IWebElement> LoginValidationError { get; set; }

        [FindsBy(How = How.Id, Using = "HasloInput-error")]
        public IList<IWebElement> PasswordValidationError { get; set; }

        [FindsBy(How = How.XPath, Using = "//li[contains(text(),'zalogowa')]")]
        public IList <IWebElement> NotSuccessfullLoginValidation { get; set; }
        

        private IWebDriver driver;
        public LoginPage(IObjectContainer container)
        {
            driver = container.Resolve<IWebDriver>();
            PageFactory.InitElements(driver, this);
        }
       public void Login(string login)
        {
            LoginTextBox.SendKeys(login);
        }
        public void Password (string password)
        {
            PasswordTextBox.SendKeys(password);
        }



    }
}
