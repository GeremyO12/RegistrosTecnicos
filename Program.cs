using RegistrosTecnicos.Components;
using Microsoft.EntityFrameworkCore;
using RegistrosTecnicos.DAL;
using RegistrosTecnicos.Services;

var builder = WebApplication.CreateBuilder(args);


// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

builder.Services.AddSingleton<Radzen.NotificationService>();
builder.Services.AddBlazorBootstrap();

//Obtener el constructor
var ConStr = builder.Configuration.GetConnectionString("ConStr");

//Agregamos el contexto
builder.Services.AddDbContext<Contexto>(options => options.UseSqlite("ConStr"));

//Inyectar el service
builder.Services.AddScoped<TecnicosServices>();
builder.Services.AddScoped<TiposTecnicosServices>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();
