using System;
using System.Collections.Generic;
using System.Text;
using BoDi;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace WebKatalog2019.Pages
{
    public class DashboardPage
    {
        [FindsBy(How = How.Id, Using = "logoutForm")]
        public IWebElement LogoutButton { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#bs-example-navbar-collapse-1 > ul > li.visible-lg.dropdown > a.dropdown-toggle > i")]
        public IWebElement OrderDropdownArrow { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#bs-example-navbar-collapse-1 > ul > li.visible-lg.dropdown.open > ul > li > div.podglad-koszyka-btn > div.btn.btn-czarny.widget-zamowienia-btn-nowe")]
        public IWebElement NewOrderButton { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#bs-example-navbar-collapse-1 > ul > li.visible-lg.dropdown.open > ul > li > div.podglad-koszyka-btn > div.btn.btn-czarny.widget-zamowienia-btn-realizuj")]
        public IWebElement CompleteOrderButton { get; set; }

        [FindsBy(How = How.CssSelector, Using = "body > div.sweet-alert.showSweetAlert.visible > div.sa-button-container > div > button")]
        public IWebElement OkOrderButton { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#szukaj-wg-numeru-index > div:nth-child(5) > label")]
        public IWebElement CatNumberButton { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#szukajWgNumeru")]
        public IWebElement SearchField { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#szukaj-wg-numeru-index > div.input-group > div > button > i")]
        public IWebElement SearchButton { get; set; }

        [FindsBy(How = How.Id, Using = "wyszukiwarka_rd_0")]
        public IWebElement CatalogueNumber { get; set; }

        private IWebDriver driver;
        public DashboardPage(IObjectContainer container)
        {
            driver = container.Resolve<IWebDriver>();
            PageFactory.InitElements(driver, this);
        }






    }
}
