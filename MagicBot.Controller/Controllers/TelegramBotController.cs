using MagicBot.Controller.Interfaces;
using MagicBot.Model.Services;
using Telegram.Bot;
using Telegram.Bot.Args;
using Telegram.Bot.Types;

namespace MagicBot.Controller.Controllers
{
    /// <summary> Класс создания контроллера для бота Telegram в движке </summary>
    public class TelegramBotController : IBotCotroller
    {
        /// <summary> Клиент для бота Telegram API </summary>
        private static TelegramBotClient _bot;

        /// <summary> Сервис обработки сообщения - отвечает пришедшим собщением </summary>
        private ReplayMessageService _replayMessageService;

        public TelegramBotController(TelegramBotClient bot)
        {
            _bot = bot;

            Init();
            Subscribe();
        }
        
        /// <summary> Инициализация котроллера </summary>
        private void Init()
        {
            _replayMessageService = new ReplayMessageService();
        }

        /// <summary> Подписываемся на события от Telegram API </summary>
        private void Subscribe()
        {
            _bot.OnMessage += BotOnOnMessage;
        }
        
        /// <summary> Пришло сообщение </summary>
        private void BotOnOnMessage(object sender, MessageEventArgs messageEventArgs)
        {
            Message message = messageEventArgs.Message;
            if (message != null)
            {
                _bot.SendTextMessageAsync(message.Chat.Id, _replayMessageService.Execute(message.Text));
            }
        }
    }
}
