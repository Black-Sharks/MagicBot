using MagicBot.Controller.Controllers;
using MagicBot.Controller.Interfaces;
using MagicBot.Engine.Interfaces;
using Telegram.Bot;
using Telegram.Bot.Types;

namespace MagicBot.Engine.Engines
{
    /// <summary> Класс создания движка для бота Telegram </summary>
    public class TelegramBotEngine : IBotEngine
    {
        /// <summary> Контроллер для бота в движке </summary>
        private IBotCotroller _botCotroller;

        /// <summary> Клиент для бота Telegram </summary>
        private static TelegramBotClient _bot;

        /// <summary> Объект пользователь бот </summary>
        private User _user;

        /// <summary> Инициализация движка бота </summary>
        public void Init(string token)
        {
            _bot = new TelegramBotClient(token);
            _user = _bot.GetMeAsync().Result;
            _botCotroller = new TelegramBotController(_bot);
        }

        /// <summary> Запуск движка бота </summary>
        public void Start()
        {
            _bot.StartReceiving();
        }

        /// <summary> Остановка движка бота </summary>
        public void Stop()
        {
            _bot.StopReceiving();
        }
    }
}
