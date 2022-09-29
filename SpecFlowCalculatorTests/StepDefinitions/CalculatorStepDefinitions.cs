using _3101_Calculator;
using NUnit.Framework;

namespace SpecFlowCalculatorTests.StepDefinitions
{
    [Binding]
    [Scope(Feature = "Calculator")]
    public sealed class UsingCalculatorStepDefinitions:BaseDefinition
    {

        private double _result;

        [When(@"I have entered (.*) and (.*) into the calculator and press add")]
        public void WhenIHaveEnteredAndIntoTheCalculator(double p0, double p1)
        {
            _result = _calculator.Add(p0, p1);
        }
        [Then(@"the result should be (.*)")]
        public void ThenTheResultShouldBeOnTheScreen(int p0)
        {
            Assert.That(_result, Is.EqualTo(p0));
        }
    }
}