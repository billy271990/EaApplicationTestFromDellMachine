using System;
using EAFramework.Driver;
using EAFramework.Extensions;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace EaApplicationTest.Pages
{
    public class ProductPage
    {
        private IDriverFixture _driverFixture;
        public ProductPage(IDriverFixture driverFixture)
        {
            _driverFixture = driverFixture;
        }

        private IWebElement txtName => _driverFixture.Driver.FindElement(By.Id("Name"));
        private IWebElement txtDescription => _driverFixture.Driver.FindElement(By.Name("Description"));
        private IWebElement txtPrice => _driverFixture.Driver.FindElement(By.Id("Price"));
        private IWebElement ddlProductType => _driverFixture.Driver.FindElement(By.Id("ProductType"));
        private IWebElement lnkCreate => _driverFixture.Driver.FindElement(By.LinkText("Create"));
        private IWebElement btnCreate => _driverFixture.Driver.FindElement(By.Id("Create"));
        private IWebElement tblList => _driverFixture.Driver.FindElement(By.CssSelector(".table"));

        public void ClickCreateButton() => lnkCreate.Click();

        public void CreateProduct(string productName, string productDescription, int price, string productType)
        {
            txtName.SendKeys(productName);
            txtDescription.SendKeys(productDescription);
            txtPrice.SendKeys(price.ToString());
            //SelectElement select = new SelectElement(ddlProductType);
            //select.SelectByText(productType);

            //WebElementExtensions webElementExtensions = new WebElementExtensions();
            //webElementExtensions.SelectDropDownByText(ddlProductType, productType);

            ddlProductType.SelectDropDownByText(productType);

            btnCreate.Click();
        }
    }
}
