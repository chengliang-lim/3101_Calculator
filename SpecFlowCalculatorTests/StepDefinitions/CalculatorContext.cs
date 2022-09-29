using _3101_Calculator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecFlowCalculatorTests.StepDefinitions
{
    public class CalculatorContext
    {
        private Calculator Calculator;
        public CalculatorContext()
        {
            Calculator = new Calculator();
        }
        public Calculator getCalculator()
        {
            return Calculator;
        }
        
    }
}
