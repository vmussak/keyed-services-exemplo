using WebApplication1.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//builder.Services.AddScoped<IMensagemBoasVindas, MensagemBoasVindasPadrao>();
//builder.Services.AddScoped<IMensagemBoasVindas, MensagemBoasVindasPremium>();

builder.Services.AddKeyedScoped<IMensagemBoasVindas, MensagemBoasVindasPadrao>("Padrao");
builder.Services.AddKeyedScoped<IMensagemBoasVindas, MensagemBoasVindasPremium>("Premium");

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
