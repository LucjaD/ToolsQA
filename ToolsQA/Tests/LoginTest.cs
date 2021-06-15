using NUnit.Framework;
using ToolsQA.Pages;

namespace ToolsQA.Tests
{
    class LoginTest : BaseTest
    {
        private const string _userName = "Testowanie1";
        private const string _password = "Testy123";

        [Test]
        public void CorrectLogin()
        {
            WikiPage.LoginButton.Click();

            var loginWikiPage = new LoginWikiPage();
            loginWikiPage.Login(new User(_userName, _password));

            Assert.IsFalse(WikiPage.GetLoginInfo("Wyloguj").Displayed);
        }

        [Test]
        public void IncorrectLogin()
        {
            WikiPage.LoginButton.Click();

            var loginWikiPage = new LoginWikiPage();
            loginWikiPage.Login(new User("Nie", "Nie"));

           Assert.IsFalse(WikiPage.GetLoginInfo("Zaloguj się").Displayed);
        }
    }
}