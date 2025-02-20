var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddControllers();
builder.Services.AddCors(option =>
    option.AddPolicy("allow_origin", policy =>
    {
        //policy.AllowAnyOrigin(); //cho phep tat ca cac client co the gui du lieu toi server
        policy.WithOrigins("https://localhost:5001/")
         .AllowAnyHeader() //CHo phep rq tat ca header
         .AllowAnyMethod() //cho phep rq tat ca cac menthod
         .AllowCredentials(); //cho phep cookie 
    })
);
var app = builder.Build();


// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseCors("allow_origin");
//map cac ruote vaof swagger
app.MapControllers();


app.UseHttpsRedirection();
app.Run();
