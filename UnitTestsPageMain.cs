using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using SpecFlow;

namespace LifePayUnitTestsProject
{
    [TestClass]
    public class UnitTestsPageMain
    {
        /// <summary>
        /// Задание 1: Проверка отображения приветствия на экране наверху справа
        ///            (оно меняется в зависимости от времени суток на клиенте)
        /// </summary>
        [TestMethod]
        public void TestGreeting()
        {
            /*
              Примечания:
            1) Полноценный тест-кейс должен проверять отображение приветствия на экране
               (наверху справа, меняется в зависимости от времени суток на клиенте)
            2) Gherkin-сценарии должны проверять наиболее критичные проверки
               (по вашему мнению)
            3) Gherkin-сценарии должны быть написаны так, как вы бы писали в рамках тестового фреймворка внутри компании
               т.е. с учетом применения всех необходимых практик разработки автоматизированных тестов
               (насколько вы считаете необходимым)

               Подсказка:
                    Предполагается, что описанные вами тесты будут запускаться параллельно и многократно.       
             */

            IWebDriver driver = new ChromeDriver(Settings.PathToSeleniumChromeDriver);
            driver.Navigate().GoToUrl(Settings.NameOfMainPage);

            int hour = DateTime.Now.Hour;
            string greetingTextExpected = Settings.GetGreetintText(hour);
            string greetingTextActual = driver.FindElement(By.ClassName("header")).FindElement(By.CssSelector("h2")).Text;

            string errorMessage = "\"" + greetingTextActual + "\"" + " не содержит " + "\"" + greetingTextExpected + "\"";
            Assert.IsTrue(greetingTextActual.Contains(greetingTextExpected), errorMessage);

            driver.Close();
        }
    }
}
