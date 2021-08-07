﻿using OpenQA.Selenium;
using POMFramework.Core;

namespace POMFramework.PageObjects
{
    public class CheckoutPage : BasePage
    {
        public readonly CheckoutPageMap Map;
        public CheckoutPage(IWebDriver driver) : base(driver)
        {
            // Creates a new mapping file when the page object is created

            Map = new CheckoutPageMap(driver);
        }

        public void EnterDetails(string firstname, string lastname, string postcode)
        {
            Helper.WaitForPageToLoad(Map.CheckoutContainer);
            Map.FirstNameField.SendKeys(firstname);
            Map.LastnameField.SendKeys(lastname);
            Map.PostalcodeField.SendKeys(postcode);
            Map.ContinueButton.Click();
        }

        public void FinishCheckout()
        {
            Helper.WaitForPageToLoad(Map.SummaryContainer);
            Map.FinishCheckoutButton.Click();
        }

    }
}
