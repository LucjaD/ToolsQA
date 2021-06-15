using NUnit.Framework;
using ToolsQA.Pages;

namespace ToolsQA.Tests
{
    class SearchTest : BaseTest
    {
        [Test]
        public void SearchOne()
        {
            WikiPage.SearchTextBox.SendKeys("Hitler");
            WikiPage.SearchButton.Click();

            Assert.IsFalse(WikiPage.GetSearchInfo().Displayed);
        }

        [Test]
        public void SearchMultiple()
        {
            WikiPage.SearchTextBox.SendKeys("cos");
            WikiPage.SearchButton.Click();

            Assert.IsTrue(WikiPage.GetSearchInfo().Displayed);
        }
    }
}
