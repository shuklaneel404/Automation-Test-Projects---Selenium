using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Threading;
using TechTalk.SpecFlow;

namespace AT_FinalAssignment_Project_NeelShukla
{
    [Binding]
    public class Ex001_EndToEndFlowStepDefinitions
    {
        IWebDriver driver;
        string url = "https://demo.nopcommerce.com/";

        [Given(@"User launch The Browser")]
        public void GivenUserLaunchTheBrowser()
        {
            driver = new ChromeDriver(".");
            driver.Manage().Window.Maximize();
        }

        [Given(@"User Launch The App")]
        public void GivenUserLaunchTheApp()
        {
            driver.Url = url;
        }

        [Given(@"User is on Landing Page")]
        public void GivenUserIsOnLandingPage()
        {
            // validate user is on landing page
            string expectedTitle = "nopCommerce demo store";
            string actualTitle = driver.Title;
            Console.WriteLine(actualTitle);
            Assert.AreEqual(expectedTitle, actualTitle);
        }

        [Given(@"User Clicks on Login Link")]
        public void GivenUserClicksOnLoginLink()
        {
            IWebElement loginLink = driver.FindElement(By.ClassName("ico-login"));
            loginLink.Click();
        }

        [When(@"User Enters ""([^""]*)"" in Email Field")]
        public void WhenUserEntersInEmailField(string p0)
        {
            IWebElement emailField = driver.FindElement(By.Id("Email"));
            emailField.SendKeys(p0);
        }

        [When(@"Enters ""([^""]*)"" in Password Field")]
        public void WhenEntersInPasswordField(string p0)
        {
            IWebElement passwordField = driver.FindElement(By.Id("Password"));
            passwordField.SendKeys(p0);
        }

        [When(@"Clicks on Login Button")]
        public void WhenClicksOnLoginButton()
        {
            IWebElement loginbutton = driver.FindElement(By.XPath("//button[@class='button-1 login-button']"));
            loginbutton.Click();
            Thread.Sleep(1000);
        }

        [Then(@"User Nevigates to Home Page")]
        public void ThenUserNevigatesToHomePage()
        {
            // Validate User is on Home Page - Validate My Account Link Created Or Not
            IWebElement expectedLinkCreated = driver.FindElement(By.ClassName("ico-account"));
            string actualLinkCreated = "My account";
            Console.WriteLine(expectedLinkCreated.Text);
            Assert.AreEqual(actualLinkCreated, expectedLinkCreated.Text);
            Thread.Sleep(1000);
        }

        [When(@"User Clicks On HTC Product Link From Featured Products")]
        public void WhenUserClicksOnHTCProductLinkFromFeaturedProducts()
        {
            IWebElement htcProductLink = driver.FindElement(By.XPath("(//a[@href=\"/htc-one-m8-android-l-50-lollipop\"])[2]"));
            htcProductLink.Click();
            Thread.Sleep(1000);
        }

        [Then(@"User Navigates To HTC Product Details Page")]
        public void ThenUserNavigatesToHTCProductDetailsPage()
        {
            string expectedTitle = "nopCommerce demo store. HTC One M8 Android L 5.0 Lollipop";
            string actualTitle = driver.Title;
            Console.WriteLine(actualTitle);
            Assert.AreEqual(expectedTitle, actualTitle);
        }

        [When(@"User Clicks On Add To Cart Button of HTC Product")]
        public void WhenUserClicksOnAddToCartButtonOfHTCProduct()
        {
            IWebElement addToCartButton = driver.FindElement(By.Id("add-to-cart-button-18"));
            addToCartButton.Click();
            Thread.Sleep(3000);
        }

        [Then(@"HTC One M(.*) is Added To Cart Successfully")]
        public void ThenHTCOneMIsAddedToCartSuccessfully(int p0)
        {
            string expectedResult = "(1)";
            IWebElement actualResult = driver.FindElement(By.XPath("//span[@class='cart-qty']"));
            Console.WriteLine(actualResult.Text);
            Assert.AreEqual(expectedResult, actualResult.Text);
            Thread.Sleep(1000);
        }

        [When(@"Clicks On Shopping Cart Button")]
        public void WhenClicksOnShoppingCartButton()
        {
            IWebElement shoppingCartLink = driver.FindElement(By.XPath("//span[@class='cart-label']"));
            shoppingCartLink.Click();
        }

        [Then(@"User Navigates To Shopping Cart Page")]
        public void ThenUserNavigatesToShoppingCartPage()
        {
            // Validate user is On Shopping Cart Page
            string expectedTitle = "nopCommerce demo store. Shopping Cart";
            string actualTitle = driver.Title;
            Console.WriteLine(actualTitle);
            Assert.AreEqual(expectedTitle, actualTitle);
        }

        [When(@"User Clicks On T&C Checkbox on Shopping Cart Button")]
        public void WhenUserClicksOnTCCheckboxOnShoppingCartButton()
        {
            IWebElement termsCheckbox = driver.FindElement(By.Id("termsofservice"));
            termsCheckbox.Click();
        }

        [When(@"Clicks on Checkout Button")]
        public void WhenClicksOnCheckoutButton()
        {
            IWebElement addToCartButton = driver.FindElement(By.Id("checkout"));
            addToCartButton.Click();
        }

        [Then(@"User Navigates to Checkout Page")]
        public void ThenUserNavigatesToCheckoutPage()
        {
            string expectedTitle = "nopCommerce demo store. Checkout";
            string actualTitle = driver.Title;
            Console.WriteLine(actualTitle);
            Assert.AreEqual(expectedTitle, actualTitle);
        }

        [When(@"User Selects India From Country Dropdown Menu")]
        public void WhenUserSelectsIndiaFromCountryDropdownMenu()
        {
            IWebElement countryDropBox = driver.FindElement(By.Id("BillingNewAddress_CountryId"));
            SelectElement countryDropBoxValue = new SelectElement(countryDropBox);
            countryDropBoxValue.SelectByIndex(100);
        }

        [When(@"Enters ""([^""]*)"" in City")]
        public void WhenEntersInCity(string vadodara)
        {
            IWebElement cityField = driver.FindElement(By.Id("BillingNewAddress_City"));
            cityField.SendKeys(vadodara);
        }

        [When(@"Enters ""([^""]*)"" in Address(.*)")]
        public void WhenEntersInAddress(string p0, int p1)
        {
            IWebElement address1Field = driver.FindElement(By.Id("BillingNewAddress_Address1"));
            address1Field.SendKeys(p0 + p1.ToString());
        }

        [When(@"Enters ""([^""]*)"" in Zip/postal code")]
        public void WhenEntersInZipPostalCode(string postCode)
        {
            IWebElement postalCode = driver.FindElement(By.Id("BillingNewAddress_ZipPostalCode"));
            postalCode.SendKeys(postCode);
        }

        [When(@"Enters (.*) Phone Numnber Field")]
        public void WhenEntersPhoneNumnberField(string p0)
        {
            IWebElement phoneNumber = driver.FindElement(By.Id("BillingNewAddress_PhoneNumber"));
            phoneNumber.SendKeys(p0);
            Thread.Sleep(1000);
        }

        [When(@"Clicks on Continue")]
        public void WhenClicksOnContinue()
        {
            IWebElement continueBillingAdd = driver.FindElement(By.XPath("(//button[@class='button-1 new-address-next-step-button'])[1]"));
            continueBillingAdd.Click();
            Thread.Sleep(1000);
        }

        [When(@"Selects Next Day Air Shipping Method Check Box")]
        public void WhenSelectsNextDayAirShippingMethodCheckBox()
        {
            IWebElement radioButton1 = driver.FindElement(By.XPath("(//input[@name='shippingoption'])[2]"));
            radioButton1.Click();
        }

        [When(@"Clicks On Continue Button of shipping")]
        public void WhenClicksOnContinueButtonOfShipping()
        {
            IWebElement continue2 = driver.FindElement(By.XPath("//button[@class='button-1 shipping-method-next-step-button']"));
            continue2.Click();
            Thread.Sleep(1000);
        }

        [When(@"Selects Credit Card Checkbox in Payment Method")]
        public void WhenSelectsCreditCardCheckboxInPaymentMethod()
        {
            IWebElement paymentRadioButton1 = driver.FindElement(By.XPath("(//input[@name='paymentmethod'])[2]"));
            paymentRadioButton1.Click();
            // Click on Continue button of payment
            IWebElement continue3 = driver.FindElement(By.XPath("//button[@class='button-1 payment-method-next-step-button']"));
            continue3.Click();
            Thread.Sleep(1000);

        }

        [When(@"Enters ""([^""]*)"" in Cardholder name")]
        public void WhenEntersInCardholderName(string scheme)
        {
            IWebElement cardHolderName = driver.FindElement(By.Id("CardholderName"));
            cardHolderName.SendKeys(scheme);
        }

        [When(@"Enters (.*) in Card Number Field")]
        public void WhenEntersInCardNumberField(string p0)
        {
            IWebElement cardNumber = driver.FindElement(By.Id("CardNumber"));
            cardNumber.SendKeys(p0);
        }

        [When(@"User Selects valid In Expirary Date, Month Dropdown Field")]
        public void WhenUserSelectsValidInExpiraryDateMonthDropdownField()
        {
            //select expiry month
            IWebElement monthExpiry = driver.FindElement(By.XPath("//select[@name='ExpireMonth']"));
            SelectElement monthExpiryValue = new SelectElement(monthExpiry);
            monthExpiryValue.SelectByValue("3");
            // select expiry year
            IWebElement yearExpiry = driver.FindElement(By.XPath("//select[@name='ExpireYear']"));
            SelectElement yearExpiryValue = new SelectElement(yearExpiry);
            yearExpiryValue.SelectByValue("2030");
        }


        [When(@"Enters (.*) in Card Code Field")]
        public void WhenEntersInCardCodeField(string p0)
        {
            IWebElement cardCode = driver.FindElement(By.Id("CardCode"));
            cardCode.SendKeys(p0);
        }

        [When(@"Clicks on Continue of Payment Info")]
        public void WhenClicksOnContinueOfPaymentInfo()
        {
            IWebElement continue4 = driver.FindElement(By.XPath("//button[@class='button-1 payment-info-next-step-button']"));
            continue4.Click();
            Thread.Sleep(1000);
        }

        [When(@"User Clicks on Confirm Button of Confirm Order Page")]
        public void WhenUserClicksOnConfirmButtonOfConfirmOrderPage()
        {
            IWebElement confirmButton = driver.FindElement(By.XPath("(//button[@type='button'])[13]"));
            confirmButton.Click();
            Thread.Sleep(1000);
        }

        [Then(@"Order is Successfully Processed")]
        public void ThenOrderIsSuccessfullyProcessed()
        {
            IWebElement confirmMessage = driver.FindElement(By.XPath("//*[text()='Your order has been successfully processed!']"));
            string expextedMessage = "Your order has been successfully processed!";
            string actualMessage = confirmMessage.Text;
            Assert.AreEqual(expextedMessage, actualMessage);
            Thread.Sleep(1000);
        }
        [When(@"user Clicks on - Click Here For Order Details LinK")]
        public void WhenUserClicksOn_ClickHereForOrderDetailsLinK()
        {
            IWebElement orderInfoLink = driver.FindElement(By.ClassName("details-link"));
            orderInfoLink.Click();
        }

        [Then(@"User is Navigated to Order Information Page")]
        public void ThenUserIsNavigatedToOrderInformationPage()
        {
            string expectedTitle = "nopCommerce demo store. Order Details";
            string actualTitle = driver.Title;
            Console.WriteLine(actualTitle);
            Assert.AreEqual(expectedTitle, actualTitle);
        }

        [When(@"User Clicks on Logout link")]
        public void WhenUserClicksOnLogoutLink()
        {
            IWebElement myAccountLink = driver.FindElement(By.ClassName("ico-logout"));
            myAccountLink.Click();
        }

        [Then(@"Account is Logged out Successfully")]
        public void ThenAccountIsLoggedOutSuccessfully()
        {
            IWebElement expectedLinkCreated = driver.FindElement(By.ClassName("ico-login"));
            string actualLinkCreated = "Log in";
            Console.WriteLine(expectedLinkCreated.Text);
            Assert.AreEqual(actualLinkCreated, expectedLinkCreated.Text);
            Thread.Sleep(1000);

        }

        [Then(@"User closed The Browser")]
        public void ThenUserClosedTheBrowser()
        {
            driver.Quit();
        }

        // 2. Validate User Should Not Nevigate To Someone Else Order Info By Changing The Order ID In URL
        [Then(@"Order ID is Added To URL")]
        public void ThenOrderIDIsAddedToURL()
        {
            Console.WriteLine(driver.Url);
            Thread.Sleep(1000);
        }

        [When(@"User Changes the Order ID in URL and Launch the URL")]
        public void WhenUserChangesTheOrderIDInURLAndLaunchTheURL()
        {
            // Modified URL - Order ID Changed 
            string invalidURL = "https://demo.nopcommerce.com/orderdetails/1000";
            driver.Navigate().GoToUrl(invalidURL);
            Thread.Sleep(1000);
        }

        [Then(@"User is asked to login Again with Another Account")]
        public void ThenUserIsAskedToLoginAgainWithAnotherAccount()
        {
            string expectedMessage = "You are already logged in as Test1@email.com Test1@email.com. You may log in with another account.";
            IWebElement actualMessage = driver.FindElement(By.XPath("//p[text()='You are already logged in as Test1@email.com Test1@email.com. You may log in with another account.']"));
            Console.WriteLine(actualMessage.Text);
            Assert.AreEqual(expectedMessage, actualMessage.Text);
            driver.Quit();


        }
    }
}
