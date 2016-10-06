using System;
using Gauge.CSharp.Lib.Attribute;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.IE;

namespace GaugeCsharpSelenium.Implementation
{
    public class DriverFactory
    {
        public static IWebDriver Driver;

        [BeforeSuite]
        public void Setup() {
           
            string browser = Environment.GetEnvironmentVariable("BROWSER");
            browser.ToLower();
            if (browser != null)
            {

                if (browser == "ie")
                {
                    Driver=new InternetExplorerDriver();
                }
                else if (browser == "chrome")
                {
                    Driver =new ChromeDriver();
                }
                else if (browser == "firefox")
                {
                    Driver = new FirefoxDriver();
                }
            }
            else
            {
                //Console.WriteLine("In the Else");
                Driver =new ChromeDriver();
            }
        }

        [AfterSuite]
        public void TearDown() {
           // Driver.Close();
            Driver.Quit();
        }
    }
}
