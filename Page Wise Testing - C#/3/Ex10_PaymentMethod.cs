using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Threading;
using OpenQA.Selenium.Support.UI;

namespace AT_Assignment6_Project_NeelShukla
{
    [TestClass]
    public class Ex10_PaymentMethod
    {

        IWebDriver driver;
        //Navigate to landing page
        string url = "https://demo.nopcommerce.com/";

        [TestInitialize]
        public void init()
        {
            driver = new ChromeDriver(".");
            driver.Url = url;
        }

        [TestMethod]

        public void TestMethod01_PaymentMethod()
        {
            //click on addtocart button
            IWebElement addToCart = driver.FindElement(By.XPath("(//button[@class='button-2 product-box-add-to-cart-button'])[3]"));
            addToCart.Click();
            Thread.Sleep(3000);
            //click on shopping cart link
            IWebElement shoppingCartLink = driver.FindElement(By.XPath("//span[@class='cart-label']"));
                    
                        
            //click on terms of service checkbox
            IWebElement termsOfService = driver.FindElement(By.Id("termsofservice"));
            termsOfService.Click();
            Thread.Sleep(2000);

            //click  checkout button
            IWebElement checkoutButton = driver.FindElement(By.XPath("(//button[@type='submit'])[6]"));
            checkoutButton.Click();
            // Click on Checkout As Guest
            IWebElement checkoutAsGuest = driver.FindElement(By.LinkText("Checkout as Guest"));
            checkoutAsGuest.Click();

            driver.Navigate().GoToUrl("https://demo.nopcommerce.com/onepagecheckout#opc-billing");
            Thread.Sleep(2000);
            //enter valid data in firstname field
            IWebElement firstnameField = driver.FindElement(By.Name("BillingNewAddress.FirstName"));
            firstnameField.SendKeys("Neel");
            Thread.Sleep(2000);

            //enter valid data in Lastname field
            IWebElement lastnameField = driver.FindElement(By.Id("BillingNewAddress_LastName"));
            lastnameField.SendKeys("Shukla");
            Thread.Sleep(2000);

            //Enter valid email data in email field
            IWebElement email = driver.FindElement(By.Id("BillingNewAddress_Email"));
            email.SendKeys("test001@nopc.com");
            Thread.Sleep(2000);


            //enter valid data in company field
            IWebElement companydetails = driver.FindElement(By.Id("BillingNewAddress_CountryId"));
            companydetails.SendKeys("TESTNOPC");
            Thread.Sleep(2000);

            //select country from country dropdown
            IWebElement country = driver.FindElement(By.Name("BillingNewAddress.CountryId"));
            SelectElement dropdown3 = new SelectElement(country);
            dropdown3.SelectByIndex(3);
            Thread.Sleep(2000);

            //enter data in city field
            IWebElement city = driver.FindElement(By.Id("BillingNewAddress_City"));
            city.SendKeys("MyAddress");
            Thread.Sleep(2000);

            //enter data in address1 field
            IWebElement address1 = driver.FindElement(By.Id("BillingNewAddress_Address1"));
            address1.SendKeys("MyAddress2");
            Thread.Sleep(2000);

            //enter data in zipcode field
            IWebElement zipcode = driver.FindElement(By.Id("BillingNewAddress_ZipPostalCode"));
            zipcode.SendKeys("390100");
            Thread.Sleep(2000);

            //enter data in phonenumber field
            IWebElement phonenumber = driver.FindElement(By.Id("BillingNewAddress_PhoneNumber"));
            phonenumber.SendKeys("9876543210");
            Thread.Sleep(2000);

            //click on continue button
            IWebElement continuebutton = driver.FindElement(By.XPath("(//button[@type='button'])[5]"));
            continuebutton.Click();
            Thread.Sleep(2000);

            //click on ground shipping method
            IWebElement shippingmethod = driver.FindElement(By.Id("shippingoption_0"));
            shippingmethod.Click();
            Thread.Sleep(2000);

            //click on air shipping method
            IWebElement shippingmethod1 = driver.FindElement(By.Id("shippingoption_1"));
            shippingmethod1.Click();
            Thread.Sleep(2000);

            //click on continue button
            IWebElement continuebutton1 = driver.FindElement(By.XPath("(//button[@type='button'])[10]"));
            continuebutton1.Click();
            Thread.Sleep(2000);

            //select a payment method
            IWebElement paymentmethod = driver.FindElement(By.Id("paymentmethod_0"));
            paymentmethod.Click();
            Thread.Sleep(2000);

            //click on continue button
            IWebElement continueButton3 = driver.FindElement(By.XPath("(//button[@type='button'])[11]"));
            continueButton3.Click();
            Thread.Sleep(2000);

            //click on continue button
            IWebElement continuButton4 = driver.FindElement(By.XPath("(//button[@type='button'])[12]"));
            continuButton4.Click();
            Thread.Sleep(2000);

            //click on confirm button
            IWebElement confirmButton = driver.FindElement(By.XPath("(//button[@type='button'])[13]"));
            confirmButton.Click();
            Thread.Sleep(2000);

        }

        [TestCleanup]
        public void Cleanup()
        {
            driver.Quit();
        }
    }
}
