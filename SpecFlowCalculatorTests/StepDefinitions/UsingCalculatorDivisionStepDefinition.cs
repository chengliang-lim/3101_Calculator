using _3101_Calculator;
using NUnit.Framework;

namespace SpecFlowCalculatorTests.StepDefinitions
{
    [Binding]
    [Scope(Feature = "UsingCalculatorDivision")]
    public sealed class UsingCalculatorDivisionStepDefinition:BaseDefinition
    {

        private double _result;
        
        [When(@"I have entered (.*) and (.*) into the calculator and press divide")]
        public void WhenIHaveEnteredAndIntoTheCalculator(double p0, double p1)
        {
            _result = _calculator.Divide(p0, p1);
        }
        [Then(@"the division result should be (.*)")]
        public void ThenTheDivisionResultShouldBe(string p0)
        {
            // Check if the result is the string 
            var result = p0 == "positive_infinity" ? double.PositiveInfinity : double.Parse(p0);
            Assert.That(_result, Is.EqualTo(result));
        }
    }
}
