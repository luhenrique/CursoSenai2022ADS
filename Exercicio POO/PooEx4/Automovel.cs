/*
                            MARCAR
                            COR 
                            LIGADO
                            TANQUE
                            COMBUSTIVEL
                            TipoCombustivel*/

public abstract class Automovel : IAutomovel
{

    public string? marca { get; set; }
    public string? cor { get; set; }
    public bool ligado { get; set; }
    public float combustivel { get; set; }
    public int  capTanque { get; set; }
    public string? tipoComb { get; set; } 
    public int velocidade {get; set;}

    public Automovel(string marca, string cor, bool ligado, float combustivel, int capTanque, string tipoComb)
    {
        this.marca = marca;
        this.cor = cor;
        this.combustivel = combustivel;
        this.capTanque  = capTanque;
        this.tipoComb = tipoComb;
        this.velocidade = 0;
        
    }

    public void Abastecer(float valor)
    {
        //PERGUNTAR O TIPO COMBUSTIVEL
        //QUANTO A PESSOA QUER ABASTERCER
        //VERIFICAR SE O TANQUE ESTA CHEIO
        //ATRIBUIR O VALOR AO ATRIBUTO COMBUSTIVEL
        //MOSTRAR QUANTOS LITROS FORAM ABSTECIDOS 
        this.tipoComb = Console.ReadLine();
    }

    public void Acelerar()
    {
        //METODO GENERICO
        //SOBRESCREVER NA CLASSE CARRO E NA MOTO
        // ESCREVAR NA TELA QUE ESTA ACELERANDO
        // CADA VEZ QUE ACELERA MOSTRA A VELOCIDADE
        // CONSOME UM VALOR DO COMBUSTIVEL DIFERENTE PARA MOTO E PARA O CARRO
        // NAO PODE ACELERAR COM O CARRO DESLIGADO
        // AVISAR SE ACABOU A GASOLINA 
        throw new NotImplementedException();
    }

    public void Desligar()
    {
        
        throw new NotImplementedException();
    }

    public void Frear()
    {
        //MOSTRAR QUE ESTA FREIANDO
        //DIMINUIR UMA VALOR X DA VELOCIDADE
        //SE A VELOCIDADE CHEGAR 0 AVISAR QUE O CARRO ESTA PARADA
        throw new NotImplementedException();
    }

    public void Ligar()
    {
        throw new NotImplementedException();
    }

    public void MostrarTanque()
    {
        //MOSTRAR QUANTOS LITROS DO COMBUSTIVEL TEM NO TANQUE
        throw new NotImplementedException();
    }
}