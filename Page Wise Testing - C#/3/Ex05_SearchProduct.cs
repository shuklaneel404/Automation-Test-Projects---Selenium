using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Threading;

namespace AT_Assignment6_Project_NeelShukla
{
    [TestClass]
    public class Ex05_SearchProduct
    {
        [TestInitialize]
        public void setup()

        {
            //Launch The Google Browser With Inbuild Driver
            driver = new ChromeDriver(".");
            // Launch The NOPC App
            driver.Url = url;

        }


        // Writing This in Class Level So Further We Dont Need To Rewrite this Common Code Again & Again
        IWebDriver driver;
        string url = "https://demo.nopcommerce.com/";

        [TestMethod]

        public void TestMethod01_ValidateSearchProductPageNavigation()
        {
            // Click on Search Product Page In Footer Section
            IWebElement searchLinkFooter = driver.FindElement(By.XPath("//a[@href='/search']"));
            searchLinkFooter.Click();
            string expectedTitle = driver.Title;
            string actualTitle = "nopCommerce demo store. Search";
            Assert.AreEqual(expectedTitle, actualTitle, "Search Link is not working");
            Console.WriteLine("Search Product Page Is Navigated Successfully");
        }

        [TestMethod]

        public void TestMethod02_ValidateSearchProductWithValidData()
        {

            // Search Product With Valid Data - Characters More Than 3 Characters
            IWebElement searchLinkFooter = driver.FindElement(By.XPath("//a[@href='/search']"));
            searchLinkFooter.Click();
            IWebElement searchField = driver.FindElement(By.ClassName("search-text"));
            searchField.SendKeys("Lenovo");
            // Click on Search Button
            IWebElement searchButton = driver.FindElement(By.CssSelector("button[class='button-1 search-button']"));
            searchButton.Click();
            Thread.Sleep(2000);
            string expectedURL = driver.Url;
            string actualURL = "https://demo.nopcommerce.com/search?q=Lenovo&cid=0&mid=0&advs=false&isc=false&sid=false";
            Assert.AreEqual(expectedURL, actualURL, "Search Field is Working as Expected");
            Console.WriteLine("Search Field is Working As Expected For Valid Search Data");
        }

        [TestMethod]

        public void TestMethod03_ValidateSearchProductWithInValidData()
        {

            // Search Product With Valid Data - Characters Less Than 3 Characters
            IWebElement searchLinkFooter = driver.FindElement(By.XPath("//a[@href='/search']"));
            searchLinkFooter.Click();
            IWebElement searchField = driver.FindElement(By.ClassName("search-text"));
            searchField.SendKeys("Le");
            // Click on Search Button
            IWebElement searchButton = driver.FindElement(By.CssSelector("button[class='button-1 search-button']"));
            searchButton.Click();
            Thread.Sleep(2000);
            IWebElement warningText = driver.FindElement(By.CssSelector("div[class=warning]"));
            string expextedWarningText = warningText.Text;
            string actualWarningText = "Search term minimum length is 3 characters";
            Assert.AreEqual(expextedWarningText, actualWarningText, "Search Field is Not Working as per Requirement");
            Console.WriteLine("Search Field is Working as Expected");
        }


        [TestCleanup]

        public void cleanup()
        {

            driver.Quit();

        }
    }
}