/*
    REGRAS DAS INTERFACES

    1- METODOS DE INTERFACES NÃO TEM CORPO, APENAS ASSINATURA DE METODOS ABSTRATOS
    2- INTERFACE NÃO TEM ATRIBUTOS NEM CONSTRUTORES
    3- OS METODOS DEVEM SER PUBLICOS
    4- AS CLASSES DERIVADAS DA INTEFACE DEVEM IMPLEMENTAR TODOS OS METODOS 
    5- NÃO TEM COMO INSTANCIAR UMA INTERFACE

*/
/*
                            ACELERAR
                            FREIAR
                            ABASTECER
                            LIGAR
                            DESLIGAR
*/

public interface IAutomovel{

    public abstract void Acelerar();
    public abstract void Frear();
    public abstract void Abastecer(float valor);
    public abstract void MostrarTanque();
    public abstract void Ligar();
    public abstract void Desligar();
}