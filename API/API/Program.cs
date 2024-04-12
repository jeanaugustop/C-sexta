using API.MODELS;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

// Produto produto = new Produto();
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

//POST
app.MapPost("/api/produto/cadastrar/", 
    (Produto produto) => 
    {
        //Adicionar o produto dentro da lista
        produtos.Add(produto);   
        return Results.Created("", produto);

        

    });

// ATUALIZAR
app.MapPut("/api/produto/atualizar/{id}", (string id, Produto produtoAtualizado) => 
{
    
    foreach(Produto cadastrado in produtos){

    if (produtoAtualizado.Id == cadastrado.Id)
    {
        cadastrado.Nome = produtoAtualizado.Nome;
        cadastrado.Descricao = produtoAtualizado.Descricao;
        cadastrado.Valor = produtoAtualizado.Valor;

        return Results.Ok(produtoAtualizado);
    }
    }
    return Results.NotFound("Produto Não Encontrado");
    
});

//Remove

app.MapDelete("/api/produto/deletar/{id}", (string id) => 
{
    
    foreach(Produto cadastrado in produtos){

    if (cadastrado.Id == id)
    {
        produtos.Remove(cadastrado);

        return Results.Ok(produtos);
    }
    }
    return Results.NotFound("Produto Não Encontrado");
    
});


app.Run();
