namespace API.MODELS;

public class Produto{

    //Construtores
    public Produto(){
        Id = Guid.NewGuid().ToString();
        CriadoEm = DateTime.Now;
    }

    public Produto(string nome, string descricao, double valor){
        Nome = nome;
        Descricao = descricao;
        Valor = valor;
        Id = Guid.NewGuid().ToString();
        CriadoEm = DateTime.Now;
    }

    //Caracteristicas - Atributos e Propriedades
    public string Id {get; set; }
    public string Nome{get; set; }
    public string Descricao {get; set; }
    public double Valor {get; set; }
    public DateTime CriadoEm {get; set; }
    // private string nome;

    // //set - colocando algo 
    // public void setNome (string nome){
    //     this.nome = nome;
    // }

    // //get - pegando algo
    // public string getNome(){
    //     return this.nome;
    // }


}