Console.WriteLine("Olá mundo! Eu sou o Luiz");
Console.WriteLine("Meu primeiro programa C#");

/*TIPOS DE VARIAVEIS
    INTEIRO  ->   int     (4byte)  - 2 bilhoes + bilhoes 
    REAL     ->   float   (8byte)  - 15 casas depois do ponto
    CARACTER ->   char    (1byte)  - alfanumericos
    CADEIA   ->   string  (2byte)  - por caracter alfanumerico
    LOGICO   ->   bool    (1byte)  - true ou false
                  long 
                  double
*/

//constante
//const int constante = 15;

/*
----------OPERADORES ARITMÉTICOS
a + b -> adição
a - b -> subtração
a * b -> multiplicação
a / b -> divisão
a % b -> modulo (resto da divisão)

incremento depois
a++ -> a = a + 1
a-- -> a = a - b
incremento antes
++a
--a 


numero+= 5; -> numero = numero + 5
numero-= 5; -> numero = numero - 5
numero*= 5; -> numero = numero * 5
numero/= 5; -> numero = numero / 5
numero%= 5; -> numero = numero % 5

-----------OPERADORES RELACIONAIS--------------
    == -> IGUAL (A == B)
    != -> DIFERENTE (A != B)
    <  -> MENOR (A < B)
    >  -> MAIOR (A > B)
    <= -> MENOR IGUAL (A <= B)
    >= -> MAIOR IGUAL (A >= B)

-----------OPERADORES LOGICOS----------------
    && -> E   (A && B)
    || -> OU  (A || B)
    !  -> NÃO  (!A)  

*/

string nome;
int num;
Console.WriteLine("Digite um numero:");
num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Voce digitou o numero: " + num);

/*
CONVERTER PARA INT -> convert.ToInt32
CONVERTER PARA FLOAT -> convert.ToSingle
CONVERTER PARA DOUBLE -> convert.ToDouble

//CONSTRUA UM ALGORITMO QUE RECEBE O NOME, A ALTURA, PESO E IDADE DE UMA PESSOA 
Entrada -> qual o seu nome? Qual seu peso? Qual a sua altura?
processamento -> armazenar os valores
saida -> exibir na tela 
            Olá Luiz
            Sou peso é 70kg
            altura 1.78m
            e a sua idade é: 24 anos 
*/


