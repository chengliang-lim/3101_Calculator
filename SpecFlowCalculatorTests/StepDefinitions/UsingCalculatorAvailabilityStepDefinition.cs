using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecFlowCalculatorTests.StepDefinitions
{
    [Binding]
    [Scope(Feature = "UsingCalculatorAvailability")]
    internal class UsingCalculatorAvailabilityStepDefinition:BaseDefinition
    {
        private double _result;

        [When(@"I have entered (.*) and (.*) into the calculator and press MTBF")]
        public void WhenIHaveEnteredAndIntoTheCalculatorAndPressMTBF(int p0, int p1)
        {
            _result = _calculator.MeanTimeBetweenFailure(p0, p1);
        }

        [Then(@"the MTBF result should be (.*)")]
        public void ThenTheMTBFResultShouldBe(int p0)
        {
            Assert.That(_result, Is.EqualTo(p0));
        }

        [When(@"I have entered (.*) and (.*) into the calculator and press Availability")]
        public void WhenIHaveEnteredAndIntoTheCalculatorAndPressAvailability(int p0, int p1)
        {
            _result = _calculator.Availability(p0, p1);
        }

        [Then(@"the availability result should be (.*)")]
        public void ThenTheAvailabilityResultShouldBe(double p0)
        {
            Assert.That(_result, Is.EqualTo(p0));
        }
    }
}
