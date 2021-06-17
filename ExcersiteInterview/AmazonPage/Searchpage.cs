using System;
using System.Collections.Generic;
using ExcersiteInterview.Main;
using NUnit.Framework;
using OpenQA.Selenium;

namespace ExcersiteInterview.AmazonPage
{
    public class Searchpage:Base
    {
        public Searchpage()
        {
        }

        public IWebElement helpSearch => Driver.FindElement(By.CssSelector("input#helpsearch"));
        public static IReadOnlyList<IWebElement> Results_Option => Driver.FindElements(By.XPath("//div[@class='cs-help-search-result-row']//h2"));
        public static IReadOnlyList<IWebElement> Results_OptionLink => Driver.FindElements(By.CssSelector("a.a-link-normal"));
        public static IReadOnlyList<IWebElement> Support_Sections => Driver.FindElements(By.XPath("//div[contains(@class, 'a-box ')]//a[@class='a-accordion-row a-declarative']//h3"));

        public void searchInHelp(string value)
        {
            helpSearch.Click();
            helpSearch.SendKeys(value + Keys.Enter);
        }

        public bool SelectResult(string option)
        {
            bool result = false;
            for(int i=0;i<Results_Option.Count;i++)
            {
                var value = Results_Option[i].Text;
                if (value.Contains(option))
                {
                    Results_OptionLink[i].Click();
                    result = true;
                    break;
                }
                else
                    result = false;
            }
            return result;
        }

        public bool TopicDisplayed()
        {
            bool result = false;

            for (int i = 0; i<Support_Sections.Count; i++)
            {
                if (Support_Sections[i].Text.Contains("Getting Started"))
                    result = true;
                else if(Support_Sections[i].Text.Contains("Wi-Fi"))
                    result = true;
                else if(Support_Sections[i].Text.Contains("Bluetooth"))
                    result = true;
                else if(Support_Sections[i].Text.Contains("Device Software"))
                    result = true;
                else if(Support_Sections[i].Text.Contains("Hardware"))
                    result = true;
                else if(Support_Sections[i].Text.Contains("TroubleShooting"))
                    result = true;
            }
            return result;
        }
    }
}
