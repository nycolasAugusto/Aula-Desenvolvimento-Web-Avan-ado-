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

app.MapPost("/calcular/{numA}/{numB}", (int numA , int numB)=>{
    return (numA + numB);

});

app.MapPost("/Calcular2", (SomaRequest soma) =>{

    int resultado = soma.num1 + soma.num2 ; 

    return Results.Ok(resultado); 



});

app.Run();


public class SomaRequest {

    public int num1 {get;set;}
    public int num2 {get;set;}
}






