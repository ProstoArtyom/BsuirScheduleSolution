using BsuirSchedule.Application.Abstractions;
using BsuirSchedule.Application.Services;
using BsuirSchedule.Infrastructure.BsuirApi;
using Microsoft.Extensions.Options;
using Polly;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.Configure<BsuirApiOptions>(builder.Configuration.GetSection(BsuirApiOptions.SectionName));
builder.Services.AddHttpClient<IBsuirClient, BsuirClient>((sp, client) =>
{
    var options = sp.GetRequiredService<IOptions<BsuirApiOptions>>().Value;
    client.BaseAddress = new Uri(options.BaseUrl);
    client.Timeout = TimeSpan.FromSeconds(options.TimeoutSeconds);
    client.DefaultRequestHeaders.Add("Accept", "application/json");
})
.AddTransientHttpErrorPolicy(p => p.WaitAndRetryAsync(3, i => TimeSpan.FromMilliseconds(300 * i)));

builder.Services.AddScoped<IGroupService, GroupService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();

app.Run();
