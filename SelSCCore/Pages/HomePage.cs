﻿using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace SelSCCore.Pages
{
    public class HomePage : DriverHelper
    {

        IWebElement lnkLogin => Driver.FindElement(By.LinkText("Login"));
        IWebElement lnkLogOff => Driver.FindElement(By.LinkText("Log off"));

        public void ClickLogin() => lnkLogin.Click();

        public bool IsLogOffExists() => lnkLogOff.Displayed;
    }
}
