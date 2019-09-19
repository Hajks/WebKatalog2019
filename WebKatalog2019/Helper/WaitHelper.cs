using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.PageObjects;

namespace WebKatalog2019.Helper
{
    public class WaitHelper
    {
        private IWebDriver driver;
        public WaitHelper(IWebDriver driver)
        {
            this.driver = driver;
        }

        public WebDriverWait Wait() => new WebDriverWait(driver, TestSettings.TimeSpan);

        public void WaitForClickable(IWebElement element)
        {
            Wait().Until(ExpectedConditions.ElementToBeClickable(element));
        }
    }
}
