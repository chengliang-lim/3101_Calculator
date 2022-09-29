using _3101_Calculator;
using NUnit.Framework;

namespace ICT3101_Calculator
{
    public class CalculatorTests
    {
        private Calculator _calculator;
        [SetUp]
        public void Setup()
        {
            // Arrange
            _calculator = new Calculator();
        }
        [Test]
        public void Add_WhenAddingTwoNumbers_ResultEqualToSum()
        {
            // Act
            double result = _calculator.Add(10, 20);
            // Assert
            Assert.That(result, Is.EqualTo(30));
        }
        [Test]
        public void Substract_WhenSubstractingTwoNumbers_ResultEqualToSubstraction()
        {
            //Act
            double result = _calculator.Subtract(20, 10);

            //Assert
            Assert.That(result, Is.EqualTo(10));
        }
        [Test]
        public void Multiply_WhenMultiplyingTwoNumbers_ResultsEqualToMultiplication()
        {
            //Act
            double result = _calculator.Multiply(20, 10);

            //Assert
            Assert.That(result, Is.EqualTo(200));
        }

        [Test]
        public void Divide_WhenDividingTwoNumbers_ResultEqualToDivision()
        {
            //Act
            double result = _calculator.Divide(20, 10);

            //Assert
            Assert.That(result, Is.EqualTo(2));

        }
        [Test]
        [TestCase(0, 0)]
        [TestCase(0, 10)]
        [TestCase(10, 0)]
        public void Divide_WithZerosAsInputs_ResultThrowArgumentException(int a, int b)
        {
            Assert.That(() => _calculator.Divide(a, b), Throws.ArgumentException);
        }

        [Test]
        public void Factorial_FactorialOfANumber_ResultOfFactorial()
        {
            //Act
            double result = _calculator.Factorial(3);

            //Assert
            Assert.That(result, Is.EqualTo(6));
        }
        [Test]
        public void Factorial_WithNegativeValueAsInput_ResultThrowArgumentException()
        {
            Assert.That(() => _calculator.Factorial(-1), Throws.ArgumentException);
        }
        
        [Test]
        public void Triangle_WhenCalculatingAreaOfTriangle_ResultOfAreaOfTriangle()
        {
            //Act
            double result = _calculator.Triangle(3,6);

            //Assert
            Assert.That(result, Is.EqualTo(9));
        }
        [Test]
        [TestCase(0, 0)]
        [TestCase(0, 10)]
        [TestCase(10, 0)]
        [TestCase(5, -10)]
        [TestCase(-10, 10)]
        public void Triangle_WithValueLessThanZeroAsInput_ResultThrowArgumentException(double a, double b)
        {

            //Assert
            Assert.That(() => _calculator.Triangle(a, b), Throws.ArgumentException);
        }

        [Test]
        public void Circle_WhenCalculatingAreaOfTriangle_ResultOfAreaOfCircle()
        {
            //Act
            double result = _calculator.Circle(20);

            //Assert
            Assert.That(result, Is.EqualTo(1256.6));
        }
        [Test]
        [TestCase(0)]
        [TestCase( -10)]
        public void Circle_WithValueLessThanZeroAsInput_ResultThrowArgumentException(double value)
        {

            //Assert
            Assert.That(() => _calculator.Circle(value), Throws.ArgumentException);
        }

        [Test]
        public void UnknownFunctionA_WhenGivenTest0_Result()
        {
            // Act
            double result = _calculator.UnknownFunctionA(5, 5);
            // Assert
            Assert.That(result, Is.EqualTo(120));
        }
        [Test]
        public void UnknownFunctionA_WhenGivenTest1_Result()
        {
            // Act
            double result = _calculator.UnknownFunctionA(5, 4);
            // Assert
            Assert.That(result, Is.EqualTo(120));
        }
        [Test]
        public void UnknownFunctionA_WhenGivenTest2_Result()
        {
            // Act
            double result = _calculator.UnknownFunctionA(5, 3);
            // Assert
            Assert.That(result, Is.EqualTo(60));
        }
        [Test]
        public void UnknownFunctionA_WhenGivenTest3_ResultThrowArgumnetException()
        {
            // Act
            // Assert
            Assert.That(() => _calculator.UnknownFunctionA(-4, 5), Throws.ArgumentException);
        }
        [Test]
        public void UnknownFunctionA_WhenGivenTest4_ResultThrowArgumnetException()
        {
            // Act
            // Assert
            Assert.That(() => _calculator.UnknownFunctionA(4, 5), Throws.ArgumentException);
        }
        [Test]
        public void UnknownFunctionB_WhenGivenTest0_Result()
        {
            // Act
            double result = _calculator.UnknownFunctionB(5, 5);
            // Assert
            Assert.That(result, Is.EqualTo(1));
        }
        [Test]
        public void UnknownFunctionB_WhenGivenTest1_Result()
        {
            // Act
            double result = _calculator.UnknownFunctionB(5, 4);
            // Assert
            Assert.That(result, Is.EqualTo(5));
        }
        [Test]
        public void UnknownFunctionB_WhenGivenTest2_Result()
        {
            // Act
            double result = _calculator.UnknownFunctionB(5, 3);
            // Assert
            Assert.That(result, Is.EqualTo(10));
        }
        [Test]
        public void UnknownFunctionB_WhenGivenTest3_ResultThrowArgumnetException()
        {
            // Act
            // Assert
            Assert.That(() => _calculator.UnknownFunctionB(-4, 5), Throws.ArgumentException);
        }
        [Test]
        public void UnknownFunctionB_WhenGivenTest4_ResultThrowArgumnetException()
        {
            // Act
            // Assert
            Assert.That(() => _calculator.UnknownFunctionB(4, 5), Throws.ArgumentException);
        }   

    }
}