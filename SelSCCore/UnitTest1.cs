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
            Driver = new ChromeDriver();

            Console.WriteLine("Setup");
        }

        [Test]
        public void Test1()
        {
            String ComboControlName = "ContentPlaceHolder1_AllMealsCombo";

            Driver.Navigate().GoToUrl("https://demowf.aspnetawesome.com");

            CustomControl.ComboBox("ContentPlaceHolder1_AllMealsCombo", "Oats");

            Assert.Pass();
        }
    }
}