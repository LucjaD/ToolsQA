using NUnit.Framework;
using ToolsQA.Pages;

namespace ToolsQA.Tests
{
    class SearchTest 
    {
        private WikiPage _wikiPage;

        [SetUp]
        public void SetUp()
        {
            BaseTest.StartBrowser();
            _wikiPage = new WikiPage();
        }

        [Test]
        public void SearchOne()
        {
            _wikiPage.SearchTextBox.SendKeys("Hitler");
            _wikiPage.SearchButton.Click();

            Assert.IsFalse(_wikiPage.GetElementSearchTest().Displayed);
        }

        [Test]
        public void SearchMultiple()
        {
            _wikiPage.SearchTextBox.SendKeys("cos");
            _wikiPage.SearchButton.Click();

            Assert.IsTrue(_wikiPage.GetElementSearchTest().Displayed);
        }

        [TearDown]
        public void TearDownPage()
        {
            BaseTest.CloseBrowser();
        }
    }
}
