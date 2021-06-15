using NUnit.Framework;
using ToolsQA.Pages;

namespace ToolsQA.Tests
{
    class LoginTest
    {
        private WikiPage _wikiPage;
        private const string _userName = "Testowanie1";
        private const string _password = "Testy123";

        [SetUp]
        public void SetUp()
        {
            BaseTest.StartBrowser();
            _wikiPage = new WikiPage();
        }

        [Test]
        public void CorrectLogin()
        {
            _wikiPage.LoginButton.Click();

            var loginWikiPage = new LoginWikiPage();
            loginWikiPage.Login(new User(_userName, _password));

            Assert.IsFalse(_wikiPage.GetElementLoginTest("Wyloguj").Displayed);
        }

        [Test]
        public void IncorrectLogin()
        {
            _wikiPage.LoginButton.Click();

            var loginWikiPage = new LoginWikiPage();
            loginWikiPage.Login(new User("Nie", "Nie"));

           Assert.IsFalse(_wikiPage.GetElementLoginTest("Zaloguj się").Displayed);
        }

        [TearDown]
        public void TearDownPage()
        {
            BaseTest.CloseBrowser();
        }
    }
}



