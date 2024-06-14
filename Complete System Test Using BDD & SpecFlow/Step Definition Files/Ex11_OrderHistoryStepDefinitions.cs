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
    public class Ex11_OrderHistoryStepDefinitions
    {
        IWebDriver driver;
        string url = "https://demo.nopcommerce.com/";

        [Given(@"User Have Launched the Chrome  Browser")]
        public void GivenUserHaveLaunchedTheChromeBrowser()
        {
            driver = new ChromeDriver(".");
            driver.Manage().Window.Maximize();
        }

        [Given(@"App Is Launched\.")]
        public void GivenAppIsLaunched_()
        {
            driver.Url = url;
        }

        [Given(@"User is on the nopCommerce App Landing Page\.")]
        public void GivenUserIsOnTheNopCommerceAppLandingPage_()
        {
            string expectedTitle = "nopCommerce demo store";
            string actualTitle = driver.Title;
            Console.WriteLine(actualTitle);
            Assert.AreEqual(expectedTitle, actualTitle);
        }

        [When(@"User Clicks on the Login  Link\.")]
        public void WhenUserClicksOnTheLoginLink_()
        {
            IWebElement loginLink = driver.FindElement(By.ClassName("ico-login"));
            loginLink.Click();
        }

        [Then(@"User is Navigate to the Login Page  Successfully\.")]
        public void ThenUserIsNavigateToTheLoginPageSuccessfully_()
        {
            string expectedTitle = "nopCommerce demo store. Login";
            string actualTitle = driver.Title;
            Console.WriteLine(actualTitle);
            Assert.AreEqual(expectedTitle, actualTitle);
        }

        [When(@"User Has Entered the Valid Email  ""([^""]*)""\.")]
        public void WhenUserHasEnteredTheValidEmail_(string p0)
        {
            IWebElement emailField = driver.FindElement(By.Id("Email"));
            emailField.SendKeys(p0);
        }

        [When(@"User Has Entered the Valid Password  ""([^""]*)""\.")]
        public void WhenUserHasEnteredTheValidPassword_(string p0)
        {
            IWebElement passwordField = driver.FindElement(By.Id("Password"));
            passwordField.SendKeys(p0);
        }

        [When(@"Selects the Remember Me Field\.")]
        public void WhenSelectsTheRememberMeField_()
        {
            IWebElement rememberMe = driver.FindElement(By.Id("RememberMe"));
            rememberMe.Click();
        }

        [When(@"User Clicks On the Login  Button\.")]
        public void WhenUserClicksOnTheLoginButton_()
        {
            IWebElement loginbutton = driver.FindElement(By.XPath("//button[@class='button-1 login-button']"));
            loginbutton.Click();
            Thread.Sleep(1000);
        }

        [When(@"user clicks on add to cart button ofHTC mobile\.")]
        public void WhenUserClicksOnAddToCartButtonOfHTCMobile_()
        {
            IWebElement addToCartButton = driver.FindElement(By.XPath("(//button[@class='button-2 product-box-add-to-cart-button'])[3]"));
            addToCartButton.Click();
            Thread.Sleep(4000);
        }

        [When(@"Clicks On Shopping CartButton\.")]
        public void WhenClicksOnShoppingCartButton_()
        {
            IWebElement shoppingCartLink = driver.FindElement(By.ClassName("cart-label"));
            shoppingCartLink.Click();
            Thread.Sleep(1000);
        }

        [Then(@"User is Navigated toShopping Cart  Page\.")]
        public void ThenUserIsNavigatedToShoppingCartPage_()
        {
            string expectedTitle = "nopCommerce demo store. Shopping Cart";
            string actualTitle = driver.Title;
            Console.WriteLine(actualTitle);
            Assert.AreEqual(expectedTitle, actualTitle);
        }

        [Then(@"HTC Product is Added successfully\.")]
        public void ThenHTCProductIsAddedSuccessfully_()
        {
            string expectedText = "HTC One M8 Android L 5.0 Lollipop";
            IWebElement actualText = driver.FindElement(By.XPath("//a[@class='product-name']"));
            Console.WriteLine(actualText.Text);
            Assert.AreEqual(expectedText, actualText.Text);
            Thread.Sleep(1000);
        }

        [When(@"User Selects TermsandCondition Checkbox\.")]
        public void WhenUserSelectsTermsandConditionCheckbox_()
        {
            IWebElement termsCheckbox = driver.FindElement(By.Id("termsofservice"));
            termsCheckbox.Click();
        }

        [When(@"Clicks on Checkout Button\.")]
        public void WhenClicksOnCheckoutButton_()
        {
            IWebElement checkoutButton = driver.FindElement(By.Id("checkout"));
            checkoutButton.Click();
        }

        [Then(@"User is Navigated Checkout Page Successfully\.")]
        public void ThenUserIsNavigatedCheckoutPageSuccessfully_()
        {
            string expectedTitle = "nopCommerce demo store. Checkout";
            string actualTitle = driver.Title;
            Console.WriteLine(actualTitle);
            Assert.AreEqual(expectedTitle, actualTitle);
        }

        [When(@"User Selects India From Country DropBox\.")]
        public void WhenUserSelectsIndiaFromCountryDropBox_()
        {
            IWebElement countryDropBox = driver.FindElement(By.Id("BillingNewAddress_CountryId"));
            SelectElement countryDropBoxValue = new SelectElement(countryDropBox);
            countryDropBoxValue.SelectByIndex(100);
        }

        [When(@"Enters ""([^""]*)"" in City  Text Field\.")]
        public void WhenEntersInCityTextField_(string vadodara)
        {
            IWebElement cityField = driver.FindElement(By.Id("BillingNewAddress_City"));
            cityField.SendKeys(vadodara);
        }

        [When(@"Enters The ""([^""]*)"" in  Address(.*) Fiels\.")]
        public void WhenEntersTheInAddressFiels_(string myAddress, int p1)
        {
            IWebElement address1Field = driver.FindElement(By.Id("BillingNewAddress_Address1"));
            address1Field.SendKeys(myAddress + p1.ToString());
        }

        [When(@"Enters (.*) in Postalcode\.")]
        public void WhenEntersInPostalcode_(string p0)
        {
            IWebElement postalCode = driver.FindElement(By.Id("BillingNewAddress_ZipPostalCode"));
            postalCode.SendKeys(p0);
        }

        [When(@"Enters (.*) in phonenumber Field\.")]
        public void WhenEntersInPhonenumberField_(string p0)
        {
            IWebElement phoneNumber = driver.FindElement(By.Id("BillingNewAddress_PhoneNumber"));
            phoneNumber.SendKeys(p0);
            Thread.Sleep(1000);
        }

        [When(@"Clicks on Continue Button of  Billing Address\.")]
        public void WhenClicksOnContinueButtonOfBillingAddress_()
        {
            IWebElement continueBillingAdd = driver.FindElement(By.XPath("(//button[@class='button-1 new-address-next-step-button'])[1]"));
            continueBillingAdd.Click();
            Thread.Sleep(1000);
        }

        [When(@"User Selects Next Day Air  Radio Button\.")]
        public void WhenUserSelectsNextDayAirRadioButton_()
        {
            IWebElement radioButton1 = driver.FindElement(By.XPath("(//input[@name='shippingoption'])[2]"));
            radioButton1.Click();
        }

        [When(@"Clicks on Continue Button  of Shipping Method\.")]
        public void WhenClicksOnContinueButtonOfShippingMethod_()
        {
            IWebElement continue2 = driver.FindElement(By.XPath("//button[@class='button-1 shipping-method-next-step-button']"));
            continue2.Click();
            Thread.Sleep(1000);
        }

        [When(@"User Selects Credit Card  Radio Button")]
        public void WhenUserSelectsCreditCardRadioButton()
        {
            IWebElement paymentRadioButton1 = driver.FindElement(By.XPath("(//input[@name='paymentmethod'])[2]"));
            paymentRadioButton1.Click();

        }

        [When(@"User Clicks on Continue  Button of Payment Method")]
        public void WhenUserClicksOnContinueButtonOfPaymentMethod()
        {
            // Click on Continue button of payment
            IWebElement continue3 = driver.FindElement(By.XPath("//button[@class='button-1 payment-method-next-step-button']"));
            continue3.Click();
            Thread.Sleep(1000);
        }

        [When(@"Enters ""([^""]*)"" in Cardholder  name\.")]
        public void WhenEntersInCardholderName_(string scheme)
        {
            IWebElement cardHolderName = driver.FindElement(By.Id("CardholderName"));
            cardHolderName.SendKeys(scheme);
        }

        [When(@"Enters (.*) in Card  Number Field\.")]
        public void WhenEntersInCardNumberField_(string p0)
        {
            IWebElement cardNumber = driver.FindElement(By.Id("CardNumber"));
            cardNumber.SendKeys(p0);
        }

        [When(@"User Selects valid In ExpiraryDate, Month Dropdown Field\.")]
        public void WhenUserSelectsValidInExpiraryDateMonthDropdownField_()
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

        [When(@"Enters (.*) in Card Code  Field\.")]
        public void WhenEntersInCardCodeField_(string p0)
        {
            IWebElement cardCode = driver.FindElement(By.Id("CardCode"));
            cardCode.SendKeys(p0);
        }

        [When(@"Clicks on Continue of Payment  Info\.")]
        public void WhenClicksOnContinueOfPaymentInfo_()
        {
            IWebElement continue4 = driver.FindElement(By.XPath("//button[@class='button-1 payment-info-next-step-button']"));
            continue4.Click();
            Thread.Sleep(1000);
        }

        [When(@"User Clicks on Confirm Button of Confirm  Order Page\.")]
        public void WhenUserClicksOnConfirmButtonOfConfirmOrderPage_()
        {
            IWebElement confirmButton = driver.FindElement(By.XPath("(//button[@type='button'])[13]"));
            confirmButton.Click();
            Thread.Sleep(1000);
        }

        [Then(@"Order is Successfully  Processed\.")]
        public void ThenOrderIsSuccessfullyProcessed_()
        {
            IWebElement confirmMessage = driver.FindElement(By.XPath("//*[text()='Your order has been successfully processed!']"));
            string expextedMessage = "Your order has been successfully processed!";
            string actualMessage = confirmMessage.Text;
            Assert.AreEqual(expextedMessage, actualMessage);
            Thread.Sleep(1000);
        }

        [When(@"user Clicks on Click Here For Order Details  LinK")]
        public void WhenUserClicksOnClickHereForOrderDetailsLinK()
        {
            IWebElement orderInfoLink = driver.FindElement(By.ClassName("details-link"));
            orderInfoLink.Click();

        }

        [Then(@"User is Navigated to Order Information  Page")]
        public void ThenUserIsNavigatedToOrderInformationPage()
        {
            string expectedTitle = "nopCommerce demo store. Order Details";
            string actualTitle = driver.Title;
            Console.WriteLine(actualTitle);
            Assert.AreEqual(expectedTitle, actualTitle);

        }

        [When(@"User Clicks on Logout  Link\.")]
        public void WhenUserClicksOnLogoutLink_()
        {
            IWebElement myAccountLink = driver.FindElement(By.ClassName("ico-logout"));
            myAccountLink.Click();
        }

        [Then(@"User is Locked Out  Successfully")]
        public void ThenUserIsLockedOutSuccessfully()
        {
            IWebElement expectedLinkCreated = driver.FindElement(By.ClassName("ico-login"));
            string actualLinkCreated = "Log in";
            Console.WriteLine(expectedLinkCreated.Text);
            Assert.AreEqual(actualLinkCreated, expectedLinkCreated.Text);
            Thread.Sleep(1000);
            driver.Quit();
        }

        [Then(@"Browser is  Closed")]
        public void ThenBrowserIsClosed()
        {
            driver.Quit();
        }
    }
}
