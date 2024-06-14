using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Security.Policy;
using System.Threading;
using TechTalk.SpecFlow;

namespace AT_FinalAssignment_Project_NeelShukla
{
    [Binding]
    public class Ex12_UserInfoPageStepDefinitions
    {
        IWebDriver driver;
        string url = "https://demo.nopcommerce.com/";

        [Given(@"User Have Launched The Chrome Browser")]
        public void GivenUserHaveLaunchedTheChromeBrowser()
        {
            driver = new ChromeDriver(".");
            driver.Manage().Window.Maximize();
        }

        [Given(@"App Is Been Launched")]
        public void GivenAppIsBeenLaunched()
        {
            driver.Url = url;
        }

        [Given(@"User is on The nopCommerce App Landing Page")]
        public void GivenUserIsOnTheNopCommerceAppLandingPage()
        {
            string expectedTitle = "nopCommerce demo store";
            string actualTitle = driver.Title;
            Console.WriteLine(actualTitle);
            Assert.AreEqual(expectedTitle, actualTitle);
        }

        [When(@"User Clicks on the Login Link")]
        public void WhenUserClicksOnTheLoginLink()
        {
            IWebElement loginLink = driver.FindElement(By.ClassName("ico-login"));
            loginLink.Click();
        }

        [Then(@"User is Navigate to the Login Page Successfully")]
        public void ThenUserIsNavigateToTheLoginPageSuccessfully()
        {
            string expectedTitle = "nopCommerce demo store. Login";
            string actualTitle = driver.Title;
            Console.WriteLine(actualTitle);
            Assert.AreEqual(expectedTitle, actualTitle);
        }

        [When(@"User Has Entered the Valid Email ""([^""]*)""")]
        public void WhenUserHasEnteredTheValidEmail(string p0)
        {
            IWebElement emailField = driver.FindElement(By.Id("Email"));
            emailField.SendKeys(p0);
        }

        [When(@"User Has Entered Valid the Password ""([^""]*)""")]
        public void WhenUserHasEnteredValidThePassword(string p0)
        {
            IWebElement passwordField = driver.FindElement(By.Id("Password"));
            passwordField.SendKeys(p0);
        }

        [When(@"Selects the Remember Me Field")]
        public void WhenSelectsTheRememberMeField()
        {
            IWebElement rememberMe = driver.FindElement(By.Id("RememberMe"));
            rememberMe.Click();
        }

        [When(@"User Clicks On the Login Button")]
        public void WhenUserClicksOnTheLoginButton()
        {
            IWebElement loginbutton = driver.FindElement(By.XPath("//button[@class='button-1 login-button']"));
            loginbutton.Click();
        }

        [Then(@"User Should Be Logged in Successfully\.")]
        public void ThenUserShouldBeLoggedInSuccessfully_()
        {
            // Validate My Account Link is Created on Home Page

            IWebElement expectedLinkCreated = driver.FindElement(By.ClassName("ico-account"));
            string actualLinkCreated = "My account";
            Console.WriteLine(expectedLinkCreated.Text);
            Assert.AreEqual(actualLinkCreated, expectedLinkCreated.Text);
        }

        [When(@"User Clicks on My Account Link")]
        public void WhenUserClicksOnMyAccountLink()
        {
            IWebElement myAccountLink = driver.FindElement(By.XPath("//a[@class='ico-account']"));
            myAccountLink.Click();
        }
        [When(@"Enters ""([^""]*)"" in Company Text Field")]
        public void WhenEntersInCompanyTextField(string nOPC)
        {
            IWebElement companyField = driver.FindElement(By.Id("Company"));
        }

        [When(@"Clicks On Save Button")]
        public void WhenClicksOnSaveButton()
        {
            IWebElement saveButton = driver.FindElement(By.Id("save-info-button"));
            saveButton.Click();
        }

        [Then(@"User Information is Saved Successfully")]
        public void ThenUserInformationIsSavedSuccessfully()
        {
            //Validating user info has been saved successfully
            IWebElement savedSuccessfully = driver.FindElement(By.XPath("//p[text()='The customer info has been updated successfully.']"));
            Console.WriteLine(savedSuccessfully.Text);
            
        }

        // Validate user is able to change the password Successfully
        [When(@"Clicks on Change Password Link")]
        public void WhenClicksOnChangePasswordLink()
        {
            IWebElement changePasswordLink = driver.FindElement(By.XPath("//a[@href='/customer/changepassword']"));
            changePasswordLink.Click();
        }

        [When(@"Enters ""([^""]*)"" in Old Password")]
        public void WhenEntersInOldPassword(string p0)
        {
            IWebElement oldPasswordField = driver.FindElement(By.Id("OldPassword"));
            oldPasswordField.SendKeys(p0);
        }

        [When(@"Enters ""([^""]*)"" in New Password Field")]
        public void WhenEntersInNewPasswordField(string p0)
        {
            IWebElement newPasswordField = driver.FindElement(By.Id("NewPassword"));
            newPasswordField.SendKeys(p0);
        }

        [When(@"Enters ""([^""]*)"" in Confirm Password Field")]
        public void WhenEntersInConfirmPasswordField(string p0)
        {
            IWebElement confirmPasswordField = driver.FindElement(By.Id("ConfirmNewPassword"));
            confirmPasswordField.SendKeys(p0);
        }

        [When(@"Click on Change Password Button")]
        public void WhenClickOnChangePasswordButton()
        {
            IWebElement changePasswordButton = driver.FindElement(By.XPath("//button[@class='button-1 change-password-button']"));
            changePasswordButton.Click();
        }

        [Then(@"Password Is Changed Successfully")]
        public void ThenPasswordIsChangedSuccessfully()
        {
            // Validating password has been changed successfully
            string expectedMessage = "Password was changed";
            IWebElement actualMessage = driver.FindElement(By.XPath("//p[text()='Password was changed']"));
            Console.WriteLine(actualMessage.Text);
            Assert.AreEqual(expectedMessage, actualMessage.Text);
        }

        // Validate User is not Able To Change The Password with Invalid Old Password
        [When(@"Enters Invalid ""([^""]*)"" in Old Password")]
        public void WhenEntersInvalidInOldPassword(string p0)
        {
            IWebElement oldPasswordField = driver.FindElement(By.Id("OldPassword"));
            oldPasswordField.SendKeys(p0);
            Thread.Sleep(1000);
        }

        [Then(@"Password Error Message Is Displayed")]
        public void ThenPasswordErrorMessageIsDisplayed()
        {
            IWebElement errorMessageValidation = driver.FindElement(By.XPath("//div[@class='message-error validation-summary-errors']"));
            string actualMessage = "Old password doesn't match";
            Console.WriteLine(errorMessageValidation.Text);
            Assert.AreEqual(actualMessage, errorMessageValidation.Text);
            Thread.Sleep(1000);
            driver.Quit();
        }

    }
}
