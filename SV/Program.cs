using SV.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddCors(o => { o.AddPolicy("AllowAny", p => { p.AllowAnyHeader().AllowAnyMethod().AllowAnyOrigin(); }); });

builder.Services.AddScoped<AddTwoNumbersService>();
builder.Services.AddScoped<AskTwoQuestionsService>();
builder.Services.AddScoped<GuessItService>();
builder.Services.AddScoped<HelloWorldService>();
builder.Services.AddScoped<MadLibService>();
builder.Services.AddScoped<Magic8BallService>();
builder.Services.AddScoped<OddOrEvenService>();
builder.Services.AddScoped<RestaurantPickerService>();
builder.Services.AddScoped<ReverseItAlphanumericService>();
builder.Services.AddScoped<ReverseItNumericService>();

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors("AllowAny");

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
