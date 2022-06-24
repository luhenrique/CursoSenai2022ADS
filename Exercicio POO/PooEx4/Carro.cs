
//SOBREESCREVER O METODO ACELERAR 
//SOBREESCREVER O METODO FREAR  
public class Carro : Automovel
{

    public int  numPorta { get; set; }
    public int capPortaMala { get; set; }
    public Carro(string marca, string cor, bool ligado, float combustivel, int capTanque, string tipoComb, int numPorta, int capPortaMala) : base(marca, cor, ligado, combustivel, capTanque, tipoComb)
    {
        this.numPorta = numPorta;
        this.capPortaMala = capPortaMala;
    }

}