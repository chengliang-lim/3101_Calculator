using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecFlowCalculatorTests.StepDefinitions
{
    [Binding]
    [Scope(Feature = "UsingCalculatorMusaLog")]
    internal class UsingCalculatorMusaLogStepDefinition:BaseDefinition
    {
        private double _result;
        [When(@"I have entered (.*) as initial failure intensity and (.*) as decay perimeter and (.*) expected failure into the calculator and press Musa Log failure intenstiy")]
        public void WhenIHaveEnteredAsInitialFailureIntensityAndAsDecayPerimeterAndExpectedFailureIntoTheCalculatorAndPressMusaLogFailureIntenstiy(double p0, double p1, double p2)
        {
            _result = _calculator.currentMusaLogFailureIntensity(p0, p1, p2);
        }

        [Then(@"the Log failure intensity result should be (.*)")]
        public void ThenTheLogFailureIntensityResultShouldBe(Decimal p0)
        {
            Assert.That(_result, Is.EqualTo(p0));
        }

        [When(@"I have entered (.*) as decay and (.*) as initial failure intensity and (.*) as the time and press Musa Log expected Number Failure")]
        public void WhenIHaveEnteredAsDecayAndAsInitialFailureIntensityAndAsTheTimeAndPressMusaLogExpectedNumberFailure(double p0, double p1, double p2)
        {
            _result = _calculator.averageFailureMasaLog(p0, p1, p2);
        }

        [Then(@"the log expected failure result should be (.*)")]
        public void ThenTheLogExpectedFailureResultShouldBe(double p0)
        {
            Assert.That(_result, Is.EqualTo(p0));
        }
    }
}
