using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace OnlineToolsPage
{
    [TestFixture]
    public class OnlineToolsTests
    {
        private IWebDriver driver;
        private string _url = "http://foxtools.ru/UrlEncoder";
        
        [SetUp]
        public void TestInitialize()
        {
            var options = new ChromeOptions();
            options.AddArgument("start-maximized");
            
            driver = new ChromeDriver(options);
            driver.Navigate().GoToUrl(_url);
        }

        [TearDown]
        public void TestFinalize()
        {
            driver.Quit();
        }

        [Test]
        public void urlTest()
        {
            var onlineToolsPage = new OnlineToolsPage(driver);
            onlineToolsPage.fillInputArea(onlineToolsPage.inputArea, "safmfsamkfas").ClickButton(onlineToolsPage.sendButton);
            System.Threading.Thread.Sleep(3000);
            Assert.IsTrue(onlineToolsPage.urlTestPassed);
        }
        
        [Test]
        public void IbmUsaTest()
        {
            var onlineToolsPage = new OnlineToolsPage(driver);
            onlineToolsPage.ClickButton(onlineToolsPage.optionIbmUsaButton)
                .fillInputArea(onlineToolsPage.inputArea, " sfamfasjfsma")
                .ClickButton(onlineToolsPage.sendButton);
            System.Threading.Thread.Sleep(3000);
            Assert.IsTrue(onlineToolsPage.IbmUsaTestPassed);
        }
        
        [Test]
        public void ArabianTest()
        {
            var onlineToolsPage = new OnlineToolsPage(driver);
            onlineToolsPage.ClickButton(onlineToolsPage.optionArabianButton)
                .fillInputArea(onlineToolsPage.inputArea, "https://www.kyivpost.com/arabian")
                .ClickButton(onlineToolsPage.sendButton);
            System.Threading.Thread.Sleep(3000);
            Assert.IsTrue(onlineToolsPage.IbmArabianTestPassed);
        }
        
        [Test]
        public void Arabian2Test()
        {
            var onlineToolsPage = new OnlineToolsPage(driver);
            onlineToolsPage.ClickButton(onlineToolsPage.optionArabian2Button)
                .fillInputArea(onlineToolsPage.inputArea, "https://www.kyivpost.com/arabian2")
                .ClickButton(onlineToolsPage.sendButton);
            System.Threading.Thread.Sleep(3000);
            Assert.IsTrue(onlineToolsPage.IbmArabian2TestPassed);
        }
        
        [Test]
        public void GreekTest()
        {
            var onlineToolsPage = new OnlineToolsPage(driver);
            onlineToolsPage.ClickButton(onlineToolsPage.optionGreekButton)
                .fillInputArea(onlineToolsPage.inputArea, "https://www.kyivpost.com")
                .ClickButton(onlineToolsPage.sendButton);
            System.Threading.Thread.Sleep(3000);
            Assert.IsTrue(onlineToolsPage.GreekTestPassed);
        }
        
        [Test]
        public void BaltianTest()
        {
            var onlineToolsPage = new OnlineToolsPage(driver);
            onlineToolsPage.ClickButton(onlineToolsPage.optionBaltianButton)
                .fillInputArea(onlineToolsPage.inputArea, "https://www.kyivpost.com/baltian")
                .ClickButton(onlineToolsPage.sendButton);
            System.Threading.Thread.Sleep(3000);
            Assert.IsTrue(onlineToolsPage.BaltianTestPassed);
        }
        
        [Test]
        public void EastEuropeTest()
        {
            var onlineToolsPage = new OnlineToolsPage(driver);
            onlineToolsPage.ClickButton(onlineToolsPage.optionEastEuropeButton)
                .fillInputArea(onlineToolsPage.inputArea, "https://www.kyivpost.com/easteurope")
                .ClickButton(onlineToolsPage.sendButton);
            System.Threading.Thread.Sleep(3000);
            Assert.IsTrue(onlineToolsPage.EastEuropeTestPassed);
        }
        
    }
}