using SeleniumExtras.PageObjects;
using ToolsQA.Selenium_Basics;

namespace ToolsQA.Pages
{
    class BasePage
    {
        public BasePage()
        {
            PageFactory.InitElements(Driver.DriverInstance, this);
        }
    }
}
