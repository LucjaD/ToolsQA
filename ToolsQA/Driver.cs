using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;

namespace ToolsQA.Selenium_Basics
{
    public static class Driver
    {
        private static IWebDriver _driver;

        public static IWebDriver DriverInstance{ get => _driver; }

        public static void StartBrowser()
        {
            Driver._driver = new FirefoxDriver();
        }

        public static void OpenPage(string url)
        {
            Driver._driver.Url = url;
        }

        public static void CloseBrowser()
        {
            _driver.Close();
        }
    }
}
