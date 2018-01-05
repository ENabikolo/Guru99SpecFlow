using System;
using System.Collections;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechTalk.SpecFlow;

namespace UnitTestProject1
{

    [Binding]
    public class SpecFlowFeature1Steps
    {
        ArrayList numbers = new ArrayList();

       private int ans = 0;
       

        [Given(@"I have entered (.*) into the calculator")]
        public void GivenIHaveEnteredIntoTheCalculator(int num)
        {
            numbers.Add(num); //add the number n to the list. 

            //ans = Int32.Parse(); 
            //numbers.Subtract(num);
            //numbers.Multiply(num);
        }

        [When(@"I press add")]
        public void WhenIPressAdd()
        {
            foreach(int n in numbers)
            {
 
                ans += n;
            }
        }

        [When(@"I press subtract")]
        public void WhenIPressSubtract()
        {
            ans = Convert.ToInt32(numbers[0]);
            for(int i = 1; i < numbers.Count; i++)
            {

                ans -= Convert.ToInt32(numbers[i]);

            }

        }

        [When(@"I press multiply")]
        public void WhenIPressMultiply()
        {
            ans = Convert.ToInt32(numbers[0]);
            for(int i = 1; i < numbers.Count; i++)
            {

                ans *= Convert.ToInt32(numbers[i]);
            }
        }

        [When(@"I press divide")]
        public void WhenIPressDivide()
        {
            ans = Convert.ToInt32(numbers[0]);
            for (int i = 1; i < numbers.Count; i++)
            {
           
                ans /= Convert.ToInt32(numbers[i]);

            }
        }

        [When(@"I press add and I subtract")]
        public void WhenIPressAddAndISubtract()
        {
            //ans = Convert.ToInt32(numbers[0]);

            for( int i = 0; i <numbers.Count-1; i++)
            {

                ans += Convert.ToInt32(numbers[i]);     
            }

            ans -= Convert.ToInt32(numbers[2]); 
           
            }

        [Then(@"the result should be (.*) on the screen")]
        public void ThenTheResultShouldBeOnTheScreen(int expected)
        {
            Assert.AreEqual(expected, ans); //checks the expected answer against the actual to see if they are equal. 
        }
    }
}
