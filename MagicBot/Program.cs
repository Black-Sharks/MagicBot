using System;
using MagicBot.Engine.Engines;
using MagicBot.Engine.Interfaces;

namespace MagicBot
{
    static class Program
    {
        /// <summary> Здесь происходит запуск бота </summary>
        static void Main(string[] args)
        {
            // Уникальный токен бота
            string token = "844559531:AAGXqxAvpK1oO5w9gY5MCvJ678BYY2jLdnY";

            // Создание движка бота
            IBotEngine botEngine = new TelegramBotEngine();

            // Инициализация движка бота
            botEngine.Init(token);

            // Запуск движка бота
            botEngine.Start();

            // Блокируем консоль
            Console.ReadLine();

            // Остановка движка бота
            botEngine.Stop();
        }
    }
}
