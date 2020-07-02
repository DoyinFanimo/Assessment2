using AudenTechnicalTest.PageObject;
using NUnit.Framework;
using System;
using TechTalk.SpecFlow;

namespace AudenTechnicalTest.StepDefinition
{
    [Binding]
    public class LoanCalculatorSteps
    {
        CalculatorPO calculatorPO;
        public LoanCalculatorSteps()
        {
            calculatorPO = new CalculatorPO();
        }
        [Given(@"I navigate to the site ""(.*)""")]
        public void GivenINavigateToTheSite(string url)
        {
            calculatorPO.NavigateToSite(url);
        }

        [When(@"I select a loan amount that is not min or max")]
        public void GivenISelectALoanAmount()
        {
            calculatorPO.GetSliderAmount();
        }

        [When(@"I select the first Saturday in July as repayment date")]
        public void WhenISelectTheFirstSaturdayInJuly()
        {
            calculatorPO.SelectSaturday();

        }
        [When(@"I select the first Sunday in July as repayment date")]
        public void WhenISelectTheFirstSundayInJulyAsRepaymentDate()
        {
            calculatorPO.SelectSunday();

        }


        [Then(@"the first repayment date option should default to the prior friday")]
        public void ThenTheFirstRepaymentDateOptionShouldBePriorFriday()
        {
            Assert.AreEqual("Friday 3 Jul 2020", calculatorPO.GetRepaymentDate);
            Assert.AreEqual("200", calculatorPO.GetSliderMinValue);
            Assert.AreEqual("500", calculatorPO.GetSliderMaxValue);
            Assert.AreEqual(calculatorPO.GetSelectedLoanAmount, calculatorPO.GetSelectedSliderAmount);
        }


    }
}

