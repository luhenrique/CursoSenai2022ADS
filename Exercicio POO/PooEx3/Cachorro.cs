public class Cachorro : Animal {

    public bool Carente { get; set; }



    public Cachorro(string nome, float altura, float peso, int idade, string raca, bool carente)
    {
        this.nome = nome;
        this.altura = altura;
        this.peso = peso;
        this.idade = idade;
        this.raca = raca;
        this.Carente = Carente;     
    }

    public override void interagir()
    {
        Console.WriteLine("estou latindo");
    }

    public override void Brincar()
    {
        Console.WriteLine("Estou correndo atras do meu rabo");
    }
}