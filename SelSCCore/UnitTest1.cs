using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SelSCCore.Pages;
using System;

namespace SelSCCore
{
    public class Tests: DriverHelper
    {
        

        [OneTimeSetUp]
        public void Setup()
        {
            ChromeOptions options = new ChromeOptions();
            options.AddArguments("--headless");
            options.AddArguments("window-size=1800x900");
            options.AddUserProfilePreference("download.default_directory", @"C:\Users\HP\Downloads");
            options.PageLoadStrategy = PageLoadStrategy.Normal;
            Driver = new ChromeDriver();

        }

        [Test]
        public void Test1()
        {

            Driver.Navigate().GoToUrl("https://demowf.aspnetawesome.com");

            CustomControl.ComboBox("ContentPlaceHolder1_AllMealsCombo", "Oats");

            Assert.Pass();
        }

        [Test]
        public void LoginTest()
        {

            Driver.Navigate().GoToUrl("http://eaapp.somee.com");

            HomePage homepage = new HomePage();
            LoginPage loginPage = new LoginPage();

            homepage.ClickLogin();
            loginPage.EnterUserNameAndPassword("admin", "password");
            loginPage.ClickLogin();

            Assert.That(homepage.IsLogOffExists(), Is.True, "msg is not exists");
        }
    }
}