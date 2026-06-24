using Telegram.Bot;
using Telegram.Bot.Types;

namespace BsuirSchedule.TelegramBot.Handlers;

public sealed class MessageHandler
{
    private readonly ITelegramBotClient _botClient;
    public MessageHandler(ITelegramBotClient botClient)
    {
        _botClient = botClient;
    }

    public async Task HandleAsync(Message message, CancellationToken ct)
    {
        var text = message.Text?.Trim();
        if (string.IsNullOrEmpty(text)) return;

        var response = text switch
        {
            "/start" => "Привет! Введи номер группы, например: 253505",
            _ when text.StartsWith("/") => "Неизвестная команда",
            _ => await HandleGroupRequestAsync(text, ct)
        };

        await _botClient.SendMessage(message.Chat.Id, response, cancellationToken: ct);
    }

    private async Task<string> HandleGroupRequestAsync(string groupNumber, CancellationToken ct)
    {
        return $"Сообщение: {groupNumber}";
    }
}