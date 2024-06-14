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
    public class Ex07_WishlistPage
    {
        [TestInitialize]

        public void setup()
        {
            //Launch The Google Browser With Inbuild Driver
            driver = new ChromeDriver(".");
            //maximize The Browser
            driver.Manage().Window.Maximize();
            // Launch The NOPC App
            driver.Url = url;
            // 1st add a product in Wishlist - add HTC One M8 Android L 5.0 Lollipop
            IList<IWebElement> allbuttonsLanding = driver.FindElements(By.TagName("button"));
            int buttonCounts = allbuttonsLanding.Count;
            Console.WriteLine("Total Buttons on Landing page = " + buttonCounts);
            allbuttonsLanding.ElementAt(9).Click();
            Console.WriteLine("Text of the button clicked: " + allbuttonsLanding.ElementAt(9).Text);
            Thread.Sleep(5000);

        }
        IWebDriver driver;
        string url = "https://demo.nopcommerce.com/";

        [TestMethod]
        public void TestMethod1_HandleButtons()
        {
            //Click on Wishlist Link
            IWebElement wishlistLink = driver.FindElement(By.XPath("//span[@class='wishlist-label']"));
            wishlistLink.Click();
            // Click on Update Wishlist Button
            IWebElement updateButton = driver.FindElement(By.Id("updatecart"));
            updateButton.Click();
            Thread.Sleep(2000);
            //Click on Add to Cart 
            IWebElement addToCartutton = driver.FindElement(By.Name("addtocartbutton"));
            addToCartutton.Click();
            Thread.Sleep(1000);
        }
        [TestMethod]
        public void TestMethod2_HandleCheckbox()
        {
            // Click on Wishlist Link
            IWebElement wishlistLink = driver.FindElement(By.XPath("//span[@class='wishlist-label']"));
            wishlistLink.Click();
            //Select Add to cart Checkbox
            IWebElement checkBoxAddToCart = driver.FindElement(By.XPath("(//input[@type='checkbox'])[1]"));

            if (checkBoxAddToCart.Displayed == true && checkBoxAddToCart.Enabled == true)
            {
                checkBoxAddToCart.Click();
                Console.WriteLine("Check Box is Working as Expected");
            }
            else
            {
                Console.WriteLine("Checkbox Not Working as Expected");
            }
        }

        [TestMethod]

        public void TestMethod3_HandleRemoveButton()
        {
            //Click on Wishlist Link
            IWebElement wishlistLink = driver.FindElement(By.XPath("//span[@class='wishlist-label']"));
            wishlistLink.Click();
            IWebElement removeButton = driver.FindElement(By.ClassName("remove-btn"));
            if (removeButton.Displayed == true && removeButton.Enabled == true)
            {
                removeButton.Click();
                Console.WriteLine("Remove Button is Working as Expected");
            }
            else
            {
                Console.WriteLine("Remove Button is Not Working as Expecetd");
            }


        }



        [TestCleanup]

        public void cleanup()
        {
            driver.Quit();
        }
    }
}
