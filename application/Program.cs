/*
*   Imports
*/
using Application.Interfaces;
using Application.Modules;

/*
*   WebApp Builder Configuration
*/
WebApplicationBuilder builder = WebApplication.CreateBuilder(args);

//  Adding services
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<ILogging, SysLogger>();
builder.Services.AddHttpContextAccessor();

// Building the app
var app = builder.Build();

/*
*   WebApp Settings
*/

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

/*
*   Adding Middlewares
*/

// SysLogger
app.Use(async (context, next) =>
{
    var logTracingService = context.RequestServices.GetRequiredService<ILogging>();
    SysLogger.Log(LogLevel.Trace, "test logging");
    await next.Invoke();
});

// GlobalExceptionHandling
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

//  Controllers
app.MapControllers();
/*
*   RUN
*/
app.Run();
