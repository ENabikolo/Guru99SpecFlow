using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.UI;
using TechTalk.SpecFlow;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading;

namespace Guru99SeleTest
{
    [Binding]
    public class Guru99AddNewCustomerSteps
    {
        private RemoteWebDriver driver;

        [Given(@"I open chrome")]
        public void GivenIOpenChrome()
        {
            ChromeOptions options = new ChromeOptions();
            driver = new ChromeDriver(Environment.CurrentDirectory + "\\..\\Guru99SeleTest");
            driver.Manage().Window.Maximize();
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromMilliseconds(250));
        }
       
        [Given(@"I go to (.*)")]
        public void GivenIGoToHttpWww_Demo_Guru_ComV(string url)
        {
            driver.Navigate().GoToUrl(url);  
        }              
    
        [When(@"I enter the username (.*)")]
        public void WhenIEnterTheUsernameMngr(string username)
        {
            IWait<IWebDriver> wait = new WebDriverWait(driver, TimeSpan.FromMilliseconds(150));
            IWebElement web = wait.Until(driver =>driver.FindElement(By.XPath("/html/body/form/table/tbody/tr[1]/td[2]/input")));
            web.SendKeys(username);
        }

        [When(@"I enter the password (.*)")]
        public void WhenIEnterThePasswordSUmagYp(string password)
        {
            IWait<IWebDriver> wait = new WebDriverWait(driver, TimeSpan.FromMilliseconds(150));
            IWebElement web = wait.Until(driver => driver.FindElement(By.XPath("/html/body/form/table/tbody/tr[2]/td[2]/input")));
            web.SendKeys(password); 
        }

        [When(@"I click the login button")]
        public void WhenIClickTheLoginButton()
        {
            driver.FindElementByXPath("/html/body/form/table/tbody/tr[3]/td[2]/input[1]").Click(); 
        }

        [When(@"I am successfully logged in")]
        public void WhenIAmSuccessfullyLoggedIn()
        {
            
            IWait<IWebDriver> wait = new WebDriverWait(driver, TimeSpan.FromMilliseconds(200));
            string expectedTitle = wait.Until(driver => driver.FindElement(By.XPath("/html/body/table/tbody/tr/td/table/tbody/tr[2]/td/marquee"))).Text;
            String actualTitle = "Welcome To Manager's Page of Guru99 Bank";
            Assert.AreEqual(expectedTitle, actualTitle, "");
        }

        [When(@"I click on the New Customer Link")]
        public void WhenIClickOnTheNewCustomerLink()
        {
            driver.FindElement(By.XPath("/html/body/div[2]/div/ul/li[2]/a")).Click();
        }

        [When(@"I enter the character (.*) in the Name Field")]
        public void WhenIEnterTheCharacterInTheNameField(string name)
        {
            IWait<IWebDriver> wait = new WebDriverWait(driver, TimeSpan.FromMilliseconds(150));
            IWebElement web = wait.Until(driver => driver.FindElement(By.XPath("/html/body/table/tbody/tr/td/table/tbody/tr[4]/td[2]/input")));
            web.SendKeys(name);
        }

        [When(@"I enter the Customer Name (.*)")]
        public void WhenIEnterTheCustomerName(string name)
        {
            IWait<IWebDriver> wait = new WebDriverWait(driver, TimeSpan.FromMilliseconds(150));
            IWebElement web = wait.Until(driver => driver.FindElement(By.XPath("/html/body/table/tbody/tr/td/table/tbody/tr[4]/td[2]/input")));
            web.SendKeys(name);
        }

        [When(@"I enter the Customer name with space (.*)")]
        public void WhenIEnterTheCustomerNameWithSpace(string name)
        {
            IWait<IWebDriver> wait = new WebDriverWait(driver, TimeSpan.FromMilliseconds(150));
            IWebElement web = wait.Until(driver => driver.FindElement(By.XPath("/html/body/table/tbody/tr/td/table/tbody/tr[4]/td[2]/input")));
            web.SendKeys(name); 
        }

        [When(@"I select a gender")]
        public void WhenISelectAGender()
        {
            IWait<IWebDriver> wait = new WebDriverWait(driver, TimeSpan.FromMilliseconds(150));
            IWebElement oRadioButton = wait.Until(driver => driver.FindElement(By.Name("rad1")));

            if (oRadioButton.GetAttribute("m") == "checked")
            {
                oRadioButton.GetAttribute("f");
          } 
            
        }

        [When(@"I do not select the date of birth (.*)/(.*)/(.*)")]
        public void WhenIDoNotSelectTheDateOfBirth(string dd, string mm, string yyyy)
        {
            IWait<IWebDriver> wait = new WebDriverWait(driver, TimeSpan.FromMilliseconds(150));
            IWebElement web = wait.Until(driver => driver.FindElement(By.XPath("//*[@id='dob']")));
            web.SendKeys(dd + mm + yyyy);
            
        }

        [When(@"I enter the Date of Birth (.*)/(.*)/(.*)")]
        public void WhenIEnterTheDateOfBirth(string dd, string mm, string yy)
        {
            IWait<IWebDriver> wait = new WebDriverWait(driver, TimeSpan.FromMilliseconds(150));
            IWebElement web = wait.Until(driver => driver.FindElement(By.XPath("//*[@id='dob']")));
            web.SendKeys(dd + mm + yy);
            Thread.Sleep(2000);
        }

        [When(@"I enter the format for DOB as (.*)/(.*)/(.*)")]
        public void WhenIEnterTheFormatForDOBAs(string d, string m, string yy)
        {
            IWait<IWebDriver> wait = new WebDriverWait(driver, TimeSpan.FromMilliseconds(150));
            IWebElement web = wait.Until(driver => driver.FindElement(By.XPath("//*[@id='dob']")));
            web.SendKeys(d + m + yy);
            Thread.Sleep(3000);
        }

        [When(@"I do not enter an address(.*)")]
        public void WhenIDoNotEnterAnAddress(string address)
        {
            IWait<IWebDriver> wait = new WebDriverWait(driver, TimeSpan.FromMilliseconds(150));
            IWebElement web = wait.Until(driver => driver.FindElement(By.XPath("/html/body/table/tbody/tr/td/table/tbody/tr[7]/td[2]/textarea")));
            web.SendKeys(address);
            Thread.Sleep(3000);
       
        }





        /*
        [When(@"I enter the Customer Name (.*)")]
        public void WhenIEnterTheCustomerName(string name)
        {

            IWait<IWebDriver> wait = new WebDriverWait(driver, TimeSpan.FromMilliseconds(150));
            IWebElement web = wait.Until(driver => driver.FindElement(By.XPath("/html/body/table/tbody/tr/td/table/tbody/tr[4]/td[2]/input")));
            web.SendKeys(name); 

        }

        [When(@"I enter the Date of Birth (.*)")]
        public void WhenIEnterTheDateOfBirth(D birthdate)
        {
            IWait<IWebDriver> wait = new WebDriverWait(driver, TimeSpan.FromMilliseconds(150));
            IWebElement web = wait.Until(driver => driver.FindElement(By.XPath("//*[@id='dob']")));
            web.SendKeys(birthdate);

        }

        [When(@"I enter the address (.*)")]
        public void WhenIEnterTheAddress(string p0)
        {
            IWait<IWebDriver> wait = new WebDriverWait(driver, TimeSpan.FromMilliseconds(150));
            IWebElement web = wait.Until(driver => driver.FindElement(By.XPath("")));
            web.SendKeys(name);
            ScenarioContext.Current.Pending();
        }

        [When(@"I enter the City ""(.*)""")]
        public void WhenIEnterTheCity(string p0)
        {
            IWait<IWebDriver> wait = new WebDriverWait(driver, TimeSpan.FromMilliseconds(150));
            IWebElement web = wait.Until(driver => driver.FindElement(By.XPath("")));
            web.SendKeys(name); ScenarioContext.Current.Pending();
        }

        [When(@"I enter the State (.*)")]
        public void WhenIEnterTheState(string state)
        {
            IWait<IWebDriver> wait = new WebDriverWait(driver, TimeSpan.FromMilliseconds(150));
            IWebElement web = wait.Until(driver => driver.FindElement(By.XPath("")));
            web.SendKeys(name); ScenarioContext.Current.Pending();
        }

        [When(@"I enter the PIN (.*)")]
        public void WhenIEnterThePIN(int PIN)
        {
            ScenarioContext.Current.Pending();
        }

        [When(@"I enter the Telephone Number (.*)")]
        public void WhenIEnterTheTelephoneNumber(int telephoneNumber)
        {
            ScenarioContext.Current.Pending();
        }

        [When(@"I enter the Email Id (.*)")]
        public void WhenIEnterTheEmailId(string email)
        {
            ScenarioContext.Current.Pending();
        }

        [When(@"I click the Submit button")]
        public void WhenIClickTheSubmitButton()
        {
            ScenarioContext.Current.Pending();
        }

        [When(@"I add a New customer successfully")]
        public void WhenIAddANewCustomerSuccessfully()
        {
            //Assert.AreEqual(expected, actual); 
            ScenarioContext.Current.Pending();
        }
        */
        [Then(@"I clean up the environment")]
        public void ThenICleanUpTheEnvironment()
        {
            IWait<IWebDriver> wait = new WebDriverWait(driver, TimeSpan.FromMilliseconds(200));
            driver.Close(); 

        }
    }
}
