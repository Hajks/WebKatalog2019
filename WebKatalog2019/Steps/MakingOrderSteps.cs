using System;
using System.IO;
using System.Reflection;
using System.Threading;
using BoDi;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using TechTalk.SpecFlow;
using WebKatalog2019.Helper;
using WebKatalog2019.Pages;

namespace WebKatalog2019
{
    [Binding]
    public class MakingOrderSteps
    {
        private IWebDriver _driver;
        //private string orderNumber;

        private IObjectContainer container;
        public IWebDriver Driver => container.Resolve<IWebDriver>();
        private DashboardPage dashboardPage;
        private ItemsPage itemsPage;
        private SeleniumHelper seleniumHelper;
        private WaitHelper waitHelper;
        private ScenarioContext scenarioContext;

        public MakingOrderSteps(IObjectContainer container, DashboardPage dashboardPage, ItemsPage itemsPage, SeleniumHelper seleniumHelper, WaitHelper waitHelper, ScenarioContext scenarioContext)
        {
            this.container = container;
            this.dashboardPage = dashboardPage;
            this.itemsPage = itemsPage;
            this.seleniumHelper = seleniumHelper;
            this.scenarioContext = scenarioContext;
            this.waitHelper = waitHelper;
        }

        [Given(@"I make sure that im on the test page")]
        public void GivenIMakeSureThatImOnThePage()
        {
            if (seleniumHelper.GetUrl() != TestSettings.ArticlesPageUrl)
            {
                seleniumHelper.GoToPage(TestSettings.ArticlesPageUrl);
            }
        }

        [Given(@"I search for another item '(.*)'")]
        public void GivenISearchForAnotherItem(string itemNumber)
        {

            itemsPage.SearchField.Clear();
            itemsPage.SearchField.SendKeys(itemNumber);
            itemsPage.SearchButton.Click();
        }


        [Given(@"I make new order")]
        public void GivenIMakeNewOrder()
        {
            dashboardPage.OrderDropdownArrow.Click();
            dashboardPage.NewOrderButton.Click();
            Thread.Sleep(1000);
            dashboardPage.OkOrderButton.Click();

            //string OrderText = _driver.FindElement(By.CssSelector("body > div.sweet-alert.showSweetAlert.visible > p")).Text;
            //orderNumber = OrderText.Substring(OrderText.LastIndexOf(':') + 1).Replace(" ", string.Empty);

        }

        [Given(@"I search for specific item with specific '(.*)' number '(.*)'")]
        public void GivenISearchForSpecificItemWithSpecificNumber(string typeOfSearch, string itemNumberToBeFound)
        {
            switch (typeOfSearch.ToLower())
            {
                case "numer katalogowy":
                    dashboardPage.CatalogueNumber.Click();
                    break;
                default:
                    break;
            }

            dashboardPage.CatNumberButton.Click();
            dashboardPage.SearchField.SendKeys(itemNumberToBeFound); //SendKeys or ownmethod?
            dashboardPage.SearchButton.Click();

        }

        [Given(@"I search and add some items:")]
        public void GivenISearchAndAddSomeItems(Table table)
        {
            
        }


        [Given(@"I add item with number '(.*)' to order with amounts of : fv '(.*)', par '(.*)', WZ '(.*)'")]
        public void GivenIAddItemToOrderWithAmountsOfFvParWZ(string itemNumberToBeFound, string fvAmount, string parAmount, string wzAmount)
        {

            itemsPage.PreOrderButton(itemNumberToBeFound).Click();

            itemsPage.FvField.Clear();
            itemsPage.FvField.SendKeys(fvAmount);

            itemsPage.ParField.Clear();
            itemsPage.ParField.SendKeys(parAmount);

            itemsPage.WzField.Clear();
            itemsPage.WzField.SendKeys(wzAmount);

            itemsPage.AddToOrderButton.Click();

        }

        [When(@"I go to order summary")]
        public void WhenIGoToOrderSummary()
        {
            Thread.Sleep(1000);
            dashboardPage.OrderDropdownArrow.Click();
            Thread.Sleep(1000);
            dashboardPage.CompleteOrderButton.Click();
        }

        [Then(@"I should see list of items with a correct sum value")]
        public void ThenIShouldSeeListOfItemsWithACorrectSumValue()
        {

        }
    }
}
