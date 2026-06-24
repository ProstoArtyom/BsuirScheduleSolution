using BsuirSchedule.TelegramBot;
using BsuirSchedule.TelegramBot.Handlers;
using Microsoft.Extensions.Options;
using Telegram.Bot;

var builder = Host.CreateApplicationBuilder(args);

builder.Services.Configure<BotOptions>(
    builder.Configuration.GetSection(BotOptions.SectionName)
);

builder.Services.AddSingleton<ITelegramBotClient>(sp =>
{
    var options = sp.GetRequiredService<IOptions<BotOptions>>().Value;
    return new TelegramBotClient(options.Token);
});

builder.Services.AddSingleton<MessageHandler>();
builder.Services.AddHostedService<BotWorker>();

var host = builder.Build();
host.Run();
