using NUnit.Framework;
using System;
using TechTalk.SpecFlow;
//Yes because it helps to ensure the test case pass
//no because it only checks the end results
//test case does not know the inputs is MTTF/MTTR/MTBF
//no exception handling
//data types problem
namespace ICT3101_Calculator.UnitTests.Step_Definitions
{
    [Binding]
    public class UsingCalculatorAvailabilitySteps
    {
        private readonly SharedData sharedData;
        public UsingCalculatorAvailabilitySteps(SharedData sharedData)
        {
            this.sharedData = sharedData;
        }

        [When(@"I have entered ""(.*)"" and ""(.*)"" into the calculator and press MTBF")]
        public void WhenIHaveEnteredAndIntoTheCalculatorAndPressMTBF(int p0, int p1)
        {
            sharedData._result = sharedData._calculator.MTBF(p0, p1);
        }
        
        [When(@"I have entered ""(.*)"" and ""(.*)"" into the calculator and press MTBF \(add\)")]
        public void WhenIHaveEnteredAndIntoTheCalculatorAndPressMTBFAdd(int p0, int p1)
        {
            sharedData._result = sharedData._calculator.Add(p0, p1);
        }
        
        [When(@"I have entered ""(.*)"" and ""(.*)"" into the calculator and press Availability")]
        public void WhenIHaveEnteredAndIntoTheCalculatorAndPressAvailability(int p0, int p1)
        {
            sharedData._result = sharedData._calculator.AVAILABILITY(p0, p1);
        }
        
        [Then(@"the availability result decimal should be ""(.*)""")]
        public void ThenTheAvailabilityResultDecimalShouldBe(double p0)
        {
            Assert.That(Math.Round((double)sharedData._result,2), Is.EqualTo(p0));
        }
        
        [Then(@"the MTBF result should be ""(.*)""")]
        public void ThenTheMTBFResultShouldBe(int p0)
        {
            Assert.That(sharedData._result, Is.EqualTo(p0));
        }
        
        [Then(@"the availability result should be ""(.*)""")]
        public void ThenTheAvailabilityResultShouldBe(int p0)
        {
            Assert.That(sharedData._result, Is.EqualTo(p0));
        }
    }
}
