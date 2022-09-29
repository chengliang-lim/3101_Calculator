using _3101_Calculator;
using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICT3101_Calculator_UnitTest
{
    public class AdditionalCalculatorTests
    {
        private Calculator _calculator;
        private Mock<IFileReader> _mockFileReader;
        [SetUp]
        public void Setup()
        {
            _mockFileReader = new Mock<IFileReader>();
            _mockFileReader.Setup(fr =>
            fr.Read("../../../../3101_Calculator/MagicNumbers.txt")).Returns(new string[2] { "42", "42" });
            _calculator = new Calculator();
        }

        [Test]
        public void GenMagicNumber_WhenFirstNumberInTxtFileIsUsed_Result()
        {
            Assert.That(() => _calculator.GenMagicNum(0, _mockFileReader.Object), Is.EqualTo(84));
        }
    }
}
