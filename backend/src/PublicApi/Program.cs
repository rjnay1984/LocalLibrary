var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllers(opt => {
    opt.UseNamespaceRouteToken();
});
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();
app.UseEndpoints(endpoints => {
    endpoints.MapControllers();
});
app.UseSwagger();
app.UseSwaggerUI();

app.Run();
