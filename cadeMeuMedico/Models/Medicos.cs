public class Medicos{
    public int id { get; set; }
    public string? nome { get; set; }
    public int cidadeid { get; set; } //relacionamento 1:1
    public Cidades? cidade { get; set; }
    public int especialidadeid { get; set; }
    public Especialidades? especialidade { get; set; } //1:1
    public string? crm { get; set; }
    public string? endereco { get; set; }
    public string? telefone { get; set; }
}