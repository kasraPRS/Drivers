using Drivers.Configuration;

var builder = WebApplication.CreateBuilder(args);

// اضافه کردن Startup به عنوان سرویس
var startup = new Startup(builder.Configuration);
startup.ConfigureServices(builder.Services);

var app = builder.Build();

// راه‌اندازی پیکربندی HTTP
startup.Configure(app, app.Environment);

app.Run();