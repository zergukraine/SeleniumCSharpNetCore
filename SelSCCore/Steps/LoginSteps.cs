using NUnit.Framework;
using SelSCCore.Pages;
using System;
using System.Collections.Generic;
using System.Text;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace SelSCCore.Steps 
{

    [Binding]
    public class LoginSteps : DriverHelper
    {

        HomePage homepage = new HomePage();
        LoginPage loginPage = new LoginPage();


        [Given(@"I navigate to the app")]
        public void GivenINavigateToTheApp()
        {
            Driver.Navigate().GoToUrl("https://demowf.aspnetawesome.com");
        }

        [Given(@"I click a login link")]
        public void GivenIClickALoginLink()
        {
            homepage.ClickLogin();
        }


        [Given(@"I enter username and pass")]
        public void GivenIEnterUsernameAndPass(Table table)
        {
            dynamic data = table.CreateDynamicInstance();
            //data.Username = "admin";
            //data.Password = "password";
            loginPage.EnterUserNameAndPassword(data.Username, data.Password);

        }

        [Given(@"I click login")]
        public void GivenIClickLogin()
        {
            loginPage.ClickLogin();
        }

        [Then(@"I should see that user login to the app")]
        public void ThenIShouldSeeThatUserLoginToTheApp()
        {
            Assert.That(homepage.IsLogOffExists(), Is.True, "msg is not exists");
        }

    }
}
