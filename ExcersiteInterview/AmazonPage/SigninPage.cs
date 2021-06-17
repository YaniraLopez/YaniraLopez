using System;
using ExcersiteInterview.Main;
using OpenQA.Selenium;

namespace ExcersiteInterview.AmazonPage
{
    public class SigninPage : Base
    {
        string API_employees = "http://dummy.restapiexample.com/api/v1/employees";
        HomePage homePageAmazon = new HomePage();
        
        public SigninPage()
        {
        }

        public IWebElement CreateAccount_btn => Driver.FindElement(By.CssSelector("a#createAccountSubmit"));
        public IWebElement ConditionOfUse_Link => Driver.FindElement(By.XPath("//a[contains(@href, 'condition_of_use')]"));

        public void GoToCreateAccout()
        {
            homePageAmazon.Nav_Sign.Click();
            CreateAccount_btn.Click();
        }

        

        public void API_GetNameUser()
        {
            IJavaScriptExecutor js = Driver as IJavaScriptExecutor;
            var jsonResponse = js.ExecuteScript(
                "var xhr = new XMLHttRequest(); " +
                "xhr.open('GET', " + API_employees + ");" +
                "xhr.send(null);" +
                "if (xhr.status === 200) { " +
                    "return xhr.responseText; " +
                "} "
                );
            Console.WriteLine(jsonResponse.ToString());

        }
    }
}
