/*using System;
using TechTalk.SpecFlow;
using NUnit.Framework;

namespace ICT3101_Calculator.UnitTests.Step_Definitions
{
    [Binding]
    public class UsingCalculator1DivisionsSteps
    {
        private readonly SharedData sharedData;
        public UsingCalculator1DivisionsSteps(SharedData sharedData)
        {
            this.sharedData = sharedData;
        }

        [When(@"I have entered ""(.*)"" and ""(.*)"" into the calculator and press divide")]
        public void WhenIHaveEnteredAndIntoTheCalculatorAndPressDivide(int p0, int p1)
        {

            sharedData._result = sharedData._calculator.Divide(p0, p1);

        }


        
        
        [Then(@"the division decimal result should be ""(.*)""")]
        public void ThenTheDivisionDecimalResultShouldBe(Decimal p0)
        {
            Assert.That(sharedData._result, Is.EqualTo(p0));
        }
        
        [Then(@"the division result should be ""(.*)""")]
        public void ThenTheDivisionResultShouldBe(int p0)
        {
            Assert.That(sharedData._result, Is.EqualTo(p0));
        }
        
        [Then(@"the division result should be positive infinity")]
        public void ThenTheDivisionResultShouldBePositiveInfinity()
        {
            Assert.That(sharedData._result, Is.EqualTo(int.MaxValue));
        }
     

    }
}
*/