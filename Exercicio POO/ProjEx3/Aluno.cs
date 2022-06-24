public class Aluno : Pessoa
{
    public int ra { get; set; }
    public int turma { get; set; }

    public Aluno(string nome, int idade, string cpf, int ra, int turma) : base(nome, idade, cpf)
    {
        this.ra = ra;
        this.turma = turma;
    }

    public void Estudar(){
        Console.WriteLine("Estou estudando");
    }

    
}