using NUnit.Framework;
using ToolsQA.Pages;
using ToolsQA.Selenium_Basics;

namespace ToolsQA.Tests
{
    public class BaseTest
    {
        public WikiPage WikiPage;

        public static void StartBrowser()
        {
            Driver.StartBrowser();
        }

        public static void CloseBrowser()
        {
            Driver.CloseBrowser();
        }

        [SetUp]
        public void SetUp()
        {
            StartBrowser();
            WikiPage = new WikiPage();
        }

        [TearDown]
        public void TearDownPage()
        {
            CloseBrowser();
        }
    }
}