using DigitalSignature.Data.EF;
using DigitalSignature.Data.Entities;
using DigitalSignature.Ultilities.Constant;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<DigitalSignatureDbContext>(options =>
{
	options.UseSqlServer(builder.Configuration.GetConnectionString("DigitalSignatureDb"));
});
builder.Services.AddIdentity<AppUser,IdentityRole>().AddEntityFrameworkStores<DigitalSignatureDbContext>().AddDefaultTokenProviders();


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
