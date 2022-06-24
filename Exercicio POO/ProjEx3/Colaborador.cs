public class Colaborador : Pessoa
{
    public string funcao { get; set; }
    public float salario { get; set; }
    public Colaborador(string nome, int idade, string cpf, string func, float sal) : base(nome, idade, cpf)
    {
        this.funcao = func;
        this.salario = sal;
    }

    public void Trabalhar(){
        Console.WriteLine("Estou trabalhando");
    }
}