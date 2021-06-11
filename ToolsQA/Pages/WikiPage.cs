using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using ToolsQA.Selenium_Basics;

namespace ToolsQA.Pages
{
    class WikiPage
    {
        [FindsBy(How = How.CssSelector, Using = "[href*='/w/index.php?title=Specjalna:Zaloguj&returnto=Wikipedia%3AStrona+g%C5%82%C3%B3wna']")]
        private IWebElement _loginButton;

        [FindsBy(How = How.Id, Using = "searchInput")]
        private IWebElement _searchTextBox;

        [FindsBy(How = How.Id, Using = "searchButton")]
        private IWebElement _searchButton;

        [FindsBy(How = How.CssSelector, Using = "[href*='https://en.wikipedia.org/wiki/']")]
        private IWebElement _languageButton;

        public WikiPage()
        {
           
            PageFactory.InitElements(Driver.DriverInstance, this);
        }

        public void Login()
        {
            _loginButton.Click();
        }

        public void EnterSearchWord(string searchWord)
        {
            _searchTextBox.SendKeys(searchWord);
        }

        public void HitSearchButton()
        {
            _searchButton.Click();
        }

        public void ChangeLanguage()
        {
            _languageButton.Click();
        }
    }
}
