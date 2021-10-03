using NUnit.Framework;
using System;
using TechTalk.SpecFlow;

namespace ICT3101_CalculatorSpecFlow.Step_Definitions
{
    public class SharedData
    {
        public Calculator _calculator;
        public double _result;
    }
    [Binding]
    public class UsingCalculatorAdditionsSteps
    {
        private readonly SharedData sharedData;
        public UsingCalculatorAdditionsSteps(SharedData sharedData)
        {
            this.sharedData = sharedData;
        }




        [When(@"I have entered ""(.*)"" and ""(.*)"" into the calculator and press add")]
        public void WhenIHaveEnteredAndIntoTheCalculatorAndPressAdd(int p0, int p1)
        {
            sharedData._result = sharedData._calculator.Add(p0, p1);
        }

        [Then(@"the result should be ""(.*)""")]
        public void ThenTheResultShouldBe(int p0)
        {
            Assert.That(sharedData._result, Is.EqualTo(p0));
        }


    }
}
