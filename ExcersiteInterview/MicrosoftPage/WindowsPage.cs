using System;
using OpenQA.Selenium;
using ExcersiteInterview.Main;
using System.Collections.Generic;
using System.Threading;

namespace ExcersiteInterview.MicrosoftPage
{
    public class WindowsPage : Base
    {
        public WindowsPage()
        {
        }

        public IWebElement windows10_Menu => Driver.FindElement(By.CssSelector("button#c-shellmenu_54"));
        public static IReadOnlyList<IWebElement> windows10_MenuOptions => Driver.FindElements(By.XPath("//li[@class='nested-menu uhf-menu-item'][1]//li//a[@class='js-subm-uhf-nav-link']"));
        public IWebElement searchOption => Driver.FindElement(By.CssSelector("button#search"));
        public IWebElement searchInput => Driver.FindElement(By.CssSelector("input#cli_shellHeaderSearchInput"));

        public void OptionsMenu_Windows10()
        {
            windows10_Menu.Click();

            for (int i = 0; i < windows10_MenuOptions.Count; i++)
            {
                Console.WriteLine(windows10_MenuOptions[i].Text);
            }
        }

        public void Search(string Search)
        {
            searchOption.Click();
            searchInput.SendKeys(Search);
            searchInput.SendKeys(Keys.Enter);
        }
    }
}
