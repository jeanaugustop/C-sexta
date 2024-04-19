using Microsoft.EntityFrameworkCore;

namespace API.MODELS;

//Classe que representa o EntityFramewok dentro do projeto
public class AppDataContext : DbContext
{

    //Classes que vao representar as tabelas no BD
    public DbSet<Produto> Produtos {get; set; }


    //Configurando qual banco de dados vai ser utilizado
    //Configurando a string de conexao
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite("Data Source=app.db");
    }

}