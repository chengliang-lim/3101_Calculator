using _3101_Calculator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecFlowCalculatorTests.StepDefinitions
{
    public class BaseDefinition
    {
        protected Calculator _calculator;
        [Given(@"I have a calculator")]
        public virtual void GivenIHaveACalculator()
        {
            _calculator = new Calculator();
        }
    }
}
