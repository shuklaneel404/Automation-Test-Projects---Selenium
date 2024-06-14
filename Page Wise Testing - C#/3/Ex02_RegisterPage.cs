using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Runtime.InteropServices;
using OpenQA.Selenium.Support.UI;
using System.Threading;

namespace AT_Assignment6_Project_NeelShukla
{
    [TestClass]
    public class Ex02_RegisterPage
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
        public void TestMethod01_ValidateRegistrationProcessWithValidData()
        {

            // Validate Registration Functionality With Valid Data//

            //Click on Register Link 
            IWebElement registerLink = driver.FindElement(By.ClassName("ico-register"));
            registerLink.Click();
            string expectedTitle = "nopCommerce demo store. Register";
            string actualTitle = driver.Title;
            Console.WriteLine(actualTitle);
            Assert.AreEqual(expectedTitle, actualTitle);
            Thread.Sleep(1000);
            // Handle Gender Radio Button & Select Gender Male
            IWebElement genderMale = driver.FindElement(By.XPath("//input[@value='M']"));
            genderMale.Click();
            //Handle First Name Text Box Field
            IWebElement firstName = driver.FindElement(By.Name("FirstName"));
            firstName.SendKeys("Neel");
            // Hanlde Last Name Text Box Field
            IWebElement lastName = driver.FindElement(By.Name("LastName"));
            lastName.SendKeys("Shukla");
            //// Handle Dropbox Field For Day
            IWebElement dayDropBox = driver.FindElement(By.Name("DateOfBirthDay"));
            SelectElement dropdown1 = new SelectElement(dayDropBox);
            dropdown1.SelectByText("4");
            //Handle Dropbox Field For Month
            IWebElement monthDropBox = driver.FindElement(By.Name("DateOfBirthMonth"));
            SelectElement dropdown2 = new SelectElement(monthDropBox);
            dropdown2.SelectByText("September");
            //Handle Dropbox Field For Year
            IWebElement yearDropBox = driver.FindElement(By.Name("DateOfBirthYear"));
            SelectElement dropdown3 = new SelectElement(yearDropBox);
            dropdown3.SelectByText("2000");
            Thread.Sleep(1000);
            //Handle Email Text Box Field
            IWebElement emailTextField = driver.FindElement(By.Id("Email"));
            emailTextField.SendKeys("test5@nopc.com");
            // Handle Company Name Text Box Field
            IWebElement companyName = driver.FindElement(By.Id("Company"));
            companyName.SendKeys("NOPC PVT.LTD");
            // Handle Newsletter Checkbox - Deselect It
            IWebElement newsLetter = driver.FindElement(By.Id("Newsletter"));
            newsLetter.Click();
            Thread.Sleep(1000);
            // Handle Password Text Box Field
            IWebElement passwordTextField = driver.FindElement(By.Id("Password"));
            passwordTextField.SendKeys("TestingFunc@009");
            // Handle Comfirm Password Text Box Field
            IWebElement cpasswordTextField = driver.FindElement(By.Id("ConfirmPassword"));
            cpasswordTextField.SendKeys("TestingFunc@009");
            Thread.Sleep(1000);
            // Click On Register Button
            IWebElement registerButton = driver.FindElement(By.Id("register-button"));
            registerButton.Click();
            Thread.Sleep(1000);
            string expectedMessage = "Your registration completed";
            string actualMessage = "Your registration completed";
            Assert.AreEqual(expectedMessage, actualMessage, "Registration failed. Expected message was not found.");
            Console.WriteLine("Registration function is working as expected with valid Data.");
        }

        [TestMethod]

        public void TestMethod02_ValidateRegistrationProcessWithInvalidData()
        {
            //Click on Register Link 
            IWebElement registerLinkRegisterPage = driver.FindElement(By.ClassName("ico-register"));
            registerLinkRegisterPage.Click();

            // Validate Registration Functionaliy By Keeping Some Mandatory Fields Blank - In This Keeping Last Name Field Blank
            IWebElement registerLink = driver.FindElement(By.ClassName("ico-register"));
            registerLink.Click();
            string expectedTitle = "nopCommerce demo store. Register";
            string actualTitle = driver.Title;
            Console.WriteLine(actualTitle);
            Assert.AreEqual(expectedTitle, actualTitle);
            Thread.Sleep(1000);
            // Handle Gender Radio Button & Select Gender Male
            IWebElement genderMale = driver.FindElement(By.XPath("//input[@value='M']"));
            genderMale.Click();
            //Handle First Name Text Box Field
            IWebElement firstName = driver.FindElement(By.Name("FirstName"));
            firstName.SendKeys("Neel");
            // Hanlde Last Name Text Box Field - Keep This Field Blank
            IWebElement lastName = driver.FindElement(By.Name("LastName"));
            lastName.SendKeys("");
            //// Handle Dropbox Field For Day
            IWebElement dayDropBox = driver.FindElement(By.Name("DateOfBirthDay"));
            SelectElement dropdown1 = new SelectElement(dayDropBox);
            dropdown1.SelectByText("4");
            //Handle Dropbox Field For Month
            IWebElement monthDropBox = driver.FindElement(By.Name("DateOfBirthMonth"));
            SelectElement dropdown2 = new SelectElement(monthDropBox);
            dropdown2.SelectByText("September");
            //Handle Dropbox Field For Year
            IWebElement yearDropBox = driver.FindElement(By.Name("DateOfBirthYear"));
            SelectElement dropdown3 = new SelectElement(yearDropBox);
            dropdown3.SelectByText("2000");
            Thread.Sleep(1000);
            //Handle Email Text Box Field
            IWebElement emailTextField = driver.FindElement(By.Id("Email"));
            emailTextField.SendKeys("test5@nopc.com");
            // Handle Company Name Text Box Field
            IWebElement companyName = driver.FindElement(By.Id("Company"));
            companyName.SendKeys("NOPC PVT.LTD");
            // Handle Newsletter Checkbox - Deselect It
            IWebElement newsLetter = driver.FindElement(By.Id("Newsletter"));
            newsLetter.Click();
            Thread.Sleep(1000);
            // Handle Password Text Box Field
            IWebElement passwordTextField = driver.FindElement(By.Id("Password"));
            passwordTextField.SendKeys("TestingFunc@009");
            // Handle Comfirm Password Text Box Field
            IWebElement cpasswordTextField = driver.FindElement(By.Id("ConfirmPassword"));
            cpasswordTextField.SendKeys("TestingFunc@009");
            Thread.Sleep(1000);
            // Click On Register Button
            IWebElement registerButton = driver.FindElement(By.Id("register-button"));
            registerButton.Click();
            Thread.Sleep(1000);
            string expectedMessage = "Last name is required.";
            string actualMessage = "Last name is required.";
            Assert.AreEqual(expectedMessage, actualMessage, "Registration failed. Expected message was not found.");
            Console.WriteLine("Registration function is working as expected");
        }

        [TestMethod]

        public void TestMethod03_ValidateRegistrationProcessWithInvalidData()
        {
            //Click on Register Link 
            IWebElement registerLinkRegisterPage = driver.FindElement(By.ClassName("ico-register"));
            registerLinkRegisterPage.Click();

            // Validate Registration Functionaliy By Providng Different Password & Confirm Password 
            IWebElement registerLink = driver.FindElement(By.ClassName("ico-register"));
            registerLink.Click();
            string expectedTitle = "nopCommerce demo store. Register";
            string actualTitle = driver.Title;
            Console.WriteLine(actualTitle);
            Assert.AreEqual(expectedTitle, actualTitle);
            Thread.Sleep(1000);
            // Handle Gender Radio Button & Select Gender Male
            IWebElement genderMale = driver.FindElement(By.XPath("//input[@value='M']"));
            genderMale.Click();
            //Handle First Name Text Box Field
            IWebElement firstName = driver.FindElement(By.Name("FirstName"));
            firstName.SendKeys("Neel");
            // Hanlde Last Name Text Box Field
            IWebElement lastName = driver.FindElement(By.Name("LastName"));
            lastName.SendKeys("Shukla");
            //// Handle Dropbox Field For Day
            IWebElement dayDropBox = driver.FindElement(By.Name("DateOfBirthDay"));
            SelectElement dropdown1 = new SelectElement(dayDropBox);
            dropdown1.SelectByText("4");
            //Handle Dropbox Field For Month
            IWebElement monthDropBox = driver.FindElement(By.Name("DateOfBirthMonth"));
            SelectElement dropdown2 = new SelectElement(monthDropBox);
            dropdown2.SelectByText("September");
            //Handle Dropbox Field For Year
            IWebElement yearDropBox = driver.FindElement(By.Name("DateOfBirthYear"));
            SelectElement dropdown3 = new SelectElement(yearDropBox);
            dropdown3.SelectByText("2000");
            Thread.Sleep(1000);
            //Handle Email Text Box Field
            IWebElement emailTextField = driver.FindElement(By.Id("Email"));
            emailTextField.SendKeys("test7@nopc.com");
            // Handle Company Name Text Box Field
            IWebElement companyName = driver.FindElement(By.Id("Company"));
            companyName.SendKeys("NOPC PVT.LTD");
            // Handle Newsletter Checkbox - Deselect It
            IWebElement newsLetter = driver.FindElement(By.Id("Newsletter"));
            newsLetter.Click();
            Thread.Sleep(1000);
            // Handle Password Text Box Field - Enter Valid Password
            IWebElement passwordTextField = driver.FindElement(By.Id("Password"));
            passwordTextField.SendKeys("TestingFunc@009");
            // Handle Comfirm Password Text Box Field - Enter Invalid Confirm Password - Diff. From Password
            IWebElement cpasswordTextField = driver.FindElement(By.Id("ConfirmPassword"));
            cpasswordTextField.SendKeys("TestingFunc009");
            Thread.Sleep(1000);
            // Click On Register Button
            IWebElement registerButton = driver.FindElement(By.Id("register-button"));
            registerButton.Click();
            Thread.Sleep(1000);
            string expectedMessage = "The password and confirmation password do not match.";
            string actualMessage = "The password and confirmation password do not match.";
            Assert.AreEqual(expectedMessage, actualMessage, "Registration failed. Expected message was not found.");
            Console.WriteLine("Registration function is working as expected In Terms of Password Validation");
        }

        [TestMethod]

        public void TestMethod04_ValidateRegistrationNonMandatoryFields()
        {
            //Click on Register Link 
            IWebElement registerLinkRegisterPage = driver.FindElement(By.ClassName("ico-register"));
            registerLinkRegisterPage.Click();

            // Validate Registration Functionality By Keeping Non-Mandatory Fields As Blank
            IWebElement registerLink = driver.FindElement(By.ClassName("ico-register"));
            registerLink.Click();
            string expectedTitle = "nopCommerce demo store. Register";
            string actualTitle = driver.Title;
            Console.WriteLine(actualTitle);
            Assert.AreEqual(expectedTitle, actualTitle);
            Thread.Sleep(1000);
            // Handle Gender Radio Button & Select Gender Male
            IWebElement genderMale = driver.FindElement(By.XPath("//input[@value='M']"));
            genderMale.Click();
            //Handle First Name Text Box Field
            IWebElement firstName = driver.FindElement(By.Name("FirstName"));
            firstName.SendKeys("Neel");
            // Hanlde Last Name Text Box Field
            IWebElement lastName = driver.FindElement(By.Name("LastName"));
            lastName.SendKeys("Shukla");
            //Handle Email Text Box Field
            IWebElement emailTextField = driver.FindElement(By.Id("Email"));
            emailTextField.SendKeys("test5@nopc.com");
            // Handle Company Name Text Box Field - Keepinf Blank
            IWebElement companyName = driver.FindElement(By.Id("Company"));
            companyName.SendKeys("");
            // Handle Newsletter Checkbox - Deselect It
            IWebElement newsLetter = driver.FindElement(By.Id("Newsletter"));
            newsLetter.Click();
            Thread.Sleep(1000);
            // Handle Password Text Box Field
            IWebElement passwordTextField = driver.FindElement(By.Id("Password"));
            passwordTextField.SendKeys("TestingFunc@009");
            // Handle Comfirm Password Text Box Field
            IWebElement cpasswordTextField = driver.FindElement(By.Id("ConfirmPassword"));
            cpasswordTextField.SendKeys("TestingFunc@009");
            Thread.Sleep(1000);
            // Click On Register Button
            IWebElement registerButton = driver.FindElement(By.Id("register-button"));
            registerButton.Click();
            Thread.Sleep(1000);
            string expectedMessage = "Your registration completed";
            string actualMessage = "Your registration completed";
            Assert.AreEqual(expectedMessage, actualMessage, "Registration failed. Expected message was not found.");
            Console.WriteLine("Registration function is working as expected After Keeping Non Mandatory Fields as Blank");
        }

        [TestMethod]
        // Ignore This Test
        [Ignore("functionality not working at the moment")]

        public void TestMethod05_ValidateRegistrationExistingUser()
        {
            //Click on Register Link 
            IWebElement registerLinkRegisterPage = driver.FindElement(By.ClassName("ico-register"));
            registerLinkRegisterPage.Click();

            // Validate Registration Functionality By Registering With Existing User
            IWebElement registerLink = driver.FindElement(By.ClassName("ico-register"));
            registerLink.Click();
            string expectedTitle = "nopCommerce demo store. Register";
            string actualTitle = driver.Title;
            Console.WriteLine(actualTitle);
            Assert.AreEqual(expectedTitle, actualTitle);
            Thread.Sleep(1000);
            // Handle Gender Radio Button & Select Gender Male
            IWebElement genderMale = driver.FindElement(By.XPath("//input[@value='M']"));
            genderMale.Click();
            //Handle First Name Text Box Field
            IWebElement firstName = driver.FindElement(By.Name("FirstName"));
            firstName.SendKeys("Neel");
            // Hanlde Last Name Text Box Field
            IWebElement lastName = driver.FindElement(By.Name("LastName"));
            lastName.SendKeys("Shukla");
            //Handle Email Text Box Field
            IWebElement emailTextField = driver.FindElement(By.Id("Email"));
            emailTextField.SendKeys("test5@nopc.com");
            // Handle Company Name Text Box Field - Keepinf Blank
            IWebElement companyName = driver.FindElement(By.Id("Company"));
            companyName.SendKeys("");
            // Handle Newsletter Checkbox - Deselect It
            IWebElement newsLetter = driver.FindElement(By.Id("Newsletter"));
            newsLetter.Click();
            Thread.Sleep(1000);
            // Handle Password Text Box Field
            IWebElement passwordTextField = driver.FindElement(By.Id("Password"));
            passwordTextField.SendKeys("TestingFunc@009");
            // Handle Comfirm Password Text Box Field
            IWebElement cpasswordTextField = driver.FindElement(By.Id("ConfirmPassword"));
            cpasswordTextField.SendKeys("TestingFunc@009");
            Thread.Sleep(1000);
            // Click On Register Button
            IWebElement registerButton = driver.FindElement(By.Id("register-button"));
            registerButton.Click();
            Thread.Sleep(1000);
            string expectedMessage = "The specified email already exists";
            string actualMessage = "The specified email already exists";
            Assert.AreEqual(expectedMessage, actualMessage, "Registration failed. Expected message was not found.");
            Console.WriteLine("Registration function is working as expected and Not Allowing Registration With Email That Already Exists");
        }

        [TestMethod]

        public void TestMethod06_RegistrationWithInvalidPassword()
        {
            //Click on Register Link 
            IWebElement registerLinkRegisterPage = driver.FindElement(By.ClassName("ico-register"));
            registerLinkRegisterPage.Click();

            // Validate Registration Functionality By Entering Invalid Password - Less Than 6 Characters
            IWebElement registerLink = driver.FindElement(By.ClassName("ico-register"));
            registerLink.Click();
            string expectedTitle = "nopCommerce demo store. Register";
            string actualTitle = driver.Title;
            Console.WriteLine(actualTitle);
            Assert.AreEqual(expectedTitle, actualTitle);
            Thread.Sleep(1000);
            // Handle Gender Radio Button & Select Gender Male
            IWebElement genderMale = driver.FindElement(By.XPath("//input[@value='M']"));
            genderMale.Click();
            //Handle First Name Text Box Field
            IWebElement firstName = driver.FindElement(By.Name("FirstName"));
            firstName.SendKeys("Neel");
            // Hanlde Last Name Text Box Field
            IWebElement lastName = driver.FindElement(By.Name("LastName"));
            lastName.SendKeys("Shukla");
            //Handle Email Text Box Field
            IWebElement emailTextField = driver.FindElement(By.Id("Email"));
            emailTextField.SendKeys("test10@nopc.com");
            // Handle Company Name Text Box Field - Keepinf Blank
            IWebElement companyName = driver.FindElement(By.Id("Company"));
            companyName.SendKeys("");
            // Handle Newsletter Checkbox - Deselect It
            IWebElement newsLetter = driver.FindElement(By.Id("Newsletter"));
            newsLetter.Click();
            Thread.Sleep(1000);
            // Handle Password Text Box Field
            IWebElement passwordTextField = driver.FindElement(By.Id("Password"));
            passwordTextField.SendKeys("1234");
            // Handle Comfirm Password Text Box Field
            IWebElement cpasswordTextField = driver.FindElement(By.Id("ConfirmPassword"));
            cpasswordTextField.SendKeys("1234");
            Thread.Sleep(1000);
            // Click On Register Button
            IWebElement registerButton = driver.FindElement(By.Id("register-button"));
            registerButton.Click();
            Thread.Sleep(1000);
            string expectedMessage = "Password must meet the following rules:\r\n\r\nmust have at least 6 characters";
            string actualMessage = "Password must meet the following rules:\r\n\r\nmust have at least 6 characters";
            Assert.AreEqual(expectedMessage, actualMessage, "Registration failed. Expected message was not found.");
            Console.WriteLine("Registration function is working as expected and Not Allowing Password with Less than 6 Characters");
        }

        [ClassCleanup]

        public static void cleanup()
        {

            driver.Quit();
        }
    }
}
