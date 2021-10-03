using NUnit.Framework;
using System;
using TechTalk.SpecFlow;

namespace ICT3101_Calculator.UnitTests.Step_Definitions
{
    [Binding]
    public class UsingCalculatorBasicReliabilitySteps
    {

        private readonly SharedData sharedData;
        public UsingCalculatorBasicReliabilitySteps(SharedData sharedData)
        {
            this.sharedData = sharedData;
        }
        [When(@"I have entered ""(.*)"" and ""(.*)"" and ""(.*)"" into the calculator and press failure intensity")]
        public void WhenIHaveEnteredAndAndIntoTheCalculatorAndPressFailureIntensity(int p0, int p1, int p2)
        {
            sharedData._result = sharedData._calculator.FailureIntensity(p0, p1, p2);
        }

        [When(@"I have entered ""(.*)"" and ""(.*)"" and ""(.*)"" into the calculator and press number of failure")]
        public void WhenIHaveEnteredAndIntoTheCalculatorAndPressNumberOfFailure(int p0, int p1, int p2)
        {
            sharedData._result = sharedData._calculator.Failure(p0, p1, p2);
        }

        [Then(@"the failure intensity result should be ""(.*)""")]
        public void ThenTheFailureIntensityResultShouldBe(int p0)
        {
            Assert.That(sharedData._result, Is.EqualTo(p0));
        }

        [Then(@"the failure result should be ""(.*)""")]
        public void ThenTheFailureResultShouldBe(double p0)
        {
            Assert.That(Math.Round(sharedData._result, 2), Is.EqualTo(p0));
        }
    }
}
