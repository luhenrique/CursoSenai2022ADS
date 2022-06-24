/*-----ESTRURA CONDICIONAL SE/SENAO-------
    CONDICIONAL SIMPLES
    Sintaxe
        if(condição){

        }

        if(condição){

        }else{

        }
    CONDICIONAL COMPOSTA
        if(condição){

        }else if(condiçao){

        }else{

        }
*/

    int num;
    Console.WriteLine("Digite um numero");
    num = Convert.ToInt32(Console.ReadLine());
    if(num == 0){
        Console.WriteLine("Você digitou 0");
    }else if(num % 2 == 0){
        Console.WriteLine("O numero digitado par");
    }else{
         Console.WriteLine("O numero digitado impar");
    }

/*TERNARIOS
    argumento1 != argumento2 ? "sim" : "nao"
*/
    bool resultado;
    resultado = 4 < 5 ? true : false;
    Console.WriteLine(resultado);