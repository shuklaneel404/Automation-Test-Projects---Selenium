using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Threading;

namespace AT_Assignment6_Project_NeelShukla
{
    [TestClass]
    public class Ex06_ProductDetailsPage
    {
        static IWebDriver driver;
        //url for nopcommerce website with object
        static string url = "https://demo.nopcommerce.com/";

        [ClassInitialize]
        public static void setup(TestContext context)
        {
            //using chromedriver to loanch url
            driver = new ChromeDriver(".");
            driver.Manage().Window.Maximize();
            //passing url object here
            driver.Url = url;
        }
        [TestMethod]
        public void TestMethod01_NavigateProductDetailsPage()
        {
            // Navigate To Product Details Page By Clicking on HTC One M8 Android L 5.0 Lollipop Product
            IWebElement htcProductLink = driver.FindElement(By.LinkText("HTC One M8 Android L 5.0 Lollipop"));
            htcProductLink.Click();
            Thread.Sleep(1000);
        }
        [TestMethod]
        public void TestMethod02_HandleQtyField()
        {
            // Navigate To Product Details Page By Clicking on HTC One M8 Android L 5.0 Lollipop Product
            IWebElement qtySearchField = driver.FindElement(By.Id("product_enteredQuantity_18"));
            qtySearchField.SendKeys("5");
            // Click on Add to Cart Button
            IWebElement addToCArtButton = driver.FindElement(By.Id("add-to-cart-button-18"));
            addToCArtButton.Click();
            Thread.Sleep(1000);
        }

        [TestMethod]

        public void TestMethod03_HandleButtons() 
        {
            // Click on Add to wishlist Button of HTC One M8 Android L 5.0 Lollipop
            IWebElement addToWishlistButton = driver.FindElement(By.Id("add-to-wishlist-button-18"));
            addToWishlistButton.Click();
            Thread.Sleep(1000);
            // Click on Add to Compare List of HTC One M8 Android L 5.0 Lollipop 
            IWebElement addToCompareListButton = driver.FindElement(By.XPath("(//button[@class='button-2 add-to-compare-list-button'])[1]"));
            addToCompareListButton.Click();
            Thread.Sleep(1000);
            // Click On Email a Friend
            IWebElement emailFriendButton = driver.FindElement(By.XPath("(//button[@class='button-2 email-a-friend-button'])[1]"));
            emailFriendButton.Click();
            Thread.Sleep(1000);
            driver.Navigate().Back();
            // Click on Add to Cart Button of Portable Sound Speakers
            IWebElement addToCArtButton2 = driver.FindElement(By.XPath("(//button[@class='button-2 product-box-add-to-cart-button'])[1]"));
            addToCArtButton2.Click();
            Thread.Sleep(1000);
            // Click on Add to Cart Button of Beats Pill 2.0 Wireless Speaker
            IWebElement addToCArtButton3 = driver.FindElement(By.XPath("(//button[@class='button-2 product-box-add-to-cart-button'])[2]"));
            addToCArtButton3.Click();
            Thread.Sleep(1000);
            // Click on Add to Cart Button of Nokia Lumia 1020
            IWebElement addToCArtButton4 = driver.FindElement(By.XPath("(//button[@class='button-2 product-box-add-to-cart-button'])[3]"));
            addToCArtButton4.Click();
            Thread.Sleep(1000);
            // Click on Add to Cart Button of HTC One Mini Blue
            IWebElement addToCArtButton5 = driver.FindElement(By.XPath("(//button[@class='button-2 product-box-add-to-cart-button'])[4]"));
            addToCArtButton5.Click();
            Thread.Sleep(1000);



        }


        [ClassCleanup]

        public static void cleanup()
        {

            driver.Quit();
        }
    }
}
