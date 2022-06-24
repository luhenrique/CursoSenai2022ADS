//PROCEDIMENTOS E FUNÇÕES (MÉTODOS)
/*
    SINTAXE 
       <visibilidade> <retorno> <nome>(parametros){

        }

    procedimento == uma função não tem retorno
    função == tem retorno

    passagem parametros por valor;
    passagem parametros por referencia;

   ----- padrão de declarações -----
        variaveis sem começa com letras minusculas
        funções sempre começa com letra maiusculas 
*/
void ProcSomar(int p1, int p2){ //assinatura do procedimento
     Console.WriteLine(p1);
     Console.WriteLine(p2);
     p1 = 10;
     p2 = 14;
    Console.WriteLine(p1);
    Console.WriteLine(p2);
}


int a = 5;
int b = 6;
ProcSomar( a, b);
Console.WriteLine(a);
Console.WriteLine(b);






