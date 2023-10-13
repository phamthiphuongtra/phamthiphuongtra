using Microsoft.EntityFrameworkCore;
using He_thong_muon_tra_thiet_bi.Data;
using He_thong_muon_tra_thiet_bi.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddCors(options => options.AddDefaultPolicy(policy => policy.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod().AllowCredentials()));
builder.Services.AddDbContext<DeviceContext>(options => {
    options.UseSqlServer(builder.Configuration.GetConnectionString("HTMTTB"));
});
builder.Services.AddAutoMapper(typeof(Program));

// life cycle DI: AddSingleton(), AddTransient(), AddSsoped()
builder.Services.AddScoped<IBorrowRepository, BorrowRepository>();
builder.Services.AddScoped<IDeviceRepository, DeviceRepository>();
builder.Services.AddScoped<IStaffRepository, StaffRepository>();

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
