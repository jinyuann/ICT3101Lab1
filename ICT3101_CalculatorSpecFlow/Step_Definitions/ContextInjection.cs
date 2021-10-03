using System;
using System.Collections.Generic;
using System.Text;
using TechTalk.SpecFlow;

namespace ICT3101_CalculatorSpecFlow.Step_Definitions
{
    [Binding]
    class ContextInjection
    {

        private readonly SharedData sharedData;
        public ContextInjection(SharedData sharedData)
        {
            this.sharedData = sharedData;
        }
        [Given(@"I have a calculator")]
        public void GivenIHaveACalculator()
        {
            sharedData._calculator = new Calculator();
        }

    }
}
