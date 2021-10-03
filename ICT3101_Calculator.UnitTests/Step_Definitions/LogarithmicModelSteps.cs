using NUnit.Framework;
using System;
using TechTalk.SpecFlow;

namespace ICT3101_Calculator.UnitTests.Step_Definitions
{
    [Binding]
    public class LogarithmicModelSteps
    {
        private double result1;
        private double result2;
        private readonly SharedData sharedData;
        public LogarithmicModelSteps(SharedData sharedData)
        {
            this.sharedData = sharedData;
        }

        [When(@"I have entered ""(.*)"" and ""(.*)"" and ""(.*)"" into the calculator and press failure intensity log")]
        public void WhenIHaveEnteredAndAndIntoTheCalculatorAndPressFailureIntensityLog(double p0, int p1, int p2)
        {
            sharedData._result = sharedData._calculator.FailureIntensityLog(p0, p1, p2);
        }

        [When(@"I have entered ""(.*)"" and ""(.*)"" and ""(.*)"" into the calculator and press number of failure log")]
        public void WhenIHaveEnteredAndAndIntoTheCalculatorAndPressNumberOfFailureLog(double p0, int p1, int p2)
        {
            sharedData._result = sharedData._calculator.FailureLog(p0, p1, p2);
        }

        [When(@"I have entered ""(.*)"" and ""(.*)"" and ""(.*)"" and ""(.*)"" into the calculator and press single logarithmic")]
        public void WhenIHaveEnteredAndAndAndIntoTheCalculatorAndPressSingleLogarithmic(double p0, int p1, int p2, int p3)
        {
            result1 = sharedData._calculator.FailureIntensityLog(p0, p3, p1);
            result2 = sharedData._calculator.FailureLog(p0, p1, p2);
        }

        [Then(@"the failure intensity log result should be ""(.*)""")]
        public void ThenTheFailureIntensityLogResultShouldBe(double p0)
        {
            Assert.That(Math.Round(sharedData._result, 2), Is.EqualTo(p0));
        }

        [Then(@"the failure result log should be ""(.*)""")]
        public void ThenTheFailureResultLogShouldBe(double p0)
        {
            Assert.That(Math.Round(sharedData._result, 2), Is.EqualTo(p0));
        }

        [Then(@"the failure intensity and result should be ""(.*)"" and ""(.*)""")]
        public void ThenTheFailureIntensityAndResultShouldBeAnd(double p0, double p1)
        {
            Assert.That(Math.Round(result1, 2), Is.EqualTo(p0));
            Assert.That(Math.Round(result2, 2), Is.EqualTo(p1));
        }
    }
}
