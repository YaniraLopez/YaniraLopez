using System;
using System.Text.RegularExpressions;
using ExcersiteInterview.Main;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace ExcersiteInterview.MicrosoftPage
{
    public class CartPage:Base
    {
        public CartPage()
        {
        }

        public IWebElement UnitPrice => Driver.FindElement(By.XPath("//span[contains(@class,'x-screen-reader')]"));
        public IWebElement UpdateQty => Driver.FindElement(By.XPath("//select[contains(@aria-label,'Quantity')]"));
        public IWebElement SummaryTotal => Driver.FindElement(By.XPath("//div[@class='group--1guqPpXf']//span[@itemprop='price']//span"));
        public IWebElement ItemsQty => Driver.FindElement(By.XPath("//div[@class='group--1guqPpXf']//span//span[contains(text(), 'Items')]"));

        public void SelectOtherQty(string value)
        {
            SelectElement qty = new SelectElement(UpdateQty);
            qty.SelectByValue(value);
            //UpdateQty.SendKeys(Keys.Enter);
        }

        public double GrandTotal()
        {
            var pricePerUnit = AlphanumericToNumeric(UnitPrice.Text);
            var itemsQty = AlphanumericToNumeric(ItemsQty.Text);
            
            var Total = itemsQty * pricePerUnit;
            return Total;
        }

        public double AlphanumericToNumeric(string value)
        {
            value = Regex.Replace(value, "[^0-9,.]", "");
            double txtToDouble = Convert.ToDouble(value);
            return txtToDouble;
        }
    }
}
