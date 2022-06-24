public abstract class Pessoa{

    public string nome { get; set; }
    public int idade { get; set; }
    public string cpf { get; set; }

    public Pessoa(string nome, int idade, string cpf)
    {
        this.nome = nome;
        this.idade = idade;
        this.cpf = cpf;
    }
    public void QuemEuSou(){
        Console.WriteLine($"Nome: {this.nome}\n" + 
                          $"Idade: {this.idade}\n"
                         +$"CPF: {this.cpf}\n" );
    }
}