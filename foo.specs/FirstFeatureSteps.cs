using System;
using TechTalk.SpecFlow;

namespace foo.specs
{
    [Binding]
    public class FirstFeatureSteps
    {
        [Given]
        public void Given_I_have_entered_P0_into_the_calculator(int p0)
        {
            //if()
            ScenarioContext.Current.Add("number1", p0);
        }

        [Given(@"I again entered (.*) into the calculator")]
        public void GivenIAgainEnteredIntoTheCalculator(int p0)
        {
            ScenarioContext.Current.Add("number2", p0);
        }

        [When]
        public void When_I_press_add()
        {
            var number = Convert.ToInt64(ScenarioContext.Current["number1"]) + Convert.ToInt64(ScenarioContext.Current["number2"]);
        }

        [When]
        public void When_I_press_Substract()
        {
            ScenarioContext.Current.Pending();
        }

        [Then]
        public void Then_the_result_should_be_P0_on_the_screen(int p0)
        {
            ScenarioContext.Current.Pending();
        }
    }
}
