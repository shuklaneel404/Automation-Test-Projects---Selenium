using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Threading;
using TechTalk.SpecFlow;

namespace AT_FinalAssignment_Project_NeelShukla
{
    [Binding]
    public class Ex03_LoginPageStepDefinitions
    {
        IWebDriver driver;
        string url = "https://demo.nopcommerce.com/";

        // 1. Validate Login Functionality: Validate User can Login Successfully Wit Valid Data

        [Given(@"User Have Launched Chrome Browser")]
        public void GivenUserHaveLaunchedChromeBrowser()
        {
            driver = new ChromeDriver(".");
            driver.Manage().Window.Maximize();
        }

        [Given(@"App Is Launched")]
        public void GivenAppIsLaunched()
        {
            driver.Url = url;
        }

        [Given(@"User is on nopCommerce App Landing Page")]
        public void GivenUserIsOnNopCommerceAppLandingPage()
        {
            string expectedTitle = "nopCommerce demo store";
            string actualTitle = driver.Title;
            Console.WriteLine(actualTitle);
            Assert.AreEqual(expectedTitle, actualTitle);
        }

        [When(@"User Clicks on Login Link")]
        public void WhenUserClicksOnLoginLink()
        {
            IWebElement loginLink = driver.FindElement(By.ClassName("ico-login"));
            loginLink.Click();
        }

        [Then(@"User is Navigate to Login Page Successfully")]
        public void ThenUserIsNavigateToLoginPageSuccessfully()
        {
            string expectedTitle = "nopCommerce demo store. Login";
            string actualTitle = driver.Title;
            Console.WriteLine(actualTitle);
            Assert.AreEqual(expectedTitle, actualTitle);
        }

        [When(@"User Has Entered Valid Email ""([^""]*)""")]
        public void WhenUserHasEnteredValidEmail(string p0)
        {
            IWebElement emailField = driver.FindElement(By.Id("Email"));
            emailField.SendKeys(p0);
        }

        [When(@"User Has Entered Valid Password ""([^""]*)""")]
        public void WhenUserHasEnteredValidPassword(string p0)
        {
            IWebElement passwordField = driver.FindElement(By.Id("Password"));
            passwordField.SendKeys(p0);
        }

        [When(@"Selects Remember Me Field")]
        public void WhenSelectsRememberMeField()
        {
            IWebElement rememberMe = driver.FindElement(By.Id("RememberMe"));
            rememberMe.Click();
        }

        [When(@"User Clicks On Login Button")]
        public void WhenUserClicksOnLoginButton()
        {
            IWebElement loginbutton = driver.FindElement(By.XPath("//button[@class='button-1 login-button']"));
            loginbutton.Click();
        }

        [Then(@"User Should Be Logged in Successfully")]
        public void ThenUserShouldBeLoggedInSuccessfully()
        {
            // Validate My Account Link is Created on Home Page

            IWebElement expectedLinkCreated = driver.FindElement(By.ClassName("ico-account"));
            string actualLinkCreated = "My account";
            Console.WriteLine(expectedLinkCreated.Text);
            Assert.AreEqual(actualLinkCreated, expectedLinkCreated.Text);
            Thread.Sleep(1000);
            {
                driver.Quit();
            }
        }
        

        // 2. Validate User Should Not be Able to Loggin using Invalid Password
        [When(@"User Has Entered Inalid Password ""([^""]*)""")]
        public void WhenUserHasEnteredInalidPassword(string p0)
        {
            IWebElement passwordField = driver.FindElement(By.Id("Password"));
            passwordField.SendKeys(p0);
        }

        [Then(@"Error Message is Displayed “Login was unsuccessful”")]
        public void ThenErrorMessageIsDisplayedLoginWasUnsuccessful()
        {
            IWebElement errorMessageValidation = driver.FindElement(By.XPath("//div[@class='message-error validation-summary-errors']"));
            string actualMessage = "Login was unsuccessful. Please correct the errors and try again.\r\nThe credentials provided are incorrect";
            Console.WriteLine(errorMessageValidation.Text);
            Assert.AreEqual(actualMessage, errorMessageValidation.Text);
            Thread.Sleep(1000);
            driver.Quit();
        }

        // 3. Validate Password Field is Secure From Basic SQL Injection
        [When(@"User Has Entered Inalid Password with SQL Payload ""([^""]*)""")]
        public void WhenUserHasEnteredInalidPasswordWithSQLPayload(string p0)
        {
            IWebElement passwordField = driver.FindElement(By.Id("Password"));
            passwordField.SendKeys(p0);
        }



    }
}
