using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LifePayUnitTestsProject
{
    /// <summary>
    /// Настройки
    /// </summary>
    public static class Settings
    {
        /// <summary>
        /// URL-адрес сайта (https://my.life-pos.ru)
        /// </summary>
        public static string NameOfPage = "https://" + "my.life-pos.ru";

        /// <summary>
        /// Адрес главной страницы (NameOfPage + "/auth/login")
        /// </summary>
        public static string NameOfMainPage = NameOfPage + "/auth/login";

        /// <summary>
        /// Путь к драйверу Selenium для браузера Chrome
        /// </summary>
        public static string PathToSeleniumChromeDriver = Environment.CurrentDirectory;

        /// <summary>
        /// Получить текст приветствия в зависимости от времени
        /// «Доброе утро» — до 11 часов, «Добрый день» — до 18 часов, «Добрый вечер» — до 23 часов.
        /// </summary>
        /// <param name="hour">Время в часах</param>
        /// <returns>Текст приветствия в зависимости от времени</returns>
        public static string GetGreetintText(int hour)
        {
            string greetintText = "";            

            if (hour < 11)
                greetintText = "Доброе утро";
            else if (hour < 18)
                greetintText = "Добрый день";
            else if (hour < 23)
                greetintText = "Добрый вечер";

            return greetintText;
        }
    }
}
