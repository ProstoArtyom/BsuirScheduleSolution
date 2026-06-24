using BsuirSchedule.TelegramBot.Handlers;
using Telegram.Bot;
using Telegram.Bot.Polling;
using Telegram.Bot.Types;
using Telegram.Bot.Types.Enums;

namespace BsuirSchedule.TelegramBot
{
    public class BotWorker : BackgroundService
    {
        private readonly ILogger<BotWorker> _logger;
        private readonly ITelegramBotClient _botClient;
        private readonly MessageHandler _messageHandler;
        public BotWorker(ILogger<BotWorker> logger, 
            ITelegramBotClient botClient,
            MessageHandler messageHandler)
        {
            _logger = logger;
            _botClient = botClient;
            _messageHandler = messageHandler;
        }

        protected override async Task ExecuteAsync(CancellationToken ct)
        {
            var receiverOptions = new ReceiverOptions
            {
                AllowedUpdates = [UpdateType.Message, UpdateType.CallbackQuery]
            };

            _botClient.StartReceiving(
                updateHandler: HandleUpdateAsync,
                errorHandler: HandleErrorAsync,
                receiverOptions: receiverOptions,
                cancellationToken: ct
            );

            _logger.LogInformation("Bot has started!");
            await Task.Delay(Timeout.Infinite, ct);
        }

        private async Task HandleUpdateAsync(
            ITelegramBotClient bot,
            Update update,
            CancellationToken ct)
        {
            try
            {
                if (update.Message is { } message)
                    await _messageHandler.HandleAsync(message, ct);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error handling update {UpdateId}", update.Id);
            }
        }

        private Task HandleErrorAsync(
            ITelegramBotClient bot,
            Exception ex,
            HandleErrorSource source,
            CancellationToken ct)
        {
            _logger.LogError(ex, "Telegram polling error from {Source}", source);
            return Task.CompletedTask;
        }
    }
}
