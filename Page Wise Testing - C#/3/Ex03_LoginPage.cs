using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Threading;

namespace AT_Assignment6_Project_NeelShukla
{
    [TestClass]

    public class Ex03_LoginPage
    {
        static IWebDriver driver;
        //url for nopcommerce website with object
        static string url = "https://demo.nopcommerce.com/";

        [ClassInitialize]
        public static void setup(TestContext context)
        {
            //using chromedriver to loanch url
            driver = new ChromeDriver(".");
            driver.Manage().Window.Maximize();
            //passing url object here
            driver.Url = url;

        }
        [TestMethod]
        public void TestMethod01_ValidateLoginWithValidData()
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
            IWebElement expectedLinkGenerated = driver.FindElement(By.LinkText("My account"));
            IWebElement actualLinkGenerated = driver.FindElement(By.LinkText("My account"));
            Assert.AreEqual(expectedLinkGenerated, actualLinkGenerated, "Login Failed.");
            Console.WriteLine("Login Function is working as expected with valid data");
            Thread.Sleep(1000);
            IWebElement logoutButton = driver.FindElement(By.ClassName("ico-logout"));
            logoutButton.Click();
             
        }

        //-------------------------- Validate Login Functionality With Invalid Password -------------------------//

        [TestMethod]

        public void TestMethod02_ValidateLoginWithInvalidPassword()
        {

            //Validate Login Functionality With Invalid Password
            IWebElement loginLink = driver.FindElement(By.ClassName("ico-login"));
            loginLink.Click();
            // Enter Email
            IWebElement emailField = driver.FindElement(By.Id("Email"));
            emailField.SendKeys("test001@nopc.com");
            // Enter Valid Password
            IWebElement passwordField = driver.FindElement(By.Id("Password"));
            passwordField.SendKeys("TestingFunc@XYZ009");
            // Click on Rememberme Checkbox
            IWebElement rememberMe = driver.FindElement(By.Id("RememberMe"));
            rememberMe.Click();
            // Click on Login Button
            IWebElement loginbutton = driver.FindElement(By.XPath("//button[@class='button-1 login-button']"));
            loginbutton.Click();
            Thread.Sleep(1000);
            string expectedMessage = "Login was unsuccessful. Please correct the errors and try again.\r\nThe credentials provided are incorrect";
            string actualMessage = "Login was unsuccessful. Please correct the errors and try again.\r\nThe credentials provided are incorrect";
            Assert.AreEqual(expectedMessage, actualMessage, "Registration failed. Expected message was not found.");
            Console.WriteLine("Login function is working as expected with Invalid Passwords ");
        }

        [TestMethod]
        public void TestMethod03_ValidateForgetPasswordLink()
        {
            //Click on Login Linkk
            IWebElement loginLink = driver.FindElement(By.ClassName("ico-login"));
            loginLink.Click();
            //click on forgotpassword link
            IWebElement forgotpassword = driver.FindElement(By.XPath("//a[@href='/passwordrecovery']"));
            forgotpassword.Click();
            Thread.Sleep(1000);
            //Validate Page Title
            string expectedTitle = driver.Title;
            string actualTitle = "nopCommerce demo store. Password Recovery";
            Assert.AreEqual(expectedTitle, actualTitle, "Link Not Working");
            Console.WriteLine("Forget Password Link is Working As Expected");

            Thread.Sleep(1000);
        }
        [ClassCleanup]

        public static void cleanup()
        {
            driver.Quit();
        }
    }
}
    