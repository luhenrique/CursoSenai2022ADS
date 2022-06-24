/*  1- ABSTRAÇÃO
    2- ENCAPSULAMENTO
    3- HERANÇA
    4- POLIMORFISMO 

    CLASSE BASE -> MÃE, PAI, SUPER CLASSE 
    CLASSE DERIVADA -> FILHA, SUBCLASSE

    C# NÃO PERMITE HERANÇA MULTIPLA 
    HERANÇA TRANSITIVA
*/
/*CRIAR UM PROJETO ORIENTADO A OBJETO
     CLASSE BASE(ABSTRATA) -> PESSOA
     CLASSE DERIVADA -> ALUNO
                     -> PROFESSOR
                     -> COLABORADOR


*/

Gato g1 = new Gato("mi",40f,3f,5,"vira lata",false);
Cachorro C1 = new Cachorro("Florinda",40f,3f,5,"vira lata",true);
Passaro p1 = new Passaro();


C1.Brincar();
p1.Brincar();