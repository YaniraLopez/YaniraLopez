using System;
using ExcersiteInterview.Main;
using OpenQA.Selenium;

namespace ExcersiteInterview.AmazonPage
{
    public class HomePage : Base
    {
        public HomePage()
        {
        }

        public IWebElement Nav_Sign => Driver.FindElement(By.XPath("//div[@id='nav-tools']//a[contains(@href,'signin')]"));
        


    }
}
