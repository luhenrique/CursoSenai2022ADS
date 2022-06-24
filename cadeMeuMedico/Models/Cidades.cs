public class Cidades{
    public int id { get; set; }
    public string? nome { get; set; } 
    public string? estado { get; set; }
    public List<Medicos>? medicos { get; set; }
    public List<Especialidades>? especialidades { get; set; }
}