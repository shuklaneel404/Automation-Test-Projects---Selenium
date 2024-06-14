using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Threading;

namespace AT_Assignment6_Project_NeelShukla
{
    [TestClass]
    public class Ex09_Checkout
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
        public void TestMethod01__ValidateShoppingcartPageWithValidData()
        {
            //validate landing page title
            string expectedTitle = "nopCommerce demo store";
            string actualTitle = driver.Title;
            Assert.AreEqual(expectedTitle, actualTitle);
            Console.WriteLine(actualTitle);

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

            //click on terms of service checkbox
            IWebElement termsofservice = driver.FindElement(By.Id("termsofservice"));
            termsofservice.Click();
            Thread.Sleep(2000);

            //click on checkout button
            IWebElement checkout = driver.FindElement(By.XPath("(//button[@type='submit'])[6]"));
            checkout.Click();
            Thread.Sleep(2000);
        }

        [TestMethod]
        public void TestMethod02__ValidateShoppingcartPageWithInvalidData()
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
        public void TestMessage03_ValidateRemoveButton()
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
