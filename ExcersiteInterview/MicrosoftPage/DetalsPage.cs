using System;
using OpenQA.Selenium;
using ExcersiteInterview.Main;

namespace ExcersiteInterview.MicrosoftPage
{
    public class DetalsPage:Base
    {
        public DetalsPage()
        {
        }
        public IWebElement productPrice => Driver.FindElement(By.XPath("//div[contains(@id, 'ProductPrice_productPrice_PriceContainer')]//span"));
        public IWebElement AddtoCart_Btn => Driver.FindElement(By.XPath("//button[@aria-label='Add to cart'][1]"));
        public IWebElement Close_SignPopup => Driver.FindElement(By.XPath("//div[@class='c-glyph glyph-cancel']"));
        public IWebElement SignPopup => Driver.FindElement(By.XPath("//div[@class='sfw-dialog']"));

        
        public void Close_Popup()
        {
            if (SignPopup.Enabled)
                Close_SignPopup.Click();
        }
    }
}
