using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace selenium_dot_net
{
    public abstract class BasePage
    {
        private IWebDriver _driver;
        public WebDriverWait Wait;

        public BasePage(IWebDriver driver)
        {
            this._driver = driver;
            Wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(10));
        }
    }
}

