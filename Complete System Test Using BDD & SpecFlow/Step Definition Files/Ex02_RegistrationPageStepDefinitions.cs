using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Threading;
using TechTalk.SpecFlow;

namespace AT_FinalAssignment_Project_NeelShukla
{
    [Binding]
    public class Ex02_RegistrationPageStepDefinitions
    {
        IWebDriver driver;
        string url = "https://demo.nopcommerce.com/";

        [Given(@"Chrome Browser is Opened Successfully")]
        public void GivenChromeBrowserIsOpenedSuccessfully()
        {
            driver = new ChromeDriver(".");
            driver.Manage().Window.Maximize();
        }

        // 1. Validate Registration Process with valid data

        [Given(@"User is on The nopCommerce Landing Page")]
        public void GivenUserIsOnTheNopCommerceLandingPage()
        {
            driver.Url = url;
        }

        [When(@"User Clicks on Register Link")]
        public void WhenUserClicksOnRegisterLink()
        {
            IWebElement registerLink = driver.FindElement(By.ClassName("ico-register"));
            registerLink.Click();
        }

        [Then(@"User Should Navigate to Register Page")]
        public void ThenUserShouldNavigateToRegisterPage()
        {
            string expectedTitle = "nopCommerce demo store. Register";
            string actualTitle = driver.Title;
            Console.WriteLine(actualTitle);
            Assert.AreEqual(expectedTitle, actualTitle);
        }

        [When(@"User Enters ""([^""]*)"" in First Name")]
        public void WhenUserEntersInFirstName(string arjun)
        {
            IWebElement firstName = driver.FindElement(By.Name("FirstName"));
            firstName.SendKeys(arjun);
        }

        [When(@"User Enters ""([^""]*)"" in Last Name")]
        public void WhenUserEntersInLastName(string linux)
        {
            IWebElement lastName = driver.FindElement(By.Name("LastName"));
            lastName.SendKeys(linux);
        }

        [When(@"User Enters ""([^""]*)"" in Email")]
        public void WhenUserEntersInEmail(string p0)
        {
            IWebElement emailTextField = driver.FindElement(By.Id("Email"));
            emailTextField.SendKeys(p0);
        }

        [When(@"User Enters ""([^""]*)"" in Company Details")]
        public void WhenUserEntersInCompanyDetails(string nOPC)
        {
            IWebElement companyName = driver.FindElement(By.Id("Company"));
            companyName.SendKeys(nOPC);
        }

        [When(@"User Selected Newsletter Checkbox")]
        public void WhenUserSelectedNewsletterCheckbox()
        {
            IWebElement newsLetter = driver.FindElement(By.Id("Newsletter"));
            newsLetter.Click();
        }

        [When(@"User Enteres ""([^""]*)"" in Password")]
        public void WhenUserEnteresInPassword(string p0)
        {
            IWebElement passwordTextField = driver.FindElement(By.Id("Password"));
            passwordTextField.SendKeys(p0);
        }

        [When(@"User Entered ""([^""]*)"" Confirm Password Same as Password")]
        public void WhenUserEnteredConfirmPasswordSameAsPassword(string p0)
        {
            IWebElement cpasswordTextField = driver.FindElement(By.Id("ConfirmPassword"));
            cpasswordTextField.SendKeys(p0);
        }

        [When(@"User Clicks on Register Button")]
        public void WhenUserClicksOnRegisterButton()
        {
            IWebElement registerButton = driver.FindElement(By.Id("register-button"));
            registerButton.Click();
            Thread.Sleep(1000);
        }

        [Then(@"User Should Registered Successfully")]
        public void ThenUserShouldRegisteredSuccessfully()
        {
            string expectedResult = "Your registration completed";
            IWebElement actualResult = driver.FindElement(By.XPath("//div[@class='result']"));
            Console.WriteLine(actualResult.Text);
            Assert.AreEqual(expectedResult, actualResult.Text);
            Thread.Sleep(1000);
            driver.Quit();
        }

        // 2. Validate Registration Process By Keeping MAndatory Fields Blank - Here Keeping First Name Field Blank
        [When(@"User Enters Keeps Blank ""([^""]*)"" in First Name")]
        public void WhenUserEntersKeepsBlankInFirstName(string p0)
        {
            IWebElement firstName = driver.FindElement(By.Name("FirstName"));
            firstName.SendKeys(p0);
        }

        [Then(@"Error Should Be Displayed “First Name Field Is Required\.”")]
        public void ThenErrorShouldBeDisplayedFirstNameFieldIsRequired_()
        {
            IWebElement registerButton = driver.FindElement(By.Id("register-button"));
            registerButton.Click();
            Thread.Sleep(1000);
            string expectedResult = "First name is required.";
            IWebElement actualResult = driver.FindElement(By.Id("FirstName-error"));
            Console.WriteLine(actualResult.Text);
            Assert.AreEqual(expectedResult, actualResult.Text);
            Thread.Sleep(1000);
            driver.Quit();
        }

        // 3. Validate User Should Not Be Able to Register Different Password & Confirm Password
        [When(@"User Entered ""([^""]*)"" Confirm Password Not Same as Password")]
        public void WhenUserEnteredConfirmPasswordNotSameAsPassword(string p0)
        {
            IWebElement cpasswordTextField = driver.FindElement(By.Id("ConfirmPassword"));
            cpasswordTextField.SendKeys(p0);
        }

        [Then(@"Error Should Be Displayed “The password and confirmation password do not match\.\.”")]
        public void ThenErrorShouldBeDisplayedThePasswordAndConfirmationPasswordDoNotMatch_()
        {
            // Click on Register Button
            IWebElement registerButton = driver.FindElement(By.Id("register-button"));
            registerButton.Click();
            Thread.Sleep(1000);
            // Validate The Password Error Message 
            string expectedResult = "The password and confirmation password do not match.";
            IWebElement actualResult = driver.FindElement(By.Id("ConfirmPassword-error"));
            Console.WriteLine(actualResult.Text);
            Assert.AreEqual(expectedResult, actualResult.Text);
            Thread.Sleep(1000);
            driver.Quit();
        }

        // 4. Validate Password Field Does Not Accepts Less Than 6 Characters
        [When(@"User Enteres ""([^""]*)"" Password in less then (.*) Characters")]
        public void WhenUserEnteresPasswordInLessThenCharacters(string pwd, int p1)
        {
            IWebElement passwordTextField = driver.FindElement(By.Id("Password"));
            passwordTextField.SendKeys(pwd + p1);
        }

        [Then(@"Error Should Be Displayed “The password and confirmation password do not match\.\.” Password must meet the following rules: must have at least (.*) characters")]
        public void ThenErrorShouldBeDisplayedThePasswordAndConfirmationPasswordDoNotMatch_PasswordMustMeetTheFollowingRulesMustHaveAtLeastCharacters(int p0)
        {

            IWebElement registerButton = driver.FindElement(By.Id("register-button"));
            registerButton.Click();
            string expectedResult = "Password must meet the following rules:\r\nmust have at least 6 characters";
            IWebElement actualResult = driver.FindElement(By.Id("Password-error"));
            Console.WriteLine(actualResult.Text);
            Assert.AreEqual(expectedResult, actualResult.Text);
            Thread.Sleep(1000);
            driver.Quit();
        }



    }
}
