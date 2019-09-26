using System;
using System.Collections.Generic;
using System.Text;

namespace WebKatalog2019.Helper
{
    public class TestSettings
    {
        public static string MainPageUrl { get; set; } = "https://apbeta.webkatalog.pl/";
        public static string LoginPageUrl { get; set; } = MainPageUrl + "Account/Logowanie?ReturnUrl=/";
        public static string ArticlesPageUrl { get; set; } = MainPageUrl + "artykul";
        public static string DashboardPageUrl { get; set; } = MainPageUrl;

        public static TimeSpan TimeSpan = new TimeSpan(0,0,15);
    }
}
