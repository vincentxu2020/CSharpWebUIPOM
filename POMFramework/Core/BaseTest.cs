using NUnit.Framework;
using OpenQA.Selenium;
using POMFramework.PageObjects;
using POMFramework.Core;

namespace POMFramework.Core
{
    public class BaseTest
    {
        protected IWebDriver Driver { get; set; }

        [SetUp]
        public void TestSetup()
        {
            var factory = new Factory();
            Driver = factory.CreateBrowser(Network.Local, BrowserType.Chrome);            
        }

        [TearDown]
        public void TestEnding()
        {
            Driver.Close();
            Driver.Quit();
        }
    }
}
