using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;

namespace WebKatalog2019.Driver
{
    public class WebDriverSingleton
    {

        public static IWebDriver driver;
        public static IWebDriver getInstance()
        {
            if (driver == null)
            {
                driver = new ChromeDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location));
            }
            return driver;
        }

    }

}
