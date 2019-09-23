using System;
using System.Collections.Generic;
using System.Text;
using BoDi;
using OpenQA.Selenium;

namespace WebKatalog2019.Helper
{
    public class SeleniumHelper
    {
        private IWebDriver driver => container.Resolve<IWebDriver>();
        private IObjectContainer container;

        public SeleniumHelper(IObjectContainer container)
        {
            this.container = container;
        }

        public void GoToPage(string url)
        {
            driver.Navigate().GoToUrl(url);
        }

        public string GetUrl()
        {
            return driver.Url;
        }

        public bool Contains(string text)
        {
            return driver.PageSource.Contains(text);
        }


    }
}
