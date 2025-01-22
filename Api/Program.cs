var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
//добавляет функционал для работы с контроллерами: сервис для обработки http-запросов, сервисы маршрутизации запросов к контроллерам и др.
builder.Services.AddControllers();
var app = builder.Build();
app.UseSwagger();
app.UseSwaggerUI();
app.MapControllers();
app.Run();
