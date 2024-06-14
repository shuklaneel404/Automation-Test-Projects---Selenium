using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Threading;
using TechTalk.SpecFlow;

namespace AT_FinalAssignment_Project_NeelShukla
{
    [Binding]
    public class Ex06_ProductDetailsPageStepDefinitions
    {
        IWebDriver driver;
        string url = "https://demo.nopcommerce.com/";

        // 1. Validate add to cart Functionality on Product Details Page
        [Given(@"User Launched the Chrome Browser")]
        public void GivenUserLaunchedTheChromeBrowser()
        {
            driver = new ChromeDriver(".");
            driver.Manage().Window.Maximize();
        }

        [Given(@"User Launched the App")]
        public void GivenUserLaunchedTheApp()
        {
            driver.Url = url;
        }

        [Given(@"User is on Landing Page\.")]
        public void GivenUserIsOnLandingPage_()
        {
            string expectedTitle = "nopCommerce demo store";
            string actualTitle = driver.Title;
            Console.WriteLine(actualTitle);
            Assert.AreEqual(expectedTitle, actualTitle);
        }

        [When(@"User Clicks On “\$(.*) Virtual Gift Card” Product Link")]
        public void WhenUserClicksOnVirtualGiftCardProductLink(int p0)
        {
            IWebElement giftCardLink = driver.FindElement(By.XPath("(//a[@href='/25-virtual-gift-card'])[2]"));
            giftCardLink.Click();
        }

        [Then(@"User is Navigated To Product Details Page of “\$(.*) Virtaul Gift Card”")]
        public void ThenUserIsNavigatedToProductDetailsPageOfVirtaulGiftCard(int p0)
        {
            string expectedTitle = "nopCommerce demo store. $25 Virtual Gift Card";
            string actualTitle = driver.Title;
            Console.WriteLine(actualTitle);
            Assert.AreEqual(expectedTitle, actualTitle);
        }

        [When(@"User Enters Recipient's Name:")]
        public void WhenUserEntersRecipientsName()
        {
            IWebElement recName = driver.FindElement(By.Id("giftcard_43_RecipientName"));
            recName.SendKeys("TESTER");
        }

        [When(@"User Enters Recipient's Email:")]
        public void WhenUserEntersRecipientsEmail()
        {
            IWebElement recEmail = driver.FindElement(By.Id("giftcard_43_RecipientEmail"));
            recEmail.SendKeys("automation@selenium.com");
        }

        [When(@"User Enters Your Name:")]
        public void WhenUserEntersYourName()
        {
            IWebElement myName = driver.FindElement(By.Id("giftcard_43_SenderName"));
            myName.SendKeys("Neel");
        }

        [When(@"USer Enters Your Email:")]
        public void WhenUSerEntersYourEmail()
        {
            IWebElement myEmail = driver.FindElement(By.Id("giftcard_43_SenderEmail"));
            myEmail.SendKeys("myemail@test.com");
        }

        [When(@"USer Enters Message")]
        public void WhenUSerEntersMessage()
        {
            IWebElement myMessage = driver.FindElement(By.Id("giftcard_43_Message"));
            myMessage.SendKeys("myemail@test.com");
        }

        [When(@"User Enter (.*) in Qty Text Box")]
        public void WhenUserEnterInQtyTextBox(string p0)
        {
            IWebElement myQTY = driver.FindElement(By.Id("product_enteredQuantity_43"));
            myQTY.Clear();
            myQTY.SendKeys(p0);
        }

        [When(@"User Clicks on Add to Cart Button")]
        public void WhenUserClicksOnAddToCartButton()
        {
            IWebElement addToCartButton = driver.FindElement(By.Id("add-to-cart-button-43"));
            addToCartButton.Click();
            Thread.Sleep(2000);
        }

        [Then(@"(.*) Qty Must be Added in Cart Successfully")]
        public void ThenQtyMustBeAddedInCartSuccessfully(int p0)
        {
            string expectedResult = "(2)";
            IWebElement actualResult = driver.FindElement(By.XPath("//span[@class='cart-qty']"));
            Console.WriteLine(actualResult.Text);
            Assert.AreEqual(expectedResult, actualResult.Text);
            Thread.Sleep(1000);
            driver.Quit();
        }

        //  2. validate Email a Friend Feature Without Login 
        [When(@"User Clicks On Email a Frined Button")]
        public void WhenUserClicksOnEmailAFrinedButton()
        {
            IWebElement emailFriendButton = driver.FindElement(By.XPath("//button[@class='button-2 email-a-friend-button']"));
            emailFriendButton.Click();
        }

        [Then(@"User is Navigated To Email a Friend Page")]
        public void ThenUserIsNavigatedToEmailAFriendPage()
        {
            string expectedTitle = "nopCommerce demo store. Email A Friend. $25 Virtual Gift Card";
            string actualTitle = driver.Title;
            Console.WriteLine(actualTitle);
            Assert.AreEqual(expectedTitle, actualTitle);
        }

        [When(@"User Enters ""([^""]*)"" in email field")]
        public void WhenUserEntersInEmailField(string p0)
        {
            IWebElement friendEmail = driver.FindElement(By.Id("FriendEmail"));
            friendEmail.SendKeys(p0);
        }

        [When(@"Enters ""([^""]*)"" in Your Email address Field")]
        public void WhenEntersInYourEmailAddressField(string p0)
        {
            IWebElement yourEmail = driver.FindElement(By.Id("YourEmailAddress"));
            yourEmail.SendKeys(p0);
        }

        [When(@"Enters PErsonal Message ""([^""]*)""")]
        public void WhenEntersPErsonalMessage(string p0)
        {
            IWebElement personalMessage = driver.FindElement(By.Id("PersonalMessage"));
            personalMessage.SendKeys(p0);
        }

        [When(@"CLicks on Send Email Button")]
        public void WhenCLicksOnSendEmailButton()
        {
            IWebElement sendEmailButton = driver.FindElement(By.XPath("//button[@class='button-1 send-email-a-friend-button']"));
            sendEmailButton.Click();
        }

        [Then(@"Error Message is Displayed - Only registered customers can use email a friend feature")]
        public void ThenErrorMessageIsDisplayed_OnlyRegisteredCustomersCanUseEmailAFriendFeature()
        {
            IWebElement errorMessageValidation = driver.FindElement(By.XPath("//div[@class='message-error validation-summary-errors']"));
            string actualMessage = "Only registered customers can use email a friend feature";
            Console.WriteLine(errorMessageValidation.Text);
            Assert.AreEqual(actualMessage, errorMessageValidation.Text);
            Thread.Sleep(1000);
            driver.Quit();
        }

    }
}
