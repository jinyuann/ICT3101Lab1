/*using ICT3101Lab1;
using Moq;
using NUnit.Framework;


namespace ICT3101_Caculator.UnitTests
{
    class AdditionalCalculatorTests
    {
        private Calculator _calculator;
        private Mock<IFileReader> _mockFileReader;


        [SetUp]
        public void Setup()
        {
            // Arrange
            _calculator = new Calculator();
            _mockFileReader = new Mock<IFileReader>();
            _mockFileReader.Setup(fr => fr.Read("C:/Users/JIN YUAN NEO/source/repos/ICT3101Lab1/ICT3101Lab1/MagicNumbers.txt")).Returns(new string[2] { "42", "45" });
        }


        [Test]
        public void MagicNumbertest()

        {   // Act      
            double result = _calculator.GenMagicNum(0, _mockFileReader.Object);
            // Assert
            Assert.That(result, Is.EqualTo(84));
            // Act      

        }

        [Test]
        public void MagicNumbertest2()

        {   // Act      
            double result = _calculator.GenMagicNum(1, _mockFileReader.Object);
            // Assert
            Assert.That(result, Is.EqualTo(90));
            // Act      

        }
    }
}
*/