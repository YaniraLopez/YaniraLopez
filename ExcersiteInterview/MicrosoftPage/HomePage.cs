using System;
using ExcersiteInterview.Main;
using OpenQA.Selenium;

namespace ExcersiteInterview.MicrosoftPage
{
    public class HomePage : Base
    {
        public HomePage()
        {
        }

        public IWebElement Menu_officeOption => Driver.FindElement(By.CssSelector("a#shellmenu_1"));
        public IWebElement Menu_windowsOption => Driver.FindElement(By.CssSelector("a#shellmenu_2"));
        public IWebElement Menu_surfaceOption => Driver.FindElement(By.CssSelector("a#shellmenu_3"));
        public IWebElement Menu_xboxOption => Driver.FindElement(By.CssSelector("a#shellmenu_4"));
        public IWebElement Menu_dealsOption => Driver.FindElement(By.CssSelector("a#shellmenu_5"));
        public IWebElement Menu_supportOption => Driver.FindElement(By.CssSelector("a#l1_support"));

    }
}
