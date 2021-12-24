using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace SelSCCore
{
    public class Tests: DriverHelper
    {
        

        [SetUp]
        public void Setup()
        {
            ChromeOptions options = new ChromeOptions();
            options.AddArguments("--headless");

            Console.WriteLine("Setup");
            Driver = new ChromeDriver();
        }

        [Test]
        public void Test1()
        {

            Driver.Navigate().GoToUrl("https://demowf.aspnetawesome.com");

            CustomControl.ComboBox("ContentPlaceHolder1_AllMealsCombo", "Oats");

            Assert.Pass();
        }
    }
}