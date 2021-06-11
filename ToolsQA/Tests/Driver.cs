using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using ToolsQA.Pages;

namespace ToolsQA.Selenium_Basics
{
    public static class Driver
    {
        private static IWebDriver _driver;

        public static IWebDriver DriverInstance{ get => _driver; }

        public static void StartBrowser()
        {
            Driver._driver = new FirefoxDriver();
        }

        public static void OpenPage(string url)
        {
            Driver._driver.Url = url;
        }

        public static void StopBrowser()
        {
            _driver.Close();
        }

        //[SetUp]
        //public void SetUp()
        //{
        //    driver = new FirefoxDriver();
        //}

        //[Test]
        //public void Test1()
        //{
        //    driver.Url = "https://www.bing.com/?cc=pl";
        //    searchWord = "Shrek cda";

        //   // var homePage = new HomePage(driver);

        //    var bingPage = new BingPage(driver);
        //    bingPage.enterSearchWord(searchWord);
        //    bingPage.HitEnter();

        //    var searchResult = new BingSearchResultPage(driver);
        //    searchResult.clickShrekLink();


        //    var cdaPage = new CdaPage(driver);
        //    cdaPage.switchTab();
        //    cdaPage.changeQuality();
        //    cdaPage.fullScreen();
        //    cdaPage.playVid();

        //    //driver.Close();
        //}

        //[Test]
        //public void Test2()
        //{



        //}
    }
}
