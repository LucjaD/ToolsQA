using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using ToolsQA.Pages;
using ToolsQA.Selenium_Basics;

namespace ToolsQA.Tests
{
    class LoginTest 
    {
        private string _username;
        private string _password;
        private string _url;

        [Test]
        public void CorrectLogin()
        {
            _url = "https://pl.wikipedia.org/wiki/Wikipedia:Strona_g%C5%82%C3%B3wna";
            _username = "";
            _password = "";
            Driver.StartBrowser();
            Driver.OpenPage(_url);

            var wikiPage = new WikiPage();
            wikiPage.Login();

            var loginWikiPage = new LoginWikiPage();
            loginWikiPage.EnterUsername(_username);
            loginWikiPage.EnterPassword(_password);
            loginWikiPage.LoginButtonClick();


            Debug.Assert(Driver.DriverInstance.FindElement(By.CssSelector("[href*='/w/index.php?title=Specjalna:Strona_domowa&source=personaltoolslink&namespace=4']")).
            Text.Contains(_username));
        }

        [Test]
        public void IncorrectLogin()
        {
            _url = "https://pl.wikipedia.org/wiki/Wikipedia:Strona_g%C5%82%C3%B3wna";
            _username = "Dupa";
            _password = "Dupa";
            Driver.StartBrowser();
            Driver.OpenPage(_url);

            var wikiPage = new WikiPage();
            wikiPage.Login();

            var loginWikiPage = new LoginWikiPage();
            loginWikiPage.EnterUsername(_username);
            loginWikiPage.EnterPassword(_password);
            loginWikiPage.LoginButtonClick();


            Debug.Assert(Driver.DriverInstance.FindElement(By.CssSelector("[href*='/w/index.php?title=Specjalna:Strona_domowa&source=personaltoolslink&namespace=4']")).
            Text.Contains(_username));

        }
    }
}



