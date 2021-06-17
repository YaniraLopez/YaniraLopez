using System;
using System.Threading;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace ExcersiteInterview.Main
{
    public class Base
    {
        public static IWebDriver Driver;

        public Base()
        {
        }

        [OneTimeSetUp]
        public void Open()
        {
            Driver = new ChromeDriver();           
        }

        [OneTimeTearDown]
        public void Close()
        {
            Driver.Quit();
        }

        public void OpenMicrosoft()
        {
            Driver.Navigate().GoToUrl("https://www.microsoft.com/en-us/");
            Driver.Manage().Window.Maximize();
            Thread.Sleep(3000);
        }

        public void OpenAmazon()
        {
            Driver.Navigate().GoToUrl("https://www.amazon.com/");
            Driver.Manage().Window.Maximize();
            Thread.Sleep(3000);
        } 
    }
}
