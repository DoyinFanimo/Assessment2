using AudenTechnicalTest.Hooks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;

namespace AudenTechnicalTest.PageObject
{
    class CalculatorPO
    {
        IWebDriver driver;

        public CalculatorPO()
        {
            driver = Hook.driver;
        }

        public void NavigateToSite(string url)
        {
            driver.Navigate().GoToUrl(url);
        }

        IWebElement slider => driver.FindElement(By.Name("amount"));

        // selects the Sat 4th of the July,current month displayed
        IWebElement selectedSaturday => driver.FindElement(By.XPath("//*[contains(@value, '4')]"));

        // selects the Sat 5th of the July, current month displayed
        IWebElement selectedSunday => driver.FindElement(By.XPath("//*[@id=\"root\"]/div/div/div[1]/div/div[2]/div[1]/section[2]/div/div[1]/span[5]"));

        IWebElement repaymentDate => driver.FindElement(By.XPath("//*[@id='root']/div/div/div[1]/div/div[2]/div[1]/section[2]/div/div[2]/span[2]/label[1]"));

        IWebElement valueSelected => driver.FindElement(By.XPath("//*[@id='root']/div/div/div[1]/div/div[2]/div[1]/section[1]/header/div[2]/span"));

        IWebElement loanAmount => driver.FindElement(By.XPath("//*[@id='root']/div/div/div[1]/div/div[2]/div[1]/section[3]/div[1]/div/span[1]"));
        
        IWebElement selectedSliderAmount => driver.FindElement(By.XPath("//*[@id=\"root\"]/div/div/div[1]/div/div[2]/div[1]/section[3]/div[1]/div/span[1]"));
        
        IWebElement selectedLoanAmount => driver.FindElement(By.XPath("//*[@id=\"root\"]/div/div/div[1]/div/div[2]/div[1]/section[1]/header/div[2]/span"));

        public string GetSelectedLoanAmount => selectedLoanAmount.Text;

        public string GetSelectedSliderAmount => selectedSliderAmount.Text.Substring(0, 4); //removes trailing "." in other to assert
        
        public string GetValueSelected => valueSelected.Text;

        public string GetLoanAmount => loanAmount.Text;

        public string GetRepaymentDate => repaymentDate.Text;

        public string GetSliderMinValue => slider.GetAttribute("min");

        public string GetSliderMaxValue => slider.GetAttribute("max");

        public void SelectSaturday()
        {
            selectedSaturday.Click();
        }

        public void SelectSunday()
        {
            selectedSunday.Click();
        }

        public void ClickFriday()
        {
            repaymentDate.Click();
        }

        public void GetSliderAmount()
        {
            Assert.That(slider.Displayed);
            Actions move = new Actions(driver);
            move.DragAndDrop(slider, slider).Perform();
        }

    }

}
