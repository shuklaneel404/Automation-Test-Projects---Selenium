using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Threading;
using TechTalk.SpecFlow;

namespace AT_FinalAssignment_Project_NeelShukla
{
    [Binding]
    public class Ex01_LandingPageStepDefinitions
    {
        
        IWebDriver driver;
        string url = "https://demo.nopcommerce.com/";

        // 1. Validate Register Link is Displayed On Landing Page
        [Given(@"Chrome is opened")]
        public void GivenChromeIsOpened()
        {
            driver = new ChromeDriver(".");
            driver.Manage().Window.Maximize();
        }

        [When(@"User launch the url")]
        public void WhenUserLaunchTheUrl()
        {
            driver.Url = url;
        }

        [Then(@"User Navigates to Landing Page")]
        public void ThenUserNavigatesToLandingPage()
        {
            string expectedTitle = "nopCommerce demo store";
            string actualTitle = driver.Title;
            Console.WriteLine(actualTitle);
            Assert.AreEqual(expectedTitle, actualTitle);
        }

        [Then(@"Register Link is Displayed Properly")]
        public void ThenRegisterLinkIsDisplayedProperly()
        {
            //Validate Register Link is Displayed

            IWebElement registerLink = driver.FindElement(By.ClassName("ico-register"));
            Assert.IsTrue(registerLink.Displayed);
            Thread.Sleep(1000);
        }

        // 2. Validate Register Link is Enabled on Landing Page
        [Then(@"Register Link is Enabled Properly")]
        public void ThenRegisterLinkIsEnabledProperly()
        {
            IWebElement registerLink = driver.FindElement(By.ClassName("ico-register"));
            Assert.IsTrue(registerLink.Enabled);
            Thread.Sleep(1000);
        }

        // 3. Validate Login Link is Displayed Properly
        [Then(@"Login Link is Displayed Properly")]
        public void ThenLoginLinkIsDisplayedProperly()
        {
            IWebElement registerLink = driver.FindElement(By.ClassName("ico-login"));
            Assert.IsTrue(registerLink.Displayed);
            Thread.Sleep(1000);
            driver.Quit();
        }

        // 4.  Validate Login Link is Enabled on Landing Page
        [Then(@"Login Link is Enabled Properly")]
        public void ThenLoginLinkIsEnabledProperly()
        {
            IWebElement registerLink = driver.FindElement(By.ClassName("ico-login"));
            Assert.IsTrue(registerLink.Enabled);
            Thread.Sleep(1000);
            driver.Quit();
        }

        // 5. Validate User is Able to See Featured Products on Landing Page
        [Then(@"Featured Products Are Diaplayed Properly")]
        public void ThenFeaturedProductsAreDiaplayedProperly()
        {
            IWebElement featuredProducts = driver.FindElement(By.XPath("//*[text()='Featured products']"));
            Assert.IsTrue(featuredProducts.Displayed);
            driver.Quit();
        }




    }
}
