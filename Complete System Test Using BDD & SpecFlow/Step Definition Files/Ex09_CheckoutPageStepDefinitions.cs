using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Threading;
using TechTalk.SpecFlow;

namespace AT_FinalAssignment_Project_NeelShukla
{
    [Binding]
    public class Ex09_CheckoutPageStepDefinitions
    {
        IWebDriver driver;
        string url = "https://demo.nopcommerce.com/";

        [Given(@"User Have Launched Chrome  Browser")]
        public void GivenUserHaveLaunchedChromeBrowser()
        {
            driver = new ChromeDriver(".");
            driver.Manage().Window.Maximize();
        }

        [Given(@"App Is  Launched")]
        public void GivenAppIsLaunched()
        {
            driver.Url = url;
        }

        [Given(@"User is on nopCommerce App Landing  Page")]
        public void GivenUserIsOnNopCommerceAppLandingPage()
        {
            string expectedTitle = "nopCommerce demo store";
            string actualTitle = driver.Title;
            Console.WriteLine(actualTitle);
            Assert.AreEqual(expectedTitle, actualTitle);
        }

        [When(@"User Clicks on Login  Link")]
        public void WhenUserClicksOnLoginLink()
        {
            IWebElement loginLink = driver.FindElement(By.ClassName("ico-login"));
            loginLink.Click();
        }

        [Then(@"User is Navigate to Login Page  Successfully")]
        public void ThenUserIsNavigateToLoginPageSuccessfully()
        {
            string expectedTitle = "nopCommerce demo store. Login";
            string actualTitle = driver.Title;
            Console.WriteLine(actualTitle);
            Assert.AreEqual(expectedTitle, actualTitle);
        }

        [When(@"User Has Entered Valid Email  ""([^""]*)""")]
        public void WhenUserHasEnteredValidEmail(string p0)
        {
            IWebElement emailField = driver.FindElement(By.Id("Email"));
            emailField.SendKeys(p0);
        }

        [When(@"User Has Entered Valid Password  ""([^""]*)""")]
        public void WhenUserHasEnteredValidPassword(string p0)
        {
            IWebElement passwordField = driver.FindElement(By.Id("Password"));
            passwordField.SendKeys(p0);
        }

        [When(@"Selects Remember Me  Field")]
        public void WhenSelectsRememberMeField()
        {
            IWebElement rememberMe = driver.FindElement(By.Id("RememberMe"));
            rememberMe.Click();
        }

        [When(@"User Clicks On Login  Button")]
        public void WhenUserClicksOnLoginButton()
        {
            IWebElement loginbutton = driver.FindElement(By.XPath("//button[@class='button-1 login-button']"));
            loginbutton.Click();
            Thread.Sleep(1000);
        }

        [When(@"user clicks on add to cart button of HTC  mobile")]
        public void WhenUserClicksOnAddToCartButtonOfHTCMobile()
        {
            IWebElement addToCartButton = driver.FindElement(By.XPath("(//button[@class='button-2 product-box-add-to-cart-button'])[3]"));
            addToCartButton.Click();
            Thread.Sleep(4000);
        }

        [When(@"Clicks On Shopping Cart  Button")]
        public void WhenClicksOnShoppingCartButton()
        {
            IWebElement shoppingCartLink = driver.FindElement(By.ClassName("cart-label"));
            shoppingCartLink.Click();
            Thread.Sleep(1000);
        }

        [Then(@"User is Navigated to Shopping Cart  Page")]
        public void ThenUserIsNavigatedToShoppingCartPage()
        {
            string expectedTitle = "nopCommerce demo store. Shopping Cart";
            string actualTitle = driver.Title;
            Console.WriteLine(actualTitle);
            Assert.AreEqual(expectedTitle, actualTitle);
        }

        [Then(@"HTC Product is Added  successfully")]
        public void ThenHTCProductIsAddedSuccessfully()
        {
            string expectedText = "HTC One M8 Android L 5.0 Lollipop";
            IWebElement actualText = driver.FindElement(By.XPath("//a[@class='product-name']"));
            Console.WriteLine(actualText.Text);
            Assert.AreEqual(expectedText, actualText.Text);
            Thread.Sleep(1000);
        }

        [When(@"User Selects Terms and Condition Checkbox")]
        public void WhenUserSelectsTermsAndConditionCheckbox()
        {
            IWebElement termsCheckbox = driver.FindElement(By.Id("termsofservice"));
            termsCheckbox.Click();
        }

        [When(@"Clicks on Checkout  Button")]
        public void WhenClicksOnCheckoutButton()
        {
            IWebElement checkoutButton = driver.FindElement(By.Id("checkout"));
            checkoutButton.Click();
        }

        [Then(@"User is Navigated to Checkout Page Successfully")]
        public void ThenUserIsNavigatedToCheckoutPageSuccessfully()
        {
            string expectedTitle = "nopCommerce demo store. Checkout";
            string actualTitle = driver.Title;
            Console.WriteLine(actualTitle);
            Assert.AreEqual(expectedTitle, actualTitle);
        }

        [When(@"User Selects India From Country Drop Box")]
        public void WhenUserSelectsIndiaFromCountryDropBox()
        {
            IWebElement countryDropBox = driver.FindElement(By.Id("BillingNewAddress_CountryId"));
            SelectElement countryDropBoxValue = new SelectElement(countryDropBox);
            countryDropBoxValue.SelectByIndex(100);
        }

        [When(@"Enters ""([^""]*)"" in City Text Field")]
        public void WhenEntersInCityTextField(string vadodara)
        {
            IWebElement cityField = driver.FindElement(By.Id("BillingNewAddress_City"));
            cityField.SendKeys(vadodara);
        }

        [When(@"Enters The ""([^""]*)"" in Address(.*) Fiels")]
        public void WhenEntersTheInAddressFiels(string myAddress, int p1)
        {
            IWebElement address1Field = driver.FindElement(By.Id("BillingNewAddress_Address1"));
            address1Field.SendKeys(myAddress + p1.ToString());
        }

        [When(@"Enters (.*) in Postal code")]
        public void WhenEntersInPostalCode(string p0)
        {
            IWebElement postalCode = driver.FindElement(By.Id("BillingNewAddress_ZipPostalCode"));
            postalCode.SendKeys(p0);
        }

        [When(@"Enters (.*) in phone Number Field")]
        public void WhenEntersInPhoneNumberField(string p0)
        {
            IWebElement phoneNumber = driver.FindElement(By.Id("BillingNewAddress_PhoneNumber"));
            phoneNumber.SendKeys(p0);
            Thread.Sleep(1000);
        }

        [When(@"Clicks on Continue Button of Billing Address")]
        public void WhenClicksOnContinueButtonOfBillingAddress()
        {
            IWebElement continueBillingAdd = driver.FindElement(By.XPath("(//button[@class='button-1 new-address-next-step-button'])[1]"));
            continueBillingAdd.Click();
            Thread.Sleep(1000);
        }

        [When(@"User Selects Next Day Air Radio Button")]
        public void WhenUserSelectsNextDayAirRadioButton()
        {
            IWebElement radioButton1 = driver.FindElement(By.XPath("(//input[@name='shippingoption'])[2]"));
            radioButton1.Click();
        }

        [When(@"Clicks on Continue Button of Shipping Method")]
        public void WhenClicksOnContinueButtonOfShippingMethod()
        {
            IWebElement continue2 = driver.FindElement(By.XPath("//button[@class='button-1 shipping-method-next-step-button']"));
            continue2.Click();
            Thread.Sleep(1000);
        }

        [Then(@"User is Successfully Navigated To Payment Method Page")]
        public void ThenUserIsSuccessfullyNavigatedToPaymentMethodPage()
        {
            string expectedURL = "https://demo.nopcommerce.com/onepagecheckout#opc-payment_method";
            string actualURL = driver.Url;
            Console.WriteLine(actualURL);
            Assert.AreEqual(expectedURL, actualURL);

        }

        // 2. Validate User is not Allowed to Checkout Without Selecting Terms and Service Checkbox

        [When(@"User Do Not Selects Terms and Condition Checkbox")]
        public void WhenUserDoNotSelectsTermsAndConditionCheckbox()
        {
            IWebElement termsCheckbox = driver.FindElement(By.Id("termsofservice"));
            Thread.Sleep(1000);
        }

        [Then(@"Error Message should be displayed Please accept the terms of service before the next step\.")]
        public void ThenErrorMessageShouldBeDisplayedPleaseAcceptTheTermsOfServiceBeforeTheNextStep_()
        {
            string expectedErrorText = "Please accept the terms of service before the next step.";
            IWebElement actualErrorText = driver.FindElement(By.Id("terms-of-service-warning-box"));
            Console.WriteLine(actualErrorText.Text);
            Assert.AreEqual(expectedErrorText, actualErrorText.Text);
            driver.Quit();
        }

    }
}
