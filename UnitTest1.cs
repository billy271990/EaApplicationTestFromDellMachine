using System;
using EaApplicationTest.Pages;
using EAFramework.Config;
using EAFramework.Driver;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;
using Xunit;

namespace EaApplicationTest
{
    public class UnitTest1 : IDisposable
    {
        
        private IDriverFixture _driverFixture;

        public UnitTest1()
        {
            var testSettings = new TestSettings
            {
                BrowserType = DriverFixture.BrowserType.Chrome,
                ApplicationUrl = new Uri("http://localhost:8000"),
                TimeoutInternal = 30
            };

            _driverFixture = new DriverFixture(testSettings);
        }

        [Fact]
        public void Test1()
        {
            //Home Page
            var homePage = new HomePage(_driverFixture);
            var productPage = new ProductPage(_driverFixture);

            //Click the Create Link
            homePage.ClickProduct();

            //Create Product
            productPage.ClickCreateButton();
            productPage.CreateProduct("POM Product", "POM Description", 3000, "CPU");
        }

        public void Dispose()
        {
            _driverFixture.Driver?.Quit();
        }
    }
}
