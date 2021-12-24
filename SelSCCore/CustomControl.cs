using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace SelSCCore
{
    public class CustomControl: DriverHelper
    {

        public static void ComboBox(String controlName, String value)
        {
            IWebElement comboControl = Driver.FindElement(By.XPath($"//input[@id='{controlName}-awed']"));

            comboControl.Clear();
            comboControl.SendKeys(value);
            Driver.FindElement(By.XPath($"//div[@id='{controlName}-dropmenu']//li[text()='{value}']")).Click();
        }

        internal void ComboBox()
        {
            throw new NotImplementedException();
        }
    }
}
