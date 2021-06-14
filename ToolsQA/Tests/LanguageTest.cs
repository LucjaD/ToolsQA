using NUnit.Framework;
using System.Diagnostics;
using ToolsQA.Pages;
using ToolsQA.Selenium_Basics;

namespace ToolsQA.Tests
{
    class LanguageTest
    {
        [Test]
        public void ChangeLanguage()
        {
            var wikiPage = WikiPage.CreateInstance();
            wikiPage.EnglishPage.Click();
         
            Debug.Assert(wikiPage.GetElementChangeLanguageTest());
            WikiPage.CloseBrowser();
        }
    }
}
