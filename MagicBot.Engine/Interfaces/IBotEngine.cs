namespace MagicBot.Engine.Interfaces
{
    public interface IBotEngine
    {
        /// <summary> Инициализация движка бота </summary>
        void Init(string token);

        /// <summary> Запуск движка бота </summary>
        void Start();

        /// <summary> Остановка движка бота </summary>
        void Stop();
    }
}
