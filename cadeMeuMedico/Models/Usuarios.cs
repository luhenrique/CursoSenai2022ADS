public class Usuarios{
    public int id { get; set; }
    public string? apelido { get; set; }
    public string? nome { get; set; }
    public string? email { get; set; }
    public string? senha { get; set; }
    public int cidadeid { get; set; }
    public Cidades? cidade { get; set; }
}