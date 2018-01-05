using System;
using TechTalk.SpecFlow;
using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Firefox;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace SeleniumTestProject1
{
    [Binding]
    public class Guru99LoginSteps
    {
        private RemoteWebDriver driver;

        [Given(@"I open chrome")]
        public void GivenIOpenChrome()
        {
            ChromeOptions options = new ChromeOptions();
            options.AddArguments("disable-infobars");
            driver = new ChromeDriver(Environment.CurrentDirectory + "\\..\\SeleniumTestProject1"); //<-Add the path  to the location of the chromedriver.exe      
            driver.Manage().Window.Maximize();
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromMilliseconds(250));

            
        }
        
        [Given(@"I go to (.*)")]
        public void GivenIGoToHttpsWww_Demo_Guru_ComV(string url)
        {
            driver.Navigate().GoToUrl(url);
             
        }
        
        [When(@"I enter the username (.*)")]
        public void WhenIEnterTheUsernameMngr(string username)
        {
           IWait<IWebDriver> wait = new WebDriverWait(driver, TimeSpan.FromMilliseconds(200)); 
           IWebElement e = wait.Until(driver => driver.FindElement(By.CssSelector("body > form:nth-child(19) > table:nth-child(2) > tbody:nth-child(1) > tr:nth-child(1) > td:nth-child(2) > input:nth-child(1)")));
           e.SendKeys(username); 
            
        }
        
        [When(@"I enter the password (.*)")]
        public void WhenIEnterThePasswordSUmagYp(string password)
        {
            IWait<IWebDriver> wait = new WebDriverWait(driver, TimeSpan.FromMilliseconds(200));
            IWebElement e = wait.Until(driver => driver.FindElement(By.CssSelector("body > form:nth-child(19) > table:nth-child(2) > tbody:nth-child(1) > tr:nth-child(2) > td:nth-child(2) > input:nth-child(1)"))); 
            e.SendKeys(password);
          
        }

        [When(@"I click the login button")]
        public void WhenIClickTheLoginButton()
        {
            
            driver.FindElement(By.XPath("/html/body/form/table/tbody/tr[3]/td[2]/input[1]")).Click();
        }

        
        [When(@"I am successfully logged in")]
        public void WhenIAmSuccessfullyLoggedIn()
        {
            //driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(50);
            IWait<IWebDriver> wait = new WebDriverWait(driver, TimeSpan.FromMilliseconds(200));
            string expectedTitle = wait.Until(driver => driver.FindElement(By.XPath("/html/body/table/tbody/tr/td/table/tbody/tr[2]/td/marquee"))).Text;
            String actualTitle = "Welcome To Manager's Page of Guru99 Bank";
            Assert.AreEqual(expectedTitle, actualTitle, ""); 
        }
        
        [Then(@"I clean up the environnement")]
        public void ThenICleanUpTheEnvironnement()
        {
            driver.Quit();
        }
    }
}
