//classe é o molde dos objetos
//atributos -> caracteristicas]
//METODOS ACESSORES(GET) E MODIFICADORES(SET) -> GET SET
//CONSTRUTORES
public class Baralho{
    public string marca {get; private set;}
    public string formato {get; set;}
    public string cor {get;  set;}
    public int numCartas {get; private set;}
    public bool embaralhado {get;  private set;} 
    public bool novo {get; private set;}
  

    public Baralho(string marcar, string formato, string cor)
    {
        this.marca = marcar;
        this.formato = formato;
        this.cor = cor;
        this.embaralhado = false;
        this.novo = true;
        this.numCartas = 54;
    }
    public Baralho(){ }
    public void JogarTruco(){
        if(this.embaralhado){
            Console.WriteLine("Vamos jogar!");
        }else if(this.novo){
            Console.WriteLine("Precisa abrir o baralho");
            this.Abrir();
            this.Embaralhar();
            JogarTruco();
        }else{
            Console.WriteLine("Precisa embaralhar");
            this.Embaralhar();
            this.JogarTruco();
        }
        }
    public void Abrir(){
        if(this.novo == false){
            Console.WriteLine("O baralho já foi aberto");
        }else{
            this.novo = false;
            Console.WriteLine("Abrindo");
        }
    }
    public void Embaralhar(){
        if(this.novo == true){
            Console.WriteLine("Primeiro precisa abrir o baralho");
        }else{
        Console.WriteLine("Estou embaralhando");
        this.embaralhado = true;
        }
    }
    public void Mostrar(){
        Console.WriteLine($"A marca do baralho é {this.marca}\n" +
                            $"O formato é {this.formato}\n" +
                            $"A cor é {this.cor}\n" +
                            $"O numero de cartas é {this.numCartas}\n" +
                            $"O baralho esta embaralhado {this.embaralhado}\n" +
                            $"O baralho é novo {this.novo}");
    }
}