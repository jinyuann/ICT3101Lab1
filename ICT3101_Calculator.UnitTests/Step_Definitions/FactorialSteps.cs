using NUnit.Framework;
using System;
using TechTalk.SpecFlow;

namespace ICT3101_Calculator.UnitTests.Step_Definitions
{
    [Binding]
    public class FactorialSteps
    {
        private readonly SharedData sharedData;
        public FactorialSteps(SharedData sharedData)
        {
            this.sharedData = sharedData;
        }

        [When(@"I have entered ""(.*)"" into the calculator and press factorial")]
        public void WhenIHaveEnteredIntoTheCalculatorAndPressFactorial(int p0)
        {
            sharedData._result = sharedData._calculator.Factorial(p0);
        }
        
        [Then(@"the factorial result should be ""(.*)""")]
        public void ThenTheFactorialResultShouldBe(int p0)
        {
            Assert.That(sharedData._result, Is.EqualTo(p0));
        }
    }
}
