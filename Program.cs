using LibraryManagementAutomation.POM;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System;

namespace LibraryManagementAutomation
{
    class Program
    {
        static void Main(string[] args)
        {
            Program p = new Program();
            p.Initialize();
            p.Test();
            p.CleanUp();
        }

        [SetUp]
        public void Initialize()
        {
            StaticDriver.driver = new FirefoxDriver();
            StaticDriver.driver.Navigate().GoToUrl("http://localhost:3000/");
        }

        [Test]
        public void Test()
        {
            UserRegistration pageModel = new UserRegistration();
            pageModel.RegisterUser();
        }

        [TearDown]
        public void CleanUp()
        {
            StaticDriver.driver.Close();
            Console.WriteLine("Test Passed");
        }
    }
}
