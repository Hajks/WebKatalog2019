using System;
using System.Collections.Generic;
using System.Text;

namespace WebKatalog2019.Helper
{
    public class TestSettings
    {
        public static string MainPage { get; set; } = "https://apbeta.webkatalog.pl/";
        public static string LoginPageUrl { get; set; } = MainPage + "Account/Logowanie?ReturnUrl=/";
        public static string ArticlesPageUrl { get; set; } = MainPage + "artykul";

        public static TimeSpan TimeSpan = new TimeSpan(0,0,15);
    }
}
