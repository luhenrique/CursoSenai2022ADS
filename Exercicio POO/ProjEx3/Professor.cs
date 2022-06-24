public class Professor : Pessoa{
    public string especialidade { get; set; }
    public float salario {get; set;}

    public Professor(string nome, int idade, string cpf, string esp, float sal) : base(nome, idade, cpf)
    {
        this.especialidade = esp;
        this.salario = sal;
    }

    public void DarAula(){
        Console.WriteLine("O meu diploma já ta na parede");
    }
}
