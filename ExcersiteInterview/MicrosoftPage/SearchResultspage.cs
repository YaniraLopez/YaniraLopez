using System;
using System.Collections.Generic;
using ExcersiteInterview.Main;
using OpenQA.Selenium;

namespace ExcersiteInterview.MicrosoftPage
{
    public class SearchResultspage :Base
    {
        public SearchResultspage()
        {
        }

        public static IReadOnlyList<IWebElement> carouselPrice_Software => Driver.FindElements(By.XPath("//div[contains(@aria-label,'software')]//span[@itemprop='price']"));
        public IWebElement translatePopup => Driver.FindElement(By.CssSelector("div#R1MarketRedirect-1"));
        public IWebElement SkipTranslate => Driver.FindElement(By.CssSelector("button#R1MarketRedirect-close"));
        public IWebElement itemCarousel => Driver.FindElement(By.XPath("//div[contains(@aria-label,'software')]//li//a"));
        public string SftProductPrices()
        {
            if (translatePopup.Enabled)
            {
                SkipTranslate.Click();
            }
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(carouselPrice_Software[i].Text);
            }
            return carouselPrice_Software[0].Text;
        }        
    }
}
