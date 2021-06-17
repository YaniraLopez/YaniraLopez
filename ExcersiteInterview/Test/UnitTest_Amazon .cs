using NUnit.Framework;
using ExcersiteInterview.AmazonPage;
using ExcersiteInterview.Main;
using System.Threading;
using System;
using OpenQA.Selenium;

namespace ExcersiteInterview
{
    [TestFixture]
    [Parallelizable]
    public class Tests : Base
    {
        SigninPage signinPage = new SigninPage();
        Searchpage searchpage = new Searchpage();

        public Tests()
        {
        }

        [Test]
        public void FirstTestCase_Amazon()
        {
            OpenAmazon();
            //go to create account
            signinPage.GoToCreateAccout();
            signinPage.ConditionOfUse_Link.Click();
            searchpage.searchInHelp("Echo");
            Assert.IsTrue(searchpage.SelectResult("Echo Support"));
            Assert.IsTrue(searchpage.TopicDisplayed());
        }

    }
}