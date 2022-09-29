using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecFlowCalculatorTests.StepDefinitions
{
    [Binding]
    [Scope(Feature = "UsingCalculatorBasicReliability")]

    internal class UsingCalculatorReliabilityStepDefinition:BaseDefinition
    {
        private double _result;
        [When(@"I have entered (.*) for initial, (.*) for average, (.*) for total")]
        public void WhenIHaveEnteredForInitialForAverageForTotal(double p0, double p1, double p2)
        {
            _result = _calculator.CurrentFailureIntensity(p0, p1, p2);
        }

        [Then(@"the current failure intensity result should be (.*)")]
        public void ThenTheCurrentFailureIntensityResultShouldBe(double p0)
        {
            Assert.That(_result, Is.EqualTo(p0));
        }

        [When(@"I have entered (.*) for total, (.*) for initial, (.*) hour for time")]
        public void WhenIHaveEnteredForTotalForInitialHourForTime(int p0, int p1, int p2)
        {
            _result = _calculator.AverageNumberFailure(p0, p1, p2);
        }

        [Then(@"the average failure result should be (.*)")]
        public void ThenTheAverageFailureResultShouldBe(int p0)
        {
            Assert.That(_result, Is.EqualTo(p0));
        }
    }
}
