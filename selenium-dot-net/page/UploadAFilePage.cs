using System;
using OpenQA.Selenium;

namespace selenium_dot_net.page
{
    public class UploadAFilePage : BasePage
    {
        private IWebDriver _driver;
        private By filePathLocator = By.Id("fileinput");
        private By uploadBtnLocator = By.Name("upload");
        private By uploadSuccessMsgLocator = By.ClassName("explanation");


        public UploadAFilePage(IWebDriver driver) : base(driver)
        {
            _driver = driver;
        }

        public void UploadAFile(String filePath) {
            Wait.Until(e => e.FindElement(filePathLocator).Enabled);
            _driver.FindElement(filePathLocator).SendKeys(filePath);
        }

        public void ClickUpload()
        {
            Wait.Until(e => e.FindElement(uploadBtnLocator).Enabled);
            _driver.FindElement(uploadBtnLocator).Click();
        }

        public string GetUploadSuccessMsg()
        {
            Wait.Until(e => e.FindElement(uploadSuccessMsgLocator).Displayed);
            return _driver.FindElement(uploadSuccessMsgLocator).Text;
        }
    }
}

