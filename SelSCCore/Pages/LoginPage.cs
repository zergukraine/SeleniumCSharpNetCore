using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace SelSCCore.Pages
{
    public class LoginPage : DriverHelper
    {
        IWebElement inputUserName => Driver.FindElement(By.Id("UserName"));
        IWebElement inputPassword => Driver.FindElement(By.Id("Password"));
        IWebElement btnLogin => Driver.FindElement(By.XPath("//input[@value='Log in']"));

        public void EnterUserNameAndPassword(String userName, String password) 
        {
            inputUserName.SendKeys(userName);
            inputPassword.SendKeys(password);
        }
        public void ClickLogin() => btnLogin.Click();
    }
}
