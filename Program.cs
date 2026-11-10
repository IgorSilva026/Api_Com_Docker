
using Microsoft.EntityFrameworkCore;
using ApiPiagetDois.Data;



var builder = WebApplication.CreateBuilder(args);


builder.Services.AddDbContext<ApiPiagetDoisContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("ApiPiagetDoisContext")
    ?? throw new InvalidOperationException("Connection string 'ApiPiagetDoisContext' not found.")));

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAll", policy =>
    {
        policy.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader();
    });
});





var app = builder.Build();

// Aplicar migrações do banco de dados automaticamente na inicialização
using (var scope = app.Services.CreateScope())
{
    var dbContext = scope.ServiceProvider.GetRequiredService<ApiPiagetDoisContext>();
    dbContext.Database.Migrate(); // Aplica apenas as migracoes pendentes
}

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

// HTTPS deve ser configurado no proxy reverso em producao.
// Docker local utiliza HTTP na porta 8080.


// Policy Cors
app.UseCors("AllowAll");

app.UseAuthorization();

app.MapControllers();

app.Run();
