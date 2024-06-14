using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Threading;
using TechTalk.SpecFlow;

namespace AT_FinalAssignment_Project_NeelShukla
{
    [Binding]
    public class Ex04_HomePageStepDefinitions
    {
        IWebDriver driver;
        string url = "https://demo.nopcommerce.com/";
        private int ico;

        // 1. Validate User is Able to Navigate to  My Account Link From Home Page
        [Given(@"User Launched Chrome Browser")]
        public void GivenUserLaunchedChromeBrowser()
        {
            driver = new ChromeDriver(".");
            driver.Manage().Window.Maximize();
        }

        [Given(@"App is Launched")]
        public void GivenAppIsLaunched()
        {
            driver.Url = url;
        }

        [Given(@"user is on Landing Page")]
        public void GivenUserIsOnLandingPage()
        {
            string expectedTitle = "nopCommerce demo store";
            string actualTitle = driver.Title;
            Console.WriteLine(actualTitle);
            Assert.AreEqual(expectedTitle, actualTitle);
        }

        [Given(@"User Clicks on Login Link\.")]
        public void GivenUserClicksOnLoginLink_()
        {
            IWebElement loginLink = driver.FindElement(By.ClassName("ico-login"));
            loginLink.Click();
        }

        [Given(@"User Navigates to Login Page")]
        public void GivenUserNavigatesToLoginPage()
        {
            string expectedTitle = "nopCommerce demo store. Login";
            string actualTitle = driver.Title;
            Console.WriteLine(actualTitle);
            Assert.AreEqual(expectedTitle, actualTitle);
        }

        [When(@"User Has Entered Valid Email ""([^""]*)"" \.")]
        public void WhenUserHasEnteredValidEmail_(string p0)
        {
            IWebElement emailField = driver.FindElement(By.Id("Email"));
            emailField.SendKeys(p0);
        }

        [When(@"User Has Entered Valid Password ""([^""]*)"" \.")]
        public void WhenUserHasEnteredValidPassword_(string p0)
        {
            IWebElement passwordField = driver.FindElement(By.Id("Password"));
            passwordField.SendKeys(p0);
        }

        [When(@"User Clicks on Login Button")]
        public void WhenUserClicksOnLoginButton()
        {
            IWebElement loginbutton = driver.FindElement(By.XPath("//button[@class='button-1 login-button']"));
            loginbutton.Click();
        }

        [Then(@"User is Navigated To Home Page")]
        public void ThenUserIsNavigatedToHomePage()
        {
            IWebElement expectedLinkCreated = driver.FindElement(By.ClassName("ico-account"));
            string actualLinkCreated = "My account";
            Console.WriteLine(expectedLinkCreated.Text);
            Assert.AreEqual(actualLinkCreated, expectedLinkCreated.Text);
            Thread.Sleep(1000);
        }

        [When(@"User Clicks on My Account Link\.")]
        public void WhenUserClicksOnMyAccountLink_()
        {
            WebElement myAccountLink = (WebElement)driver.FindElement(By.ClassName("ico-account"));
            myAccountLink.Click();
        }

        [Then(@"User is Redirected To “My Account – Customer Info” Page")]
        public void ThenUserIsRedirectedToMyAccountCustomerInfoPage()
        {
            string expectedTitle = "nopCommerce demo store. Account";
            string actualTitle = driver.Title;
            Console.WriteLine(actualTitle);
            Assert.AreEqual(expectedTitle, actualTitle);
            driver.Quit();
        }

        // 2. Validate user is able to logout successfully 
        [When(@"User Clicks on Logout Link")]
        public void WhenUserClicksOnLogoutLink()
        {
            IWebElement myAccountLink = driver.FindElement(By.ClassName("ico-logout"));
            myAccountLink.Click();
        }

        [Then(@"User is Redirected To “Landing Page” Page")]
        public void ThenUserIsRedirectedToLandingPagePage()
        {
            IWebElement expectedLinkCreated = driver.FindElement(By.ClassName("ico-login"));
            string actualLinkCreated = "Log in";
            Console.WriteLine(expectedLinkCreated.Text);
            Assert.AreEqual(actualLinkCreated, expectedLinkCreated.Text);
            Thread.Sleep(1000);
            driver.Quit();
        }


    }
}
