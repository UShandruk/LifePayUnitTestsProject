using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using TechTalk.SpecFlow;
using NUnit.Framework;

namespace LifePayUnitTestsProject
{
    [Binding]
    public class Feature1StepDefinitions
    {
        IWebDriver driver;
        string greetingTextActual;
        int hour;

        [Given(@"I Opened main page")]
        public void GivenIOpenedMainPage()
        {
            driver = new ChromeDriver(Settings.PathToSeleniumChromeDriver);
            driver.Navigate().GoToUrl(Settings.NameOfMainPage);
        }

        [Given(@"I see greetingText")]
        public void GivenISeeGreetingText()
        {
            greetingTextActual = driver.FindElement(By.ClassName("header")).FindElement(By.CssSelector("h2")).Text;
        }

        [When(@"DateTime\.Now\.Hour < (.*)")]
        public void WhenDateTime_Now_Hour(int p0)
        {
            hour = DateTime.Now.Hour;
        }

        [Then(@"T see greetintText contains ""([^""]*)""")]
        public void ThenTSeeGreetintTextContains(string p0)
        {
            string greetingTextExpected = Settings.GetGreetintText(hour);
            string errorMessage = "\"" + greetingTextActual + "\"" + " не содержит " + "\"" + greetingTextExpected + "\"";
            Assert.IsTrue(greetingTextActual.Contains(greetingTextExpected), errorMessage);
        }
    }
}
