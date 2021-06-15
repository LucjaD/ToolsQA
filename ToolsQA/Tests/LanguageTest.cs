using NUnit.Framework;
using ToolsQA.Pages;

namespace ToolsQA.Tests
{
    class LanguageTest
    {
        private WikiPage _wikiPage;

        [SetUp]
        public void SetUp()
        {
            BaseTest.StartBrowser();
            _wikiPage = new WikiPage();
        }

        [Test]
        public void ChangeLanguage()
        {
            _wikiPage.EnglishPage.Click();
         
            Assert.IsTrue(_wikiPage.GetElementChangeLanguageTest());
        }

        [TearDown]
        public void TearDownPage()
        {
            BaseTest.CloseBrowser();
        }
    }
}
