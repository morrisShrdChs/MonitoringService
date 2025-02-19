var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddSingleton<IDeviceService, DeviceService>();




var app = builder.Build();

app.UseHttpsRedirection();
app.MapControllers();

app.Run();
