using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Threading;

namespace AT_Assignment6_Project_NeelShukla
{
    [TestClass]
    public class Ex01_LandingPage
    {
        IWebDriver driver;
        
        [TestInitialize] 
        public void setup()
        {            
            // Launch The chrome Browser
            driver = new ChromeDriver(".");
            // Launch The NOPC App
            string url = "https://demo.nopcommerce.com/";
            driver.Url = url;
        }
        
        [TestMethod]
        public void TestMethod01_ValidateRegisterLink()
        {

            // Validate Register Link
            IWebElement registerLink = driver.FindElement(By.ClassName("ico-register"));
            registerLink.Click();
            string expectedTitle = "nopCommerce demo store. Register";
            string actualTitle = driver.Title;
            Console.WriteLine(actualTitle);
            Assert.AreEqual(expectedTitle, actualTitle);
        }

        [TestMethod]
        public void TestMethod02_ValidateLoginLink()
        {

            // Validate Login Link
            IWebElement loginLink = driver.FindElement(By.ClassName("ico-login"));
            loginLink.Click();
            string expectedTitle = "nopCommerce demo store. Login";
            string actualTitle = driver.Title;
            Console.WriteLine(actualTitle);
            Assert.AreEqual(expectedTitle, actualTitle);
            Thread.Sleep(2000);

        }

        [TestMethod]
        public void TestMethod03_ValidateWishlistLink()
        {

            // Validate Wishlist Link
            IWebElement wishlistLink = driver.FindElement(By.ClassName("wishlist-label"));
            wishlistLink.Click();
            string expectedTitle = "nopCommerce demo store. Wishlist";
            string actualTitle = driver.Title;
            Console.WriteLine(actualTitle);
            Assert.AreEqual(expectedTitle, actualTitle);
            Thread.Sleep(2000);


        }

        [TestMethod]
        public void TestMethod04_ValidateShoppingCartLink()
        {
            // Validate Shopping Cart Link
            IWebElement shoppingCart = driver.FindElement(By.ClassName("cart-label"));
            shoppingCart.Click();
            string expectedTitle = "nopCommerce demo store. Shopping Cart";
            string actualTitle = driver.Title;
            Console.WriteLine(actualTitle);
            Assert.AreEqual(expectedTitle, actualTitle);
            Thread.Sleep(2000);
        }

        [TestMethod]
        public void TestMethod05_Logo()
        {
            // Find the Logo using XPath
            IWebElement logo = driver.FindElement(By.XPath("//img[@alt='nopCommerce demo store']"));
            // Check if the Logo is displayed
            if (logo.Displayed)
            {
                Console.WriteLine("Logo is displayed on the page.");
            }
            else
            {
                Console.WriteLine("Logo is not displayed on the page.");
            }

            // Click on the Logo
            logo.Click();
            // Validate that the click action has been performed
            string expectedUrl = "https://demo.nopcommerce.com/";
            string actualUrl = driver.Url;

            if (actualUrl == expectedUrl)
            {
                Console.WriteLine("Click on the logo validated successfully. Navigated to Landing  Page.");
            }
            else
            {
                Console.WriteLine("Click on the logo did not navigate to the expected URL.");
            }

            Thread.Sleep(2000);

        }

        [TestMethod]
        public void TestMethod06_ValidSearchField()
        {
            // Validate Search Text Field
            IWebElement searchTextField = driver.FindElement(By.Id("small-searchterms"));
            searchTextField.SendKeys("Lenovo");
            Thread.Sleep(2000);
            //Validate Search Button
            IWebElement searchButton = driver.FindElement(By.LinkText("Search"));
            searchButton.Click();
            Thread.Sleep(3000);
        }
        [TestMethod]
        public void TestMethod07_ValidateComputerLink()
        {
            // Validate Computer Link
            IWebElement computerLink = driver.FindElement(By.LinkText("Computers"));
            computerLink.Click();
            string expectedTitle = "nopCommerce demo store. Computers";
            string actualTitle = driver.Title;
            Console.WriteLine(actualTitle);
            Assert.AreEqual(expectedTitle, actualTitle);
            Thread.Sleep(2000);
        }

        [TestMethod]
        public void TestMethod08_ValidateElectronicsLink()
        {
            // Validate Electronics Link
            IWebElement electronicsLink = driver.FindElement(By.LinkText("Electronics"));
            electronicsLink.Click();
            string expectedTitle = "nopCommerce demo store. Electronics";
            string actualTitle = driver.Title;
            Console.WriteLine(actualTitle);
            Assert.AreEqual(expectedTitle, actualTitle);
            Thread.Sleep(2000);
        }

        [TestMethod]
        public void TestMethod09_ValidateApparelLink()
        {
            // Validate Apparel Link
            IWebElement apparelLink = driver.FindElement(By.LinkText("Apparel"));
            apparelLink.Click();
            string expectedTitle = "nopCommerce demo store. Apparel";
            string actualTitle = driver.Title;
            Console.WriteLine(actualTitle);
            Assert.AreEqual(expectedTitle, actualTitle);
            Thread.Sleep(2000);
        }

        [TestMethod]
        public void TestMethod10_ValidatedigitalDownloadsLinkLink()
        {
            // Validate Digital Downloads Link
            IWebElement digitalDownloadsLink = driver.FindElement(By.LinkText("Digital downloads"));
            digitalDownloadsLink.Click();
            string expectedTitle = "nopCommerce demo store. Digital downloads";
            string actualTitle = driver.Title;
            Console.WriteLine(actualTitle);
            Assert.AreEqual(expectedTitle, actualTitle);
            Thread.Sleep(2000);
        }

        [TestMethod]
        public void TestMethod11_ValidateBooksLink()
        {
            // Validate Books Link
            IWebElement bookLink = driver.FindElement(By.LinkText("Books"));
            bookLink.Click();
            string expectedTitle = "nopCommerce demo store. Books";
            string actualTitle = driver.Title;
            Console.WriteLine(actualTitle);
            Assert.AreEqual(expectedTitle, actualTitle);
            Thread.Sleep(2000);
        }

        [TestMethod]
        public void TestMethod12_ValidateJewelryLink()
        {
            // Validate Jewelry Link
            IWebElement jewelryLink = driver.FindElement(By.LinkText("Jewelry"));
            jewelryLink.Click();
            string expectedTitle = "nopCommerce demo store. Jewelry";
            string actualTitle = driver.Title;
            Console.WriteLine(actualTitle);
            Assert.AreEqual(expectedTitle, actualTitle);
            Thread.Sleep(2000);
        }

        [TestMethod]
        public void TestMethod13_ValidateGiftCardLink()
        {
            // Validate Gift Cards Link
            IWebElement giftCardLink = driver.FindElement(By.LinkText("Gift Cards"));
            giftCardLink.Click();
            string expectedTitle = "nopCommerce demo store. Gift Cards";
            string actualTitle = driver.Title;
            Console.WriteLine(actualTitle);
            Assert.AreEqual(expectedTitle, actualTitle);
            Thread.Sleep(2000);
        }

        [TestMethod]
        public void TestMethod14_ValidateDocumentationLink()
        {
            // Validate documentation Link
            IWebElement documentationLink = driver.FindElement(By.LinkText("Documentation"));
            documentationLink.Click();
            string expectedTitle = "nopCommerce Documentation";
            string actualTitle = driver.Title;
            Console.WriteLine(actualTitle);
            Assert.AreEqual(expectedTitle, actualTitle);
            Thread.Sleep(2000);
        }

        [TestMethod]
        public void TestMethod15_ValidateForumnsLink()
        {
            // Validate Forums Link
            IWebElement forumnsLink = driver.FindElement(By.LinkText("Forums"));
            forumnsLink.Click();
            string expectedTitle = "Forums - nopCommerce";
            string actualTitle = driver.Title;
            Console.WriteLine(actualTitle);
            Assert.AreEqual(expectedTitle, actualTitle);
            Thread.Sleep(2000);
        }

        [TestMethod]
        public void TestMethod16_ValidatenopCommercecomLink()
        {
            // Validate nopCommerce Link
            IWebElement nopCommerceLink = driver.FindElement(By.LinkText("nopCommerce.com"));
            nopCommerceLink.Click();
            string expectedTitle = "Free and open-source eCommerce platform. ASP.NET Core based shopping cart. - nopCommerce";
            string actualTitle = driver.Title;
            Console.WriteLine(actualTitle);
            Assert.AreEqual(expectedTitle, actualTitle);
            Thread.Sleep(2000);
        }

        [TestMethod]
        public void TestMethod17_PictureofCategoryElectronicsLink()
        {
            // Validate Electronics Category Image
            IWebElement electronicsCategoryImage = driver.FindElement(By.XPath("//img[@alt='Picture for category Electronics']"));
            electronicsCategoryImage.Click();
            string expectedTitle = "nopCommerce demo store. Electronics";
            string actualTitle = driver.Title;
            Console.WriteLine(actualTitle);
            Assert.AreEqual(expectedTitle, actualTitle);
            Thread.Sleep(2000);
        }


        [TestMethod]
        public void TestMethod18_ValidateHTCProductLink()
        {
            // Validate HTC Mobile Link
            IWebElement htcMobileLink = driver.FindElement(By.LinkText("HTC One M8 Android L 5.0 Lollipop"));
            htcMobileLink.Click();
            string expectedTitle = "nopCommerce demo store. HTC One M8 Android L 5.0 Lollipop";
            string actualTitle = driver.Title;
            Console.WriteLine(actualTitle);
            Assert.AreEqual(expectedTitle, actualTitle);
            Thread.Sleep(2000);
        }

        [TestMethod]
        public void TestMethod19_AddToCartButton()
        {
            // Validate Add to Cart Button
            IWebElement addToCart = driver.FindElement(By.XPath("(//button[@class='button-2 product-box-add-to-cart-button'])[1]"));
            addToCart.Click();
            
            Console.WriteLine("Add to Cart Button Enabled = " + addToCart.Enabled);
            
        }

        [TestMethod]
        public void TestMethod20_AddToCompareButton()
        {
            // Validate Add to Compare Button
            IWebElement addToCompare = driver.FindElement(By.XPath("(//button[@class='button-2 add-to-compare-list-button'])[1]"));
            addToCompare.Click();
            string expectedTitle = "nopCommerce demo store";
            string actualTitle = driver.Title;
            Console.WriteLine(actualTitle);
            Assert.AreEqual(expectedTitle, actualTitle);
            Thread.Sleep(2000);
        }

        [TestMethod]
        [Ignore("functionality not working at the moment")]
        public void TestMethod21_AddToWishlist()
        {
            // Validate Add to Wishlist Button
            IWebElement addToWishlist = driver.FindElement(By.XPath("(//button[@class='button-2 add-to-wishlist-button'])[1]"));
            addToWishlist.Click();
            string expectedTitle = "nopCommerce demo store";
            string actualTitle = driver.Title;
            Console.WriteLine(actualTitle);
            Assert.AreEqual(expectedTitle, actualTitle);
            Thread.Sleep(2000);
        }

        [TestMethod]
        public void TestMethod22_DetailsButton()
        {
            // Validate Add to Wishlist Button
            IWebElement detailsButton = driver.FindElement(By.XPath("//a[@href='/new-online-store-is-open']"));
            detailsButton.Click();
            string expectedTitle = "nopCommerce demo store. New online store is open!";
            string actualTitle = driver.Title;
            Console.WriteLine(actualTitle);
            Assert.AreEqual(expectedTitle, actualTitle);
            Thread.Sleep(2000);
        }


        [TestCleanup]

        public void cleanup()
        {

            driver.Quit();

        }


    }
}