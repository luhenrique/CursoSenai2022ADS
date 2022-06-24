using Microsoft.EntityFrameworkCore;

public class DataContext : DbContext{

    public DataContext(DbContextOptions<DataContext> 
    options) : base(options){

    }

    public DbSet<Medicos>? medicos {get; set;}
    public DbSet<Especialidades>? especialidades {get; set;}
    public DbSet<Cidades>? cidades {get; set;}
    public DbSet<Usuarios>? usuarios {get; set;}

}