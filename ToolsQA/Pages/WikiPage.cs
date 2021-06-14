using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using ToolsQA.Selenium_Basics;

namespace ToolsQA.Pages
{
    class WikiPage : BasePage
    {
        [FindsBy(How = How.XPath, Using = "//a[contains(text(),'Zaloguj się')]")] 
        public IWebElement LoginButton { get; set; }
      
        [FindsBy(How = How.Id, Using = "searchInput")]
        public IWebElement SearchTextBox { get; set; }

        [FindsBy(How = How.Id, Using = "searchButton")]
        public IWebElement SearchButton { get; set; }

        [FindsBy(How = How.XPath, Using = "//a[@title='angielski']")]
        public IWebElement EnglishPage { get; set; }

        public WikiPage() : base()
        {
            Driver.OpenPage("https://pl.wikipedia.org/wiki/Wikipedia:Strona_g%C5%82%C3%B3wna");
        }

        public static WikiPage CreateInstance()
        {
            Driver.StartBrowser();
            return new WikiPage();
        }

        public static void CloseBrowser()
        {
            Driver.CloseBrowser();
        }

        public IWebElement GetElementLoginTest()
        {
            return Driver.DriverInstance.FindElement(By.CssSelector("[href*='/w/index.php?title=Specjalna:Strona_domowa&source=personaltoolslink&namespace=4']"));
        }

        public IWebElement GetElementSearchTest()
        {
            return Driver.DriverInstance.FindElement(By.CssSelector("[href*='/wiki/Kategoria:Strony_ujednoznaczniaj%C4%85ce']"));
        }

        public bool GetElementChangeLanguageTest()
        {
            return Driver.DriverInstance.Url.Contains("en.wikipedia.org");
        }
    }

}
