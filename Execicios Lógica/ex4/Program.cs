/*
laços de repetição 
    ENQUANTO
        SINTAXE
            while(condição){

            }


    LAÇO PARA
        for(variavel contadora; condição; incremento){

        }


    LAÇO REPITA
        do{
            
        }while(condição);
*/

/*
    int i;
    i = 0;
    Console.WriteLine("Estou no laço while"); //laço condicional
    while(i <= 5){                      
        Console.WriteLine(i);
        i++;
    }
    Console.WriteLine("Estou no laço for"); //laço contado
    for(i = 0; i <= 5; i++){
        Console.WriteLine(i);
    }

    Console.WriteLine("Estou no laço do-while"); //laço condicional
    i = 0;
    do{
        Console.WriteLine(i);
        i++;
    }while(i <= 5);
*/
//ESCREVA UM ALGORITMO QUE ESCREVA A SEQUENCIA DE FIBONACCI NA TELA 

    int n1, n2, prox;
    n1 = 1;
    n2 = 1;
    prox = 0;
    Console.WriteLine("Fibonacci com laço for");
    Console.Write(n1 + " - " + n2 + " - ");
    for(int i = 1; i <= 10; i++){
        prox = n1 + n2;
        Console.Write(prox + " - ");
        n1 = n2;
        n2 = prox;
    }
//-------------------------------------
// FIBONACCI COM WHILE
    n1 = 1;
    n2 = 1;
    prox = 0;
    Console.WriteLine("\n Fibonacci com laço while");
    Console.Write(n1 + " - " + n2 + " - ");
    while(prox < 144){
        prox = n1 + n2;
        Console.Write(prox + " - ");
        n1 = n2;
        n2 = prox;
    }
//-------------------------------------
// FIBONACCI COM DO-WHILE
    n1 = 1;
    n2 = 1;
    prox = 0;
    int j = 0;
    Console.WriteLine("\n Fibonacci com laço DO-while");
    Console.Write(n1 + " - " + n2 + " - ");
    do{
        prox = n1 + n2;
        Console.Write(prox + " - ");
        n1 = n2;
        n2 = prox;
        j++;
    }while(j < 10);