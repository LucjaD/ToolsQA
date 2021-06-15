using SeleniumExtras.PageObjects;
using ToolsQA.Selenium_Basics;

namespace ToolsQA.Pages
{
    public class BasePage
    {
        public BasePage()
        {
            PageFactory.InitElements(Driver.DriverInstance, this);
        }
    }
}
