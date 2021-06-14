using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace ToolsQA.Pages
{
    class LoginWikiPage : BasePage
    {
        [FindsBy(How = How.Id, Using = "wpName1")]
        public IWebElement UserName { get; set; }

        [FindsBy(How = How.Id, Using = "wpPassword1")]
        public IWebElement Password { get; set; }

        [FindsBy(How = How.Id, Using = "wpLoginAttempt")]
        public IWebElement LoginButton { get; set; }

        public LoginWikiPage() : base() { }
    }
}
