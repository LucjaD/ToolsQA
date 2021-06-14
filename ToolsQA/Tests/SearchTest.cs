using NUnit.Framework;
using OpenQA.Selenium;
using System.Diagnostics;
using ToolsQA.Pages;
using ToolsQA.Selenium_Basics;

namespace ToolsQA.Tests
{
    class SearchTest
    {
        [Test]
        public void SearchOne()
        {
            var wikiPage = WikiPage.CreateInstance();
            wikiPage.SearchTextBox.SendKeys("Hitler");
            wikiPage.SearchButton.Click();

            Debug.Assert(wikiPage.GetElementSearchTest().Displayed);
            WikiPage.CloseBrowser();
        }

        [Test]
        public void SearchMultiple()
        {
            var wikiPage = WikiPage.CreateInstance();

            wikiPage.SearchTextBox.SendKeys("cos");
            wikiPage.SearchButton.Click();

            Debug.Assert(wikiPage.GetElementSearchTest().Displayed);
            WikiPage.CloseBrowser();
        }
    }
}
