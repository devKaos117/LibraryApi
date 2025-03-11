using Application.Interfaces;

WebApplicationBuilder builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//builder.Services.AddScoped<ILogging, LogTracingService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

// Adding Middleware - LogTracingService
/*
app.Use(async (context, next) =>
{
    var logTracingService = context.RequestServices.GetRequiredService<ILogging>();
    logTracingService.Log(LogLevel.Trace, "");
    await next.Invoke();
});
*/

// Adding Middleware - GlobalExceptionHandling
app.Use(async (context, next) =>
{
    try
    {
        await next.Invoke();
    } catch (Exception e)
    {
        Console.WriteLine(e.ToString());
    }
});

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
