using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Threading;
using TechTalk.SpecFlow;

namespace AT_FinalAssignment_Project_NeelShukla
{
    [Binding]
    public class Ex07_WishlistStepDefinitions
    {
        IWebDriver driver;
        string url = "https://demo.nopcommerce.com/";

        [Given(@"User Launched Chrome Browser successfully")]
        public void GivenUserLaunchedChromeBrowserSuccessfully()
        {
            driver = new ChromeDriver(".");
            driver.Manage().Window.Maximize();
        }

        [Given(@"User launch app url")]
        public void GivenUserLaunchAppUrl()
        {
            driver.Url = url;
            Thread.Sleep(1000);
        }

        [When(@"user clicks on add to wish list button of HTC mobile")]
        public void WhenUserClicksOnAddToWhichListButtonOfHTCMobile()
        {
            IWebElement addToWishlistButtonHTC = driver.FindElement(By.XPath("(//button[@class='button-2 add-to-wishlist-button'])[3]"));
            addToWishlistButtonHTC.Click();
            Thread.Sleep(4000);
        }

        [When(@"User Clicks on Wishlist Link")]
        public void WhenUserClicksOnWishlistLink()
        {
            IWebElement wishlistLink = driver.FindElement(By.ClassName("wishlist-label"));
            wishlistLink.Click();
            
        }

        [Then(@"User Is Able to Navigate to Wishlist Page")]
        public void ThenUserIsAbleToNavigateToWishlistPage()
        {
            string expectedTitle = "nopCommerce demo store. Wishlist";
            string actualTitle = driver.Title;
            Console.WriteLine(actualTitle);
            Assert.AreEqual(expectedTitle, actualTitle);
        }

        [When(@"User Selects Add to Cart Checkbox")]
        public void WhenUserSelectsAddToCartCheckbox()
        {
            IWebElement addToCartCheckBox = driver.FindElement(By.Name("addtocart"));
            addToCartCheckBox.Click();
        }

        [When(@"User Clicks on Add to Cart Button on Wishlist page")]
        public void WhenUserClicksOnAddToCartButtonOnWishlistPage()
        {
            IWebElement addToCartButton = driver.FindElement(By.Name("addtocartbutton"));
            addToCartButton.Click();
        }

        [Then(@"User is redirected to Shopping Cart Page")]
        public void ThenUserIsRedirectedToShoppingCartPage()
        {
            string expectedTitle = "nopCommerce demo store. Shopping Cart";
            string actualTitle = driver.Title;
            Console.WriteLine(actualTitle);
            Assert.AreEqual(expectedTitle, actualTitle);
            driver.Quit();
        }

        // 2. Validate User is Able To Remove The Product From Wishlist 

        [When(@"User Clicks on Remove Button")]
        public void WhenUserClicksOnRemoveButton()
        {
            IWebElement removeButton = driver.FindElement(By.ClassName("remove-btn"));
            removeButton.Click();
        }

        [Then(@"Wishlist becomes empty")]
        public void ThenWishlistBecomesEmpty()
        {
            IWebElement expectedMessageValidation = driver.FindElement(By.XPath("//div[@class='no-data']"));
            string actualMessage = "The wishlist is empty!";
            Console.WriteLine(expectedMessageValidation.Text);
            Assert.AreEqual(actualMessage, expectedMessageValidation.Text);
            Thread.Sleep(1000);
            driver.Quit();
        }

        // Validate Qty Field Does Not Accepts Negative Value
        [When(@"User Enters (.*) in Qty Field")]
        public void WhenUserEntersInQtyField(string p0)
        {
            IWebElement qtyField = driver.FindElement(By.ClassName("qty-input"));
            qtyField.Clear();
            qtyField.SendKeys(p0);
        }
        [When(@"Clicks on Update Wishlist Button")]
        public void WhenClicksOnUpdateWishlistButton()
        {
            IWebElement updateWishlistButton = driver.FindElement(By.Id("updatecart"));
            updateWishlistButton.Click();
        }


        [Then(@"Error Message is Displayed Successfully")]
        public void ThenErrorMessageIsDisplayedSuccessfully()
        {
            IWebElement errorMessageValidation = driver.FindElement(By.ClassName("message-error"));
            string actualMessage = "This product is required in the quantity of 0";
            Console.WriteLine(errorMessageValidation.Text);
            Assert.AreEqual(actualMessage, errorMessageValidation.Text);
            Thread.Sleep(1000);
            driver.Quit();
        }


    }
}
