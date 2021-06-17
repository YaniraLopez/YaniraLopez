using NUnit.Framework;
using ExcersiteInterview.MicrosoftPage;
using ExcersiteInterview.Main;
using System.Threading;
using System;
using OpenQA.Selenium;

namespace ExcersiteInterview
{
    [TestFixture]
    [Parallelizable]

    public class UnitTest_Microsoft : Base
    {
        HomePage homePage = new HomePage();
        WindowsPage windowsPage = new WindowsPage();
        SearchResultspage searchResultspage = new SearchResultspage();
        DetalsPage detailsPage = new DetalsPage();
        CartPage cartPage = new CartPage();

        public UnitTest_Microsoft()
        {
        }

        [Test]
        public void FirstTestCase_Microsift()
        {
            OpenMicrosoft();
            //Validate home pege menu option
            Assert.IsTrue(homePage.Menu_officeOption.Displayed && homePage.Menu_windowsOption.Displayed && homePage.Menu_surfaceOption.Displayed &&
                homePage.Menu_xboxOption.Displayed && homePage.Menu_dealsOption.Displayed && homePage.Menu_supportOption.Displayed);
            //Navegate to windows page
            homePage.Menu_windowsOption.Click();
            windowsPage.OptionsMenu_Windows10();
            //Search items
            windowsPage.Search("Visual Studio");
            string searchPrice = searchResultspage.SftProductPrices().Replace("$", "");
            //Go to Details products
            searchResultspage.itemCarousel.Click();
            //close popup if its visible
            detailsPage.Close_Popup();
            string detailsPrice = detailsPage.productPrice.Text.Replace("$", "");
            Assert.AreEqual(searchPrice, detailsPrice);
            //Add product to cart
            ((IJavaScriptExecutor)Driver).ExecuteScript("arguments[0].click()", detailsPage.AddtoCart_Btn);
            Thread.Sleep(3000);
            string cartPrice = cartPage.UnitPrice.Text.Replace("$", "");
            //Compare prices from search, details and cart
            Assert.AreEqual(searchPrice, detailsPrice, cartPrice);
            //Update quantity
            cartPage.SelectOtherQty("20");
            Thread.Sleep(3000);
            Assert.AreEqual(cartPage.AlphanumericToNumeric(cartPage.SummaryTotal.Text), cartPage.GrandTotal());
        }
    }
}