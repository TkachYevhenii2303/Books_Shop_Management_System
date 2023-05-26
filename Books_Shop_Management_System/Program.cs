using Books_Shop_Management_System.CustomMiddlewares;
using Books_Shop_Management_System_BLL.Services;
using Books_Shop_Management_System_BLL.Services.Interfaces;
using Books_Shop_Management_System_DAL.Contex;
using Books_Shop_Management_System_DAL.Unit_of_Work_Pattern;
using Books_Shop_Management_System_DAL.Unit_of_Work_Pattern.Interfaces;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddAutoMapper(typeof(Program));

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<BooksContext>(configuration =>
{
    configuration.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"),
        options => options.MigrationsAssembly("Books_Shop_Management_System_Migrations"));
});

builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();
builder.Services.AddScoped<IBooksServices, BooksServices>();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseMiddleware<ExceptionHandlingMiddleware>();

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();

app.Run();