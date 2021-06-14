using ToolsQA.Pages;

namespace ToolsQA.Tests
{
    class Cridentials
    {
        public string _username { get; set; }
        public string _password { get; set; }

        public void Login(LoginWikiPage loginWikiPage)
        {
            loginWikiPage.UserName.SendKeys(_username);
            loginWikiPage.Password.SendKeys(_password);
            loginWikiPage.LoginButton.Click();
        }
    }
}
