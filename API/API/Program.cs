using API.MODELS;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

Produto produto = new Produto();
// produto.setNome("Bolacha");
// Console.WriteLine(produto.getNome());


List<Produto> produtos = new List<Produto>();
produtos.Add(new Produto("Celular", "XIAOMI", 4000));
produtos.Add(new Produto("Celular", "SAMSUNG", 2500));
produtos.Add(new Produto("Celular", "MOTOROLA", 2000));
produtos.Add(new Produto("Celular", "POCO", 5000));

app.MapGet("/", () => "Hello World!");

app.MapGet("/api/produto/listar", () => produtos);

app.MapGet("/api/produto/buscar/{id}", (string id) => 
{
    foreach(Produto cadastrado in produtos){
        if(cadastrado.Id == id){
            //Retornar produto encontrado
            return Results.Ok(cadastrado);
        }
        else{
            
        }
    }
    //Produto não encontrado
    return Results.NotFound("Produto Não Encontrado");
});

app.MapPost("/api/produto/cadastrar", () => "Cadastro de Produtos");



app.Run();
