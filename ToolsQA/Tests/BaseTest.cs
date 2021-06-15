using ToolsQA.Selenium_Basics;

namespace ToolsQA.Tests
{
    public static class BaseTest
    {
         
        public static void StartBrowser()
        {
            Driver.StartBrowser();
        }

        public static void CloseBrowser()
        {
            Driver.CloseBrowser();
        }
    }
}
