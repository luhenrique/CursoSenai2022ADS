/*
CONVERTER PARA INT -> numero =  convert.ToInt32(Console.ReadLine())
CONVERTER PARA FLOAT -> convert.ToSingle(Console.ReadLine())
CONVERTER PARA DOUBLE -> convert.ToDouble(Console.ReadLine())

//CONSTRUA UM ALGORITMO QUE RECEBE O NOME, A ALTURA, PESO E IDADE DE UMA PESSOA
Entrada -> qual o seu nome? Qual seu peso? Qual a sua altura?
processamento -> armazenar os valores
saida -> exibir na tela
            Olá Luiz
            Sou peso é 70kg
            altura 1.78m
            e a sua idade é: 24 anos
*/

string nome;
int idade;
float peso;
float altura;

Console.WriteLine("Qual o seu nome?");                    
nome = Console.ReadLine();
Console.WriteLine("Qual a sua idade?");
idade = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Qual a seu peso?");
peso = Convert.ToSingle(Console.ReadLine());
Console.WriteLine("Qual a sua altura?");
altura = Convert.ToSingle(Console.ReadLine());

Console.WriteLine("Bem vindo " + nome);
Console.WriteLine("A sua idade é: " + idade);
Console.WriteLine("Sua altura " + altura);
Console.WriteLine("Seu peso " + peso);
Console.WriteLine("Adios");
