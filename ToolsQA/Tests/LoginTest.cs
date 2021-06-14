using NUnit.Framework;
using OpenQA.Selenium;
using System.Diagnostics;
using ToolsQA.Pages;
using ToolsQA.Selenium_Basics;

namespace ToolsQA.Tests
{
    class LoginTest
    {
        Cridentials cridentials = new Cridentials();

        [Test]
        public void CorrectLogin()
        {
            cridentials._username = "Testowanie1";
            cridentials._password = "Testy123";

            var wikiPage = WikiPage.CreateInstance();
            wikiPage.LoginButton.Click();

            var loginWikiPage = new LoginWikiPage();
            cridentials.Login(loginWikiPage);

            Debug.Assert(wikiPage.GetElementLoginTest().Text.Contains(cridentials._username));
            WikiPage.CloseBrowser();
        }

        [Test]
        public void IncorrectLogin()
        {
            cridentials._username = "Dupa";
            cridentials._password = "Dupa";

            var wikiPage = WikiPage.CreateInstance();
            wikiPage.LoginButton.Click();

            var loginWikiPage = new LoginWikiPage();
            cridentials.Login(loginWikiPage);

            Debug.Assert(wikiPage.GetElementLoginTest().Text.Contains(cridentials._username));
            WikiPage.CloseBrowser();
        }
    }
}



