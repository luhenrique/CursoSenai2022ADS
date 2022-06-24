//SOBREESCREVER O METODO ACELERAR 
//SOBREESCREVER O METODO FREAR  
public class Moto : Automovel
{

    public int cilindradas { get; set; }
    public Moto(string marca, string cor, bool ligado, float combustivel, int capTanque, string tipoComb, int cili) : base(marca, cor, ligado, combustivel, capTanque, tipoComb)
    {
        this.cilindradas = cili;
    }
}