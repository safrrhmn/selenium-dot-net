using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using selenium_dot_net.page;
using WebDriverManager;
using WebDriverManager.DriverConfigs.Impl;

namespace selenium_dot_net.test
{
    public abstract class BaseTest
    {
        private IWebDriver driver;

        public IWebDriver Driver { get => driver; set => driver = value; }

        [TestInitialize]
        public void SetupTest()
        {
            new DriverManager().SetUpDriver(new ChromeConfig());
            Driver = new ChromeDriver();
            Driver.Navigate().GoToUrl("https://testpages.herokuapp.com/styled/file-upload-test.html");
            Driver.Manage().Window.Maximize();
        }

        [TestCleanup]
        public void TearDown() {
            Driver.Quit();
        }        
    }
}

