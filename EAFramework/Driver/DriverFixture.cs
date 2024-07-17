using System;
using EAFramework.Config;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;

namespace EAFramework.Driver
{
    public class DriverFixture : IDriverFixture
    {
        public IWebDriver Driver { get; }

        public TestSettings testSettings;

        public DriverFixture(TestSettings testSettings)
        {
            Driver = GetDriverType(testSettings.BrowserType);
            Driver.Navigate().GoToUrl(testSettings.ApplicationUrl);
        }

        private IWebDriver GetDriverType(BrowserType browserType)
        {
            return browserType switch
            {
                BrowserType.Chrome => new ChromeDriver(),
                BrowserType.Firefox => new FirefoxDriver(),
                BrowserType.Edge => new EdgeDriver(),
                _ => new ChromeDriver(),
            };
        }

        public enum BrowserType
        {
            Chrome,
            Firefox,
            Safari,
            Edge,
            Chromium
        }
    }
}
