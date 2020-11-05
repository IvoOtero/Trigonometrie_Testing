using System;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist.ValueRetrievers;
using Xunit;

namespace Trigonometrie_Testing
{

  
    [Binding]
    public class PerformTrigonometricFuntionsSteps
    {

        public string function;

        [Given(@"I choose the (.*) function in my calculator")]
        public void GivenIChooseTheFunctionInMyCalculator(string p0)
        {
            function = p0;
            Assert.NotNull(p0);
        }
        
        [Given(@"the angular degree of the function is (.*)")]
        public void GivenTheAngularDegreeOfTheFunctionIs(double pi)
        {
            double expected = Math.PI;
            double actual = pi;
            Assert.Equal(expected, actual, 5);
        }
        
        [When(@"I press the (.*) button")]
        public void WhenIPressTheButton(string button)
        {
            var expected = "<=>";
            var actual = button;
            Assert.Equal(expected, actual);
        }
        
        [Then(@"the result should be (.*)")]
        public void ThenTheResultShouldBe(int result)
        {
            if (function == "<Sine>")
            {
                
                var expected = Math.Sin(Math.PI); ;
                var actual = result;
                Assert.Equal(expected, actual, 5);
            } 
            else if (function == "<Cosine>")
            {
                var expected = Math.Cos(Math.PI);
                var actual = result;
                Assert.Equal(expected, actual, 5);
            }
            else if (function == "<Tangent>")
            {
                var expected = Math.Tan(Math.PI);
                var actual = result;
                Assert.Equal(expected, actual, 5);
            }
        }
    }
}
