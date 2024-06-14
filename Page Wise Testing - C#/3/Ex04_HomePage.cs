using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Threading;

namespace AT_Assignment6_Project_NeelShukla
{
    [TestClass]
    public class Ex04_HomePage
    {
        [TestInitialize]
        public void setup()

        {
            //Launch The Google Browser With Inbuild Driver
            driver = new ChromeDriver(".");
            // Launch The NOPC App
            driver.Url = url;

        }


        // Writing This in Class Level So Further We Dont Need To Rewrite this Common Code Again & Again
        IWebDriver driver;
        string url = "https://demo.nopcommerce.com/";

        [TestMethod]

        public void TestMethod01_HomePageNavigation()
        {

            //Validate User is Navigated to Home Page After Successfull Login        

            // -------------- Now Click Login Link & Validate Login Function With Valid Credentials -------------- //
            IWebElement loginLink = driver.FindElement(By.ClassName("ico-login"));
            loginLink.Click();
            // Enter Email
            IWebElement emailField = driver.FindElement(By.Id("Email"));
            emailField.SendKeys("test5@nopc.com");
            // Enter Valid Password
            IWebElement passwordField = driver.FindElement(By.Id("Password"));
            passwordField.SendKeys("TestingFunc@009");
            // Click on Rememberme Checkbox
            IWebElement rememberMe = driver.FindElement(By.Id("RememberMe"));
            rememberMe.Click();
            // Click on Login Button
            IWebElement loginbutton = driver.FindElement(By.XPath("//button[@class='button-1 login-button']"));
            loginbutton.Click();
            Thread.Sleep(1000);
            IWebElement expectedLinkGenerated = driver.FindElement(By.LinkText("My account"));
            IWebElement actualLinkGenerated = driver.FindElement(By.LinkText("My account"));
            Assert.AreEqual(expectedLinkGenerated, actualLinkGenerated, "Login Failed.");
            Console.WriteLine("User is Navigated to HomePage Successfully");
        }


        [TestMethod]

        public void TestMethod02_ValidateMyAccountLink()
        {
            IWebElement loginLink = driver.FindElement(By.ClassName("ico-login"));
            loginLink.Click();
            // Enter Email
            IWebElement emailField = driver.FindElement(By.Id("Email"));
            emailField.SendKeys("test5@nopc.com");
            // Enter Valid Password
            IWebElement passwordField = driver.FindElement(By.Id("Password"));
            passwordField.SendKeys("TestingFunc@009");
            // Click on Rememberme Checkbox
            IWebElement rememberMe = driver.FindElement(By.Id("RememberMe"));
            rememberMe.Click();
            // Click on Login Button
            IWebElement loginbutton = driver.FindElement(By.XPath("//button[@class='button-1 login-button']"));
            loginbutton.Click();
            Thread.Sleep(1000);
            // Click on My Account link
            IWebElement myAccountLink = driver.FindElement(By.ClassName("ico-account"));
            myAccountLink.Click();
            String expectedTitle = "nopCommerce demo store. Account";
            string actualTitle = driver.Title;
            Assert.AreEqual(expectedTitle, actualTitle, "Link Not Working");
            Console.WriteLine("My Account Link is Working As Expected");
        }

        // Validate Log-out Link 

        [TestMethod]

        public void TestMethod03_ValidateLogoutLink()
        {
            IWebElement loginLink = driver.FindElement(By.ClassName("ico-login"));
            loginLink.Click();
            // Enter Email
            IWebElement emailField = driver.FindElement(By.Id("Email"));
            emailField.SendKeys("test5@nopc.com");
            // Enter Valid Password
            IWebElement passwordField = driver.FindElement(By.Id("Password"));
            passwordField.SendKeys("TestingFunc@009");
            // Click on Rememberme Checkbox
            IWebElement rememberMe = driver.FindElement(By.Id("RememberMe"));
            rememberMe.Click();
            // Click on Login Button
            IWebElement loginbutton = driver.FindElement(By.XPath("//button[@class='button-1 login-button']"));
            loginbutton.Click();
            Thread.Sleep(1000);

            IWebElement logOutLink = driver.FindElement(By.LinkText("Log out"));
            logOutLink.Click();
            String expectedTitle = driver.Title;
            string actualTitle = "nopCommerce demo store";
            Assert.AreEqual(expectedTitle, actualTitle, "Link Not Working");
            Console.WriteLine("Logout Link is Working As Expected");
        }






        [TestCleanup]

        public void cleanup()
        {

            driver.Quit();

        }
    }
}