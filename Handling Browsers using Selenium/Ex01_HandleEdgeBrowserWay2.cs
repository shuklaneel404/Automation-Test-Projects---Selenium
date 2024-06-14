﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using OpenQA.Selenium.Support.UI;
using System.Threading;
using OpenQA.Selenium.Edge;

namespace AT_Assignment2_Project_NeelShukla
{
    [TestClass]
    public class Ex01_HandleEdgeBrowserWay2
    {
        [TestMethod]
        public void TestMethod1()
        {
            //Launch The Edge Browser With External exe Path Method
            string driverPath = @"C:\Practice Repo\Assignments\AT_Assignment2_Solution_NeelShukla\AT_Assignment2_Project_NeelShukla\Drivers\";
            IWebDriver driver = new EdgeDriver(driverPath);

            // Launch The NOPC App

            driver.Url = "https://demo.nopcommerce.com/";

            // Capture App URL
            Console.WriteLine(driver.Url);

            // Capture Page Title & Validate Page Title By IF ELSE METHOD
            string expectedTitle = "nopCommerce demo store";
            string actualPageTitle = driver.Title;
            Console.WriteLine(actualPageTitle);
            if (Equals(actualPageTitle, expectedTitle))
            {
                Console.WriteLine("Test is passed & Page Title is Correct");
            }
            else
            {
                Console.WriteLine("Test is Failed - Page Title is Incorrect");
            }


            // Capture Page Source 
            Console.WriteLine(driver.PageSource);

            // Validate Page Title By Assert Method
            string expectedTitle2 = "nopCommerce demo store";
            string actualTitle2 = driver.Title;

            Console.WriteLine(actualTitle2);

            Assert.AreEqual(expectedTitle2, actualTitle2);



            //wait for 5 sec before quiting
            Thread.Sleep(3000);

            //Close The App
            driver.Quit();

        }
    }
}
