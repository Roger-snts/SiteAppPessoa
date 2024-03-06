using AppPessoa.Contexto;
using AppPessoa.Data;
using AppPessoa.Services;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;

var builder = WebApplication.CreateBuilder(args);

// Adiciona serviços ao Container. A cada novo serviço criado, é necessário passar aqui com o AddScoped<Serviço>() e o AddSingleton<ContextodeBanco>()
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.AddSingleton<WeatherForecastService>();
builder.Services.AddScoped<PessoaService>(); // Instancia a tabela e os comandos de Pessoas na base de dados
builder.Services.AddSingleton<ContextoBD>(); // Conecta à base de dados

var app = builder.Build();

// Configura a página de Requisições de HTTP
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
