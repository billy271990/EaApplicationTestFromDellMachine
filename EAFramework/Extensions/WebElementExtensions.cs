using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace EAFramework.Extensions
{
    public static class WebElementExtensions
    {
        public static void SelectDropDownByText(this IWebElement element, string text)
        {
            SelectElement select = new SelectElement(element);
            select.SelectByText(text);
        }

        public static void SelectDropDownByValue(this IWebElement element, string value)
        {
            SelectElement select = new SelectElement(element);
            select.SelectByText(value);
        }

        public static void SelectDropDownByIndex(this IWebElement element, string index)
        {
            SelectElement select = new SelectElement(element);
            select.SelectByText(index);
        }

        public static void ClearAndEnterText(this IWebElement element, string value)
        {
            element.Clear();
            element.SendKeys(value);
        }
    }
}
