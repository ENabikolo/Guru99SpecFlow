using System;
using TechTalk.SpecFlow;

namespace UnitTestProject1
{
    [Binding]
    public class SpecFlowFeature2Steps
    {
        [Given(@"I entered (.*) into the calculator")]
        public void GivenIEnteredIntoTheCalculator(int p0)
        {

            {
                //ans = Convert.ToInt32(numbers[0]);

                for (int i = 0; i < numbers.Count - 1; i++)
                {

                    ans += Convert.ToInt32(numbers[i]);
                }

                ans -= Convert.ToInt32(numbers[2]);

            }
            /*
            count =1
            ans =List[]
            for (int i=1; i <List.Count; i++){
            Switch (count) 
            Case 1:
            ans + List[i]
            count ++
            Case 2:
            ans - List[i]
            count ++
            Case 3:
            ans * List[i]
            count ++
            Case 4:
            ans / List[i]
            count =1
            */
            ScenarioContext.Current.Pending();
        }
    }
}
