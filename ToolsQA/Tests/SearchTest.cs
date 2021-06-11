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
    class SearchTest
    {
        private string _searchWord;
        private string _url;

        [Test]
        public void SearchOne()
        {
            _url = "https://pl.wikipedia.org/wiki/Wikipedia:Strona_g%C5%82%C3%B3wna";
            _searchWord = "Hitler";


            Driver.StartBrowser();
            Driver.OpenPage(_url);

            var wikiPage = new WikiPage();
            wikiPage.EnterSearchWord(_searchWord);
            wikiPage.HitSearchButton();
            Debug.Assert(Driver.DriverInstance.FindElement(By.CssSelector("[href*='/wiki/Kategoria:Strony_ujednoznaczniaj%C4%85ce']")).Displayed);

        }

        [Test]
        public void SearchMultiple()
        {
            _url = "https://pl.wikipedia.org/wiki/Wikipedia:Strona_g%C5%82%C3%B3wna";
            _searchWord = "cos";


            Driver.StartBrowser();
            Driver.OpenPage(_url);

            var wikiPage = new WikiPage();
            wikiPage.EnterSearchWord(_searchWord);
            wikiPage.HitSearchButton();

            Debug.Assert(Driver.DriverInstance.FindElement(By.CssSelector("[href*='/wiki/Kategoria:Strony_ujednoznaczniaj%C4%85ce']")).Displayed);
        }

    }
}
