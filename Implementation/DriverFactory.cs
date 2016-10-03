using System;
using Gauge.CSharp.Lib.Attribute;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.IE;

namespace SimpleSearchSeleniumCsharp.Implementation
{
    public class DriverFactory
    {
        public static IWebDriver Driver;

        [BeforeSuite]
        public void Setup() {
            bool useIe;
            bool.TryParse(Environment.GetEnvironmentVariable("USE_IE"), out useIe);
            if (useIe)
            {
                Driver=new InternetExplorerDriver();
            }
            else
            {
                Driver =new ChromeDriver();
            }
        }

        [AfterSuite]
        public void TearDown() {
            Driver.Close();
        }
    }
}
