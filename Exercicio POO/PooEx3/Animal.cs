/*
    CLASSE ABSTRATA -> NÃO PODE INSTANCIAR OBJETOS 

    REGRAS DAS CLASSES ABSTRATAS
        1- Pode ter construtor, porém o construtor não pode ser abstrato
        2- Pode contar métodos abstratos e concretos 
        3- Se uma classe contem metodos abstratos ela deve ser abstrata
        4- Um metodos abstrato não pode ser private
        5- Todas as classes derivadas devem instanciar os metodos abstratos

    METODOS VIRTUAIS
*/
public abstract class Animal : SerVivo{

    public string nome { get; set; }
    public float peso { get; set; }
    public float altura { get; set; }
    public int idade { get; set; }
    public string raca { get; set; }


    public void Respirar(){
        Console.WriteLine("Estou respirando");
    }

    public abstract void interagir(); //-> assinatura do metodo

    public virtual void Brincar(){
        Console.WriteLine("Brincadeira generica");
    }

}