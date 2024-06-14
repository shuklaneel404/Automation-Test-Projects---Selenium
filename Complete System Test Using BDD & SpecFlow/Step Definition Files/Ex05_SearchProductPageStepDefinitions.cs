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

    // 1. validat user can search product with valid data: More than 3 characters 
    public class Ex05_SearchProductPageStepDefinitions
    {
        IWebDriver driver;
        string url = "https://demo.nopcommerce.com/";

        [Given(@"User Launched The Chrome Browser")]
        public void GivenUserLaunchedTheChromeBrowser()
        {
            driver = new ChromeDriver(".");
            driver.Manage().Window.Maximize();
        }

        [Given(@"User Launched App")]
        public void GivenUserLaunchedApp()
        {
            driver.Url = url;
        }

        [When(@"User Clicks on Search Link from Footer")]
        public void WhenUserClicksOnSearchLinkFromFooter()
        {
            IWebElement searchLinkFooter = driver.FindElement(By.XPath("//a[@href='/search']"));
            searchLinkFooter.Click();
        }

        [Then(@"User Redirects To Search Product Page")]
        public void ThenUserRedirectsToSearchProductPage()
        {
            string expectedTitle = "nopCommerce demo store. Search";
            string actualTitle = driver.Title;
            Console.WriteLine(actualTitle);
            Assert.AreEqual(expectedTitle, actualTitle);
        }

        [When(@"User Search Products With More Than (.*) Characters")]
        public void WhenUserSearchProductsWithMoreThanCharacters(int p0)
        {
            IWebElement searchField = driver.FindElement(By.XPath("(//input[@type='text'])[2]"));
            searchField.SendKeys("Lenovo");
            IWebElement searchButton = driver.FindElement(By.XPath("(//button[@type='submit'])[2]"));
            searchButton.Click();
        }

        [Then(@"Product Search is Successfull")]
        public void ThenProductSearchIsSuccessfull()
        {
            // Validatation of Product is Searched Successfully
            IWebElement expectedLinkText = driver.FindElement(By.LinkText("Lenovo IdeaCentre 600 All-in-One PC"));
            string actualLinkText = "Lenovo IdeaCentre 600 All-in-One PC";
            Console.WriteLine(expectedLinkText.Text);
            Assert.AreEqual(actualLinkText, expectedLinkText.Text);
            Thread.Sleep(1000);
            driver.Quit();
        }

        // 2. Validate Search Functionality with Invalid Data - less than 3 characters
        [When(@"User Search Products With Less Than (.*) Characters")]
        public void WhenUserSearchProductsWithLessThanCharacters(int p0)
        {
            IWebElement searchField = driver.FindElement(By.XPath("(//input[@type='text'])[2]"));
            searchField.SendKeys("Le");
            IWebElement searchButton = driver.FindElement(By.XPath("(//button[@type='submit'])[2]"));
            searchButton.Click();
        }

        [Then(@"Error Must Be Displayed - Search term minimum length is (.*) characters")]
        public void ThenErrorMustBeDisplayed_SearchTermMinimumLengthIsCharacters(int p0)
        {
            IWebElement errorMessageValidation = driver.FindElement(By.XPath("//div[@class='warning']"));
            string actualMessage = "Search term minimum length is 3 characters";
            Console.WriteLine(errorMessageValidation.Text);
            Assert.AreEqual(actualMessage, errorMessageValidation.Text);
            Thread.Sleep(1000);
            driver.Quit();
        }

        // 3. Validate Advance Search Functionality
        [When(@"User Search Products With Valid Data")]
        public void WhenUserSearchProductsWithValidData()
        {
            IWebElement searchField = driver.FindElement(By.XPath("(//input[@type='text'])[2]"));
            searchField.SendKeys("Apple");
        }

        [When(@"User Clicks on Advance Search Checkbox")]
        public void WhenUserClicksOnAdvanceSearchCheckbox()
        {
            IWebElement advanceSearchCheckBox = driver.FindElement(By.Id("advs"));
            advanceSearchCheckBox.Click();
            Console.WriteLine("Advance Search Checkbox Selected = " + advanceSearchCheckBox.Selected);
        }

        [When(@"User Selects Electronics From Category DropBox")]
        public void WhenUserSelectsElectronicsFromCategoryDropBox()
        {
            IWebElement categoryDropBox = driver.FindElement(By.Id("cid"));
            SelectElement dropdown1 = new SelectElement(categoryDropBox);
            dropdown1.SelectByText("Electronics");
        }

        [When(@"user Selects Automatically Search Sub Categories Checkbox")]
        public void WhenUserSelectsAutomaticallySearchSubCategoriesCheckbox()
        {
            IWebElement checkBox2 = driver.FindElement(By.Id("isc"));
            checkBox2.Click();
            Console.WriteLine("Advance Search Checkbox Selected = " + checkBox2.Selected);
        }

        [When(@"User Selects Apple From Manufacturer DropBox")]
        public void WhenUserSelectsAppleFromManufacturerDropBox()
        {
            IWebElement manufacterDropBox = driver.FindElement(By.Id("mid"));
            SelectElement dropdown2 = new SelectElement(manufacterDropBox);
            dropdown2.SelectByText("Apple");
            IWebElement searchButton = driver.FindElement(By.XPath("(//button[@type='submit'])[2]"));
            searchButton.Click();
        }

        [Then(@"Apple icam Product Should Be Displayed")]
        public void ThenAppleIcamProductShouldBeDisplayed()
        {
            IWebElement expectedLinkText = driver.FindElement(By.LinkText("Apple iCam"));
            string actualLinkText = "Apple iCam";
            Console.WriteLine(expectedLinkText.Text);
            Assert.AreEqual(actualLinkText, expectedLinkText.Text);
            Thread.Sleep(1000);
            driver.Quit();
        }


    }
}
