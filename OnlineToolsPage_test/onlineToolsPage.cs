using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support;
using SeleniumExtras.PageObjects;

namespace OnlineToolsPage
{ 
    public class OnlineToolsPage
    {
        private IWebDriver _driver;

        public OnlineToolsPage(IWebDriver driver)
        {
            _driver = driver;
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.XPath, Using = "//*[@id='cp']/option[36]")] 
        public IWebElement optionIbmUsaButton;

        [FindsBy(How = How.XPath, Using = "//*[@id='cp']/option[4]")] 
        public IWebElement optionArabianButton;

        [FindsBy(How = How.XPath, Using = "//*[@id='cp']/option[5]")] 
        public IWebElement optionArabian2Button;

        [FindsBy(How = How.XPath, Using = "//*[@id='cp']/option[6]")] 
        public IWebElement optionGreekButton;

        [FindsBy(How = How.XPath, Using = "//*[@id='cp']/option[7]")] 
        public IWebElement optionBaltianButton;

        [FindsBy(How = How.XPath, Using = "//*[@id='cp']/option[8]")] 
        public IWebElement optionEastEuropeButton;
        
        [FindsBy(How = How.XPath, Using = "//*[@id='text']")]
        public IWebElement inputArea;
        
        [FindsBy(How = How.XPath, Using = "//*[@id='foxResult']/textarea")]
        public IWebElement outputArea;

        [FindsBy(How = How.XPath, Using = "//*[@id='form1']/a[1]")]
        public IWebElement sendButton;


        public bool urlTestPassed => outputArea.GetAttribute("innerHTML").Equals("safmfsamkfas");
        public bool IbmUsaTestPassed => outputArea.GetAttribute("innerHTML").Equals("%40%a2%86%81%94%86%81%a2%91%86%a2%94%81");
        public bool IbmArabianTestPassed => outputArea.GetAttribute("innerHTML").Equals("https%3a%2f%2fwww.kyivpost.com%2farabian");
        public bool IbmArabian2TestPassed => outputArea.GetAttribute("innerHTML").Equals("https%3a%2f%2fwww.kyivpost.com%2farabian2");
        public bool GreekTestPassed => outputArea.GetAttribute("innerHTML").Equals("https%3a%2f%2fwww.kyivpost.com");
        public bool BaltianTestPassed => outputArea.GetAttribute("innerHTML").Equals("https%3a%2f%2fwww.kyivpost.com%2fbaltian");
        public bool EastEuropeTestPassed => outputArea.GetAttribute("innerHTML").Equals("https%3a%2f%2fwww.kyivpost.com%2feasteurope");


        public OnlineToolsPage ClickButton(IWebElement buttonToClick)
        {
            buttonToClick.Click();
            return this;
        }
        public OnlineToolsPage fillInputArea(IWebElement inputArea, string message_to_send)
        {
            inputArea.SendKeys(message_to_send);
            return this;
        }
        
   
    }
}