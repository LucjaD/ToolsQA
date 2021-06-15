using NUnit.Framework;
using ToolsQA.Pages;

namespace ToolsQA.Tests
{
    class LanguageTest : BaseTest
    {
        [Test]
        public void ChangeLanguage()
        {
            WikiPage.EnglishPage.Click();
         
            Assert.IsTrue(WikiPage.CheckPageUrl());
        }
    }
}
