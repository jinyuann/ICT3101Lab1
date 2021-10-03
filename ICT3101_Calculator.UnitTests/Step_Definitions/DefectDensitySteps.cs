using NUnit.Framework;
using System;
using TechTalk.SpecFlow;

namespace ICT3101_Calculator.UnitTests.Step_Definitions
{
    [Binding]
    public class DefectDensitySteps
    {
        private readonly SharedData sharedData;
        public DefectDensitySteps(SharedData sharedData)
        {
            this.sharedData = sharedData;
        }
        [When(@"I have entered ""(.*)"" and ""(.*)"" into the calculator and press Defect Density")]
        public void WhenIHaveEnteredAndIntoTheCalculatorAndPressDefectDensity(int p0, int p1)
        {
            sharedData._result = sharedData._calculator.DefectDensity(p0, p1);
        }
        
        [When(@"I have entered ""(.*)"" and ""(.*)"" and ""(.*)"" into the calculator and press SSI")]
        public void WhenIHaveEnteredAndAndIntoTheCalculatorAndPressSSI(int p0, int p1, int p2)
        {
            sharedData._result = sharedData._calculator.SSI(p0, p1, p2);
        }
        
        [Then(@"the DD decimal result should be ""(.*)""")]
        public void ThenTheDDDecimalResultShouldBe(double p0)
        {
            Assert.That(sharedData._result, Is.EqualTo(p0));
        }
        [Then(@"the DD double result should be ""(.*)""")]
        public void ThenTheDDoubleResultShouldBe(double p0)
        {
            Assert.That(sharedData._result, Is.EqualTo(p0));
        }

        [Then(@"the DD decimal result should be ""(.*)""")]
        public void ThenTheDDDecimalResultShouldBe(int p0)
        {
            Assert.That(sharedData._result, Is.EqualTo(p0));
        }
    }
}
