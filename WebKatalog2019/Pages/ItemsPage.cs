using System;
using System.Collections.Generic;
using System.Text;
using BoDi;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace WebKatalog2019.Pages
{
    public class ItemsPage
    {
        public IWebElement PreOrderButton(string itemCode)
        {
            return driver.FindElement(By.XPath(String.Format("//*[@data-val-symbol='{0}']", itemCode.ToUpper())));
        }

        [FindsBy(How = How.Id, Using = "addIloscFV")]
        public IWebElement FvField { get; set; }

        [FindsBy(How = How.Id, Using = "addIloscPar")]
        public IWebElement ParField { get; set; }

        [FindsBy(How = How.Id, Using = "addIloscWZ")]
        public IWebElement WzField { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='addPositionWindow']/div/div/div[3]/button[1]")]
        public IWebElement AddToOrderButton { get; set; }

        [FindsBy(How = How.Id, Using = "szukajWgNumeru")]
        public IWebElement SearchField { get; set; }

        [FindsBy(How = How.Id, Using = "szukajWgNumeruBtnSzukaj")]
        public IWebElement SearchButton { get; set; }

        private IWebDriver driver;
        public ItemsPage(IObjectContainer container)
        {
            driver = container.Resolve<IWebDriver>();
            PageFactory.InitElements(driver, this);
        }
    }
}
