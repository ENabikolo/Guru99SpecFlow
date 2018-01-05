using System;
using TechTalk.SpecFlow;

namespace SeleniumTestProject1
{
    [Binding]
    public class Guru99LoginStepsChrome
    {
        [Given(@"I open chrome")]
        public void GivenIOpenChrome()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"I click the login button")]
        public void WhenIClickTheLoginButton()
        {
            ScenarioContext.Current.Pending();
        }
    }
}
