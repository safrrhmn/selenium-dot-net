using Microsoft.VisualStudio.TestTools.UnitTesting;
using selenium_dot_net.page;
using selenium_dot_net.test;

namespace selenium_dot_net
{
    [TestClass]
    public class FileuploadTest : BaseTest
    {
        [TestMethod]
        public void UploadFileSuccess()
        {
            UploadAFilePage page = new UploadAFilePage(Driver);
            page.UploadAFile("/Users/safrrhmn/git/github/selenium-dot-net/selenium-dot-net/resource/FileUploadTestFile.txt");
            page.ClickUpload();
            string msg = page.GetUploadSuccessMsg();
            Assert.AreEqual("You uploaded a file. This is the result.", msg);

        }
    }
}

