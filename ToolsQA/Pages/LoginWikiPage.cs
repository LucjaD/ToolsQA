using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Text;
using ToolsQA.Selenium_Basics;

namespace ToolsQA.Pages
{
    class LoginWikiPage
    {

        [FindsBy(How = How.Id, Using = "wpName1")]
        private IWebElement _userName;

        [FindsBy(How = How.Id, Using = "wpPassword1")]
        private IWebElement _password;

        [FindsBy(How = How.Id, Using = "wpLoginAttempt")]
        private IWebElement _loginButton;


        public LoginWikiPage()
        {

            PageFactory.InitElements(Driver.DriverInstance, this);
        }

        public void EnterUsername(string userName)
        {
            _userName.SendKeys(userName);
        }

        public void EnterPassword(string password)
        {
            _password.SendKeys(password);
        }

        public void LoginButtonClick()
        {
            _loginButton.Click();
        }
    }
}
