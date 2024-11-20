using System.Text;
using System.Text.Json;
using Microsoft.AspNetCore.Mvc;
using MN_Webhook;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddHttpClient("client-without-certs").ConfigurePrimaryHttpMessageHandler(_ => new HttpClientHandler
{
    ServerCertificateCustomValidationCallback = (sender, cert, chain, sslPolicyErrors) => { return true; }
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();



app.MapGet("/triggerwebhook", async (HttpContext context, [FromServices]IHttpClientFactory httpClientFactory) =>
    {
        var client = httpClientFactory.CreateClient("client-without-certs");
        
        var json = JsonSerializer.Serialize(new WebhookPayload()
        {
            Payload = "Hello World!"
        });
        var content = new StringContent(json, Encoding.UTF8, "application/json");

        
        await client.PostAsync("http://localhost:54652/receivewebhook",  content);
        context.Response.StatusCode = StatusCodes.Status202Accepted;
    })
    .WithName("TriggerWebhook")
    .WithOpenApi();

app.MapPost("/receivewebhook", async (WebhookPayload payload) =>
    {
        return TypedResults.Ok();
    })
    .WithName("ReceiveWebhook")
    .WithOpenApi();

app.Run();

