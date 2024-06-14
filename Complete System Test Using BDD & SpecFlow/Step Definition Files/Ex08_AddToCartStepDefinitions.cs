using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Threading;
using TechTalk.SpecFlow;

namespace AT_FinalAssignment_Project_NeelShukla
{
    [Binding]
    public class Ex08_AddToCartStepDefinitions
    {
        IWebDriver driver;
        string url = "https://demo.nopcommerce.com/";

        // 1. Validate user is able to add product in shopping cart
        [Given(@"User Have Launched Chrome Browser\.")]
        public void GivenUserHaveLaunchedChromeBrowser_()
        {
            driver = new ChromeDriver(".");
            driver.Manage().Window.Maximize();
        }

        [Given(@"App Is Launched \.")]
        public void GivenAppIsLaunched_()
        {
            driver.Url = url;
        }

        [Given(@"User is on nopCommerce App Landing Page\.")]
        public void GivenUserIsOnNopCommerceAppLandingPage_()
        {
            string expectedTitle = "nopCommerce demo store";
            string actualTitle = driver.Title;
            Console.WriteLine(actualTitle);
            Assert.AreEqual(expectedTitle, actualTitle);
        }

        [When(@"User Clicks on Login Link\.")]
        public void WhenUserClicksOnLoginLink_()
        {
            IWebElement loginLink = driver.FindElement(By.ClassName("ico-login"));
            loginLink.Click();
        }

        [Then(@"User is Navigate to Login Page Successfully\.")]
        public void ThenUserIsNavigateToLoginPageSuccessfully_()
        {
            string expectedTitle = "nopCommerce demo store. Login";
            string actualTitle = driver.Title;
            Console.WriteLine(actualTitle);
            Assert.AreEqual(expectedTitle, actualTitle);
        }

        [When(@"User Has Entered Valid Email ""([^""]*)""\.")]
        public void WhenUserHasEnteredValidEmail_(string p0)
        {
            IWebElement emailField = driver.FindElement(By.Id("Email"));
            emailField.SendKeys(p0);
        }

        [When(@"User Has Entered Valid Password ""([^""]*)""\.")]
        public void WhenUserHasEnteredValidPassword_(string p0)
        {
            IWebElement passwordField = driver.FindElement(By.Id("Password"));
            passwordField.SendKeys(p0);
        }

        [When(@"Selects Remember Me Field\.")]
        public void WhenSelectsRememberMeField_()
        {
            IWebElement rememberMe = driver.FindElement(By.Id("RememberMe"));
            rememberMe.Click();
        }

        [When(@"User Clicks On Login Button\.")]
        public void WhenUserClicksOnLoginButton_()
        {
            IWebElement loginbutton = driver.FindElement(By.XPath("//button[@class='button-1 login-button']"));
            loginbutton.Click();
            Thread.Sleep(1000);
        }

        [When(@"user clicks on add to cart button of HTC mobile\.")]
        public void WhenUserClicksOnAddToCartButtonOfHTCMobile_()
        {
            IWebElement addToCartButton = driver.FindElement(By.XPath("(//button[@class='button-2 product-box-add-to-cart-button'])[3]"));
            addToCartButton.Click();
            Thread.Sleep(4000);
        }

        [When(@"Clicks On Shopping Cart Button\.")]
        public void WhenClicksOnShoppingCartButton_()
        {
            IWebElement shoppingCartLink = driver.FindElement(By.ClassName("cart-label"));
            shoppingCartLink.Click();
            Thread.Sleep(1000);
        }

        [Then(@"User is Navigated to Shopping Cart Page")]
        public void ThenUserIsNavigatedToShoppingCartPage()
        {
            string expectedTitle = "nopCommerce demo store. Shopping Cart";
            string actualTitle = driver.Title;
            Console.WriteLine(actualTitle);
            Assert.AreEqual(expectedTitle, actualTitle);
        }

        [Then(@"HTC Product is Added successfully")]
        public void ThenHTCProductIsAddedSuccessfully()
        {
            string expectedText = "HTC One M8 Android L 5.0 Lollipop";
            IWebElement actualText = driver.FindElement(By.XPath("//a[@class='product-name']"));
            Console.WriteLine(actualText.Text);
            Assert.AreEqual(expectedText, actualText.Text);
            Thread.Sleep(1000);
        } 
        

        // 2. Validate User is Able to Update the Qty in From Shopping Cart Page
        [When(@"user Clears The Qty Field")]
        public void WhenUserClearsTheQtyField()
        {
            IWebElement qtyField = driver.FindElement(By.XPath("//input[@class='qty-input']"));
            qtyField.Clear();
        }

        [When(@"Enters (.*) in the Qty Field")]
        public void WhenEntersInTheQtyField(string p0)
        {
            IWebElement qtyField = driver.FindElement(By.XPath("//input[@class='qty-input']"));
            qtyField.SendKeys(p0);
        }

        [When(@"Clicks on Update Shopping Cart Button")]
        public void WhenClicksOnUpdateShoppingCartButton()
        {
            IWebElement updateCartButton = driver.FindElement(By.Id("updatecart"));
            updateCartButton.Click();
        }

        [Then(@"Cart is Updated Successfully")]
        public void ThenCartIsUpdatedSuccessfully()
        {
            string expectedQty = "(2)";
            IWebElement actualQty = driver.FindElement(By.XPath("//span[@class='cart-qty']"));
            Console.WriteLine(actualQty.Text);
            Assert.AreEqual(expectedQty, actualQty.Text);
            Thread.Sleep(1000);
            driver.Quit();
        }

        // 3. Validate User is Not Able to Update the Qty with Negative Value
        [When(@"Enters (.*) in the Qty Field\.")]
        public void WhenEntersInTheQtyField_(string p0)
        {
            IWebElement qtyField = driver.FindElement(By.XPath("//input[@class='qty-input']"));
            qtyField.SendKeys(p0);
        }

        [Then(@"The Error Message Is Displayed Successfully")]
        public void ThenTheErrorMessageIsDisplayedSuccessfully()
        {
            IWebElement errorMessageValidation = driver.FindElement(By.ClassName("message-error"));
            string actualMessage = "This product is required in the quantity of 0";
            Console.WriteLine(errorMessageValidation.Text);
            Assert.AreEqual(actualMessage, errorMessageValidation.Text);
            Thread.Sleep(1000);
            driver.Quit();
        }






    }
}
