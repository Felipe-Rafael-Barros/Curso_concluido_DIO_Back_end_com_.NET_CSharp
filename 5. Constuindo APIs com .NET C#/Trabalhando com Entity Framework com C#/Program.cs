/*
dotnet tool install --global dotnet-ef( so precisa ser instalada uma vez na máquina)
dotnet add package Microsoft.EntityFrameworkCore.Design(Essa precisa se instalada a cada novo projeto)
dotnet add package Microsoft.EntityFrameworkCore.SqlServer(Essa precisa se instalada a cada novo projeto)



No app.setting:
"ConnectionStrings":
  {
    "ConexaoPadrao": "Server=localhost\\sqlexpress;Initial Catalog=Agenda; Integrated Security=True"
  }
*/

using Introdução_a_APIs_com_C_.Context; //Pasta
using Microsoft.EntityFrameworkCore; //EF
var builder = WebApplication.CreateBuilder(args);

//Conexão que fizemos para o DB
builder.Services.AddDbContext<AgendaContext>(optins =>
    optins.UseSqlServer(builder.Configuration.GetConnectionString("ConexaoPadrao"))
);

// Adiciona suporte a controladores
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configuração do pipeline HTTP
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseAuthorization();

// Mapeia as rotas dos controladores
app.MapControllers();

app.Run();
