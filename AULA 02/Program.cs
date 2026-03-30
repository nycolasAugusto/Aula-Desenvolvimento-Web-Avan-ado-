using aula02;




var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
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

app.UseHttpsRedirection();



app.MapPost("/api/pessoa", (Pessoa pessoa) => {
    
    
    return $"Recebi o nome {pessoa.Nome} de {pessoa.Idade} anos" ;


});

app.MapPost("/api/pessoa/maior", (Pessoa pessoa) => {
    
    if (pessoa.Idade >= 18)
    {
        
    return $"A pessoa : {pessoa.Nome} de {pessoa.Idade} anos é Maior de Idade" ;
    
    
    }

       return $"A pessoa : {pessoa.Nome} de {pessoa.Idade} anos é Menor de Idade" ;


});

app.Run();


