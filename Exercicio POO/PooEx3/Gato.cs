public class Gato : Animal {

    public bool bolaDePelo { get; set; }

    public Gato(string nome, float altura, float peso, int idade, string raca, bool bolaDePelo)
    {
        this.nome = nome;
        this.altura = altura;
        this.peso = peso;
        this.idade = idade;
        this.raca = raca;
        this.bolaDePelo = bolaDePelo;
        
    }

    public override void interagir()
    {
        Console.WriteLine("Estou miando!");
    }

    public override void Brincar()
    {
       Console.WriteLine("Estou arranhando o sofa");
    }
}