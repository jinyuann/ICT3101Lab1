using NUnit.Framework;
namespace ICT3101_Caculator.UnitTests
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
        {// Act      
            double result = _calculator.Add(10, 20);
            // Assert
            Assert.That(result, Is.EqualTo(30));
        }

        [Test]
        public void Subtract_twonumbers_resultequaltosubtract()
        {// Act      
            double result = _calculator.Subtract(120, 20);
            // Assert
            Assert.That(result, Is.EqualTo(100));
        }
        [Test]
        public void Multiply2numbers()
        {// Act      
            double result = _calculator.Multiply(10, 20);
            // Assert
            Assert.That(result, Is.EqualTo(200));
        }

        [Test]
        public void Divide2numbers()
        {// Act      
            double result = _calculator.Divide(100, 10);
            // Assert
            Assert.That(result, Is.EqualTo(10));
        }

       

       /* [Test]
        [TestCase(0, 0)]
        [TestCase(0, 10)]
        [TestCase(10, 0)]
        public void Divide_WithZerosAsInputs_ResultThrowArgumentException(int a, int b)
        {
            Assert.That(() => _calculator.Divide(a, b), Throws.ArgumentException);
            Assert.That(() => _calculator.Divide(a, b), Throws.ArgumentException);
            Assert.That(() => _calculator.Divide(a, b), Throws.ArgumentException);
        }*/

        //FACTORIALTEST
        [Test]
        public void TestFACTORIAL()
        {// Act      
            double result = _calculator.Factorial(5);
            // Assert
            Assert.That(result, Is.EqualTo(120));
        }

        [Test]
        public void TestFACTORIAL2()
        {// Act      
            double result = _calculator.Factorial(0);
            // Assert
            Assert.That(result, Is.EqualTo(1));
        }

        [TestCase(-10)]
        public void NegativeInputs_ResultThrowArgumentException(int a)
        {
            Assert.That(() => _calculator.Factorial(-10), Throws.ArgumentException);
            
        }

        //TDD
        [Test]
        public void TestAreaofTriangle()
        {// Act      
            double result = _calculator.Triangle(100, 10);
            // Assert
            Assert.That(result, Is.EqualTo(500));

        }

        [Test]
        public void TestAreaofTrianglefail()
        {      
           
            Assert.That(() => _calculator.Triangle(-100,0), Throws.ArgumentException);
        }
        [Test]
        public void TestAreaofCircle()
        {// Act      
            double result = _calculator.Circle(100);
            // Assert
            Assert.That(result, Is.EqualTo(31420));
        }
        //PERMUTATIONS
        [Test]
        public void UnknownFunctionA_WhenGivenTest0_Result()
        {// Act      
            double result = _calculator.Permuatations(5, 5);
            // Assert
            Assert.That(result, Is.EqualTo(120));}
        [Test]
        public void UnknownFunctionA_WhenGivenTest1_Result()
        {// Act        
            double result = _calculator.Permuatations(5, 4);
            // Assert
            Assert.That(result, Is.EqualTo(120));}
        [Test]
        public void UnknownFunctionA_WhenGivenTest2_Result()
        {// Act        
            double result = _calculator.Permuatations(5, 3);
            // Assert
            Assert.That(result, Is.EqualTo(60));}
        [Test]
        public void UnknownFunctionA_WhenGivenTest3_ResultThrowArgumnetException()
        {// Act       
            // Assert
            Assert.That(() => _calculator.Permuatations(-4,5), Throws.ArgumentException);}
        [Test]
        public void UnknownFunctionA_WhenGivenTest4_ResultThrowArgumnetException(){
            // Act       
            // Assert
            Assert.That(() => _calculator.Permuatations(4, 5), Throws.ArgumentException);}




        //COMBINATIONS
        [Test]
        public void UnknownFunctionB_WhenGivenTest0_Result()
        {// Act   
            double result = _calculator.Combination(5, 5);
            // Assert
            Assert.That(result, Is.EqualTo(1));}
        [Test]
        public void UnknownFunctionB_WhenGivenTest1_Result(){
            // Act       
            double result = _calculator.Combination(5, 4);
            // Assert
            Assert.That(result, Is.EqualTo(5));}
        [Test]
        public void UnknownFunctionB_WhenGivenTest2_Result(){
            // Act       
            double result = _calculator.Combination(5, 3);
            // Assert
            Assert.That(result, Is.EqualTo(10));}
        [Test]
        public void UnknownFunctionB_WhenGivenTest3_ResultThrowArgumnetException(){
            // Act   
            // Assert
            Assert.That(() => _calculator.Combination(-4,5), Throws.ArgumentException);}
        [Test]
        public void UnknownFunctionB_WhenGivenTest4_ResultThrowArgumnetException(){
            // Act      
            // Assert
            Assert.That(() => _calculator.Combination(4,5), Throws.ArgumentException);}
        }

    }

    