using System;
using System.IO;
using System.Reflection;
using System.Threading;
using WebKatalog2019.Driver;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using TechTalk.SpecFlow;

namespace WebKatalog2019
{
    [Binding]
    public class MakingOrderSteps
    {
        IWebDriver _driver = WebDriverSingleton.getInstance();
        private string orderNumber;

        [Given(@"I Login with Username '(.*)' and Password '(.*)' on the Login Page")]
        public void GivenILoginWithUsernameAndPasswordOnTheLoginPage(string Login, string Password)
        {
            IWebElement LoginTextBox = _driver.FindElement(By.XPath("//*[@id='LoginInput']"));
            LoginTextBox.SendKeys(Login);
            IWebElement PasswordTextBox = _driver.FindElement(By.XPath("//*[@id='HasloInput']"));
            PasswordTextBox.SendKeys(Password);
            _driver.FindElement(By.XPath("//*[@id='panelLogowaniaContainer']/div[2]/form/input[2]")).Click();
        }

            [Given(@"I make sure that im on the page '(.*)'")]
            public void GivenIMakeSureThatImOnThePage(string CorrectUrl)
            {
                if (_driver.Url != CorrectUrl)
                {
                    _driver.Navigate().GoToUrl(CorrectUrl);
                }
            }

            [Given(@"I make new order")]
        public void GivenIMakeNewOrder()
        {
            Thread.Sleep(1000);
            IWebElement OrderDropdownArrow = _driver.FindElement(By.CssSelector("#bs-example-navbar-collapse-1 > ul > li.visible-lg.dropdown > a.dropdown-toggle > i"));
            OrderDropdownArrow.Click();
            IWebElement NewOrderButton = _driver.FindElement(By.CssSelector("#bs-example-navbar-collapse-1 > ul > li.visible-lg.dropdown.open > ul > li > div.podglad-koszyka-btn > div.btn.btn-czarny.widget-zamowienia-btn-nowe"));
            NewOrderButton.Click();
            Thread.Sleep(1000);
            string OrderText = _driver.FindElement(By.CssSelector("body > div.sweet-alert.showSweetAlert.visible > p")).Text;
            orderNumber = OrderText.Substring(OrderText.LastIndexOf(':') + 1).Replace(" ", string.Empty);

            IWebElement OkButton = _driver.FindElement(By.CssSelector("body > div.sweet-alert.showSweetAlert.visible > div.sa-button-container > div > button"));
            OkButton.Click();

        }

        [Given(@"I search for specific item with specific '(.*)' number '(.*)'")]
        public void GivenISearchForSpecificItemWithSpecificNumber(string typeOfSearch, string itemNumberToBeFound)
        {
            switch (typeOfSearch.ToLower())
            {
                case "numer katalogowy":
                    _driver.FindElement(By.CssSelector("#szukaj-wg-numeru-index > div:nth-child(5) > label")).Click();
                    break;
                default:
                    break;
            }

            IWebElement CatNumberButton = _driver.FindElement(By.CssSelector("#szukaj-wg-numeru-index > div:nth-child(5) > label"));
            CatNumberButton.Click();

            IWebElement SearchingField = _driver.FindElement(By.CssSelector("#szukajWgNumeru"));
            SearchingField.SendKeys(itemNumberToBeFound);

            IWebElement SearchButton = _driver.FindElement(By.CssSelector("#szukaj-wg-numeru-index > div.input-group > div > button > i"));
            SearchButton.Click();


        }

        [Given(@"I add item with number '(.*)' to order with amounts of : fv '(.*)', par '(.*)', WZ '(.*)'")]
        public void GivenIAddItemToOrderWithAmountsOfFvParWZ(string itemNumberToBeFound, string fvAmount, string parAmount, string wzAmount)
        {
            IWebElement PreOrderButton = _driver.FindElement(By.XPath("//*[@data-val-symbol='CT848']"));
            PreOrderButton.Click();

            IWebElement fvField = _driver.FindElement(By.Id("addIloscFV"));
            fvField.Clear();
            fvField.SendKeys(fvAmount);

            IWebElement parField = _driver.FindElement(By.Id("addIloscPar"));
            parField.Clear();
            parField.SendKeys(parAmount);

            IWebElement wzField = _driver.FindElement(By.Id("addIloscWZ"));
            wzField.Clear();
            wzField.SendKeys(wzAmount);

            IWebElement AddToOrderButton = _driver.FindElement(By.XPath("//*[@id='addPositionWindow']/div/div/div[3]/button[1]"));
            AddToOrderButton.Click();
        }

        [When(@"I go to order summary")]
        public void WhenIGoToOrderSummary()
        {
            Thread.Sleep(1000);
            IWebElement OrderDropdownArrow = _driver.FindElement(By.CssSelector("#bs-example-navbar-collapse-1 > ul > li.visible-lg.dropdown > a.dropdown-toggle > i"));
            OrderDropdownArrow.Click();                                             

            IWebElement CompleteOrderButton = _driver.FindElement(By.CssSelector("#bs-example-navbar-collapse-1 > ul > li.visible-lg.dropdown.open > ul > li > div.podglad-koszyka-btn > div.btn.btn-czarny.widget-zamowienia-btn-realizuj"));
            CompleteOrderButton.Click();                                    
        }

        [Then(@"I should see list of items with a correct sum value")]
        public void ThenIShouldSeeListOfItemsWithACorrectSumValue()
        {

        }
    }
}
