using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Threading;
using System.Collections.Generic;
using System.Linq;

namespace AT_Assignment6_Project_NeelShukla
{
    [TestClass]
    public class Ex08_AddToCartPage
    {
        IWebDriver driver;
        //Navigate to landing page
        string url = "https://demo.nopcommerce.com/";

        [TestInitialize]
        public void init()
        {
            driver = new ChromeDriver(".");
            driver.Url = url;
        }
        
        [TestMethod]
        public void TestMethod01_ValidateShoppingcartPageWithInvalidData()
        {
            //click on addtocart button for below specified product
            IWebElement addtocart = driver.FindElement(By.XPath("(//button[@class='button-2 product-box-add-to-cart-button'])[3]"));
            addtocart.Click();
            Thread.Sleep(3000);

            //navigation onto wishlist page after adding product to wishlist
            driver.Navigate().GoToUrl("https://demo.nopcommerce.com/cart");

            //wishlist page title validation
            string expectedTitle1 = "nopCommerce demo store. Shopping Cart";
            string actualTitle1 = driver.Title;
            Assert.AreEqual(expectedTitle1, actualTitle1);
            Console.WriteLine(actualTitle1);

            //click on checkout button
            IWebElement checkout = driver.FindElement(By.XPath("(//button[@type='submit'])[6]"));
            checkout.Click();
            Thread.Sleep(2000);
        }

        [TestMethod]
        [Ignore("functionality not working at the moment")]
        public void TestMethod02_ValidateRemoveButton()
        {
            IWebElement removebutton = driver.FindElement(By.ClassName("remove-btn"));
            removebutton.Click();
            Thread.Sleep(2000);

        }

        [TestCleanup]
        public void cleanup()
        {
            driver.Quit();
        }
    }
}
