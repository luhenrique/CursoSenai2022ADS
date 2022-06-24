public class Especialidades{ //relacionamento 1:n
    public int id { get; set; }
    public string? nome { get; set; }
    public List<Medicos>? medicos { get; set; }
    public List<Cidades>? cidades { get; set; }
}