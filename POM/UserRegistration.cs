using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryManagementAutomation.POM
{
    class UserRegistration
    {
        IWebDriver driver = null;
        public UserRegistration()
        {
            PageFactory.InitElements(StaticDriver.driver, this);
        }

        [FindsBy(How = How.XPath, Using = "//button[text() = 'Register']")]
        public IWebElement btnRegister { get; set; }

        public void RegisterUser()
        {
            btnRegister.Click();
        }

    }
}
