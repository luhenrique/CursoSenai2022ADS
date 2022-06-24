
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

[Route("api/[controller]")]
public class MedicosController : ControllerBase {

    private readonly DataContext _context;

    public MedicosController(DataContext context){
        _context = context;
    }

[HttpGet]
public async Task<ActionResult<List<Medicos>>> GetAll(){
    
    try{
          var medicos = await _context.medicos.ToListAsync();
          return Ok(medicos);
    }catch(Exception e){
          return BadRequest(e.Message);
    }
}


[HttpPost]
public async Task<ActionResult<List<Medicos>>> Create(MedicosDtos request){
    try{
        var medico = new Medicos{
            nome = request.nome,
            endereco = request.endereco,
            crm = request.crm,
            telefone = request.telefone,
            cidadeid = request.idCidade,
            especialidadeid = request.idEspecialidade
        };
        _context.medicos.Add(medico);
        await _context.SaveChangesAsync();
        return Created("/api/[controller]", medico);
    }catch(Exception e){
        return BadRequest(e.Message);
    }

}
[HttpPut]
public async Task<ActionResult<List<Medicos>>> Update(int id, MedicosDtos request){
    try{
        
        var medico = await _context.medicos.FindAsync(id);
        if(medico == null){
            return NotFound();
        }

        medico.nome = request.nome;
        medico.cidadeid = request.idCidade;
        medico.especialidadeid = request.idEspecialidade;
        medico.crm = request.crm;
        medico.endereco = request.endereco;
        medico.telefone = request.telefone;  

        await _context.SaveChangesAsync();
        return Ok(medico);     

    }catch(Exception e){
        return BadRequest($"Deu ruim {e.Message}");
    }
}
[HttpDelete]
public async Task<ActionResult<List<Medicos>>> Delete(int id){
   
    try{
        var medico = await _context.medicos.FindAsync(id);
        if(medico == null)
        return NotFound();
        _context.medicos.Remove(medico);
        await _context.SaveChangesAsync();
        return Ok();
    }catch(Exception e){
        return BadRequest();
    }
}

[HttpGet("{id}")]
public async Task<ActionResult<List<Medicos>>> GetById(int id){
    try{
        var medico = await _context.medicos
                        .Where(m => m.id == id)
                        .Include(e => e.especialidade)
                        .Include(c => c.cidade)
                        .ToListAsync();  //LINQ
   /* if(medico == null)
        return NotFound(); 
    return Ok(medico);*/
    return medico == null ? NotFound() : Ok(medico);
    }catch(Exception e){
        return BadRequest(e.Message);
    }
}
[HttpGet("/especialidade")]
public async Task<ActionResult<List<Medicos>>> GetByEspecialidadeCidade(int idEspecialidade, int idCidade){
    try{
        var medico = await _context.medicos
                     .Where(m => m.especialidadeid == idEspecialidade && m.cidadeid == idCidade)
                     .ToListAsync();
        return medico == null ? NotFound() : Ok(medico);       
    }catch(Exception e){
        return BadRequest(e.Message);
    }
}
}