using AppPessoa.Contexto;
using AppPessoa.Data;
using AppPessoa.Services;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;

var builder = WebApplication.CreateBuilder(args);

// Adiciona servi�os ao Container. A cada novo servi�o criado, � necess�rio passar aqui com o AddScoped<Servi�o>() e o AddSingleton<ContextodeBanco>()
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.AddSingleton<WeatherForecastService>();
builder.Services.AddScoped<PessoaService>(); // Instancia a tabela e os comandos de Pessoas na base de dados
builder.Services.AddSingleton<ContextoBD>(); // Conecta � base de dados

var app = builder.Build();

// Configura a p�gina de Requisi��es de HTTP
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseRouting();

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();
