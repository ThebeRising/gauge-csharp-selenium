using System;
using System.Reflection;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace GaugeCsharpSelenium.Implementation.Pages
{
    public abstract class BasePage
    {
        
        protected static readonly string BaseUrl_GOOGLE = Environment.GetEnvironmentVariable("APP_ENDPOINT_GOOGLE");
        protected static readonly string BaseUrl_LOCAL = Environment.GetEnvironmentVariable("APP_ENDPOINT_LOCAL");
        

        protected BasePage()
        {
            PageFactory.InitElements(DriverFactory.Driver, this);
        }

        public IWebElement GetElement(string name)
        {
            var field = GetType().GetField(name, BindingFlags.IgnoreCase | BindingFlags.Instance | BindingFlags.Public);
            return field == null ? null : field.GetValue(this) as IWebElement;
        }

        protected static void ClearAndSetValue(IWebElement element, string value)
        {
            if (value == "->TAB")
            {
                element.SendKeys(Keys.Tab);
            }
            else
            {
                element.Clear();
                element.SendKeys(value);    
            }
            
        }
    }
}
