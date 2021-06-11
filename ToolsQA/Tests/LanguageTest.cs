using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using ToolsQA.Pages;
using ToolsQA.Selenium_Basics;

namespace ToolsQA.Tests
{
    class LanguageTest
    {
        private string _url;


        [Test]
        public void CorrectLogin()
        {
            _url = "https://pl.wikipedia.org/wiki/Wikipedia:Strona_g%C5%82%C3%B3wna";
           
            Driver.StartBrowser();
            Driver.OpenPage(_url);

            var wikiPage = new WikiPage();
            wikiPage.ChangeLanguage();
         
            Debug.Assert( Driver.DriverInstance.Url.Contains("en.wikipedia.org"));



        }
    }
}
