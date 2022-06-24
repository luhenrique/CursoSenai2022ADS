using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

[Route("/api/[controller]")]
public class EspecialidadesController : ControllerBase{
     private readonly DataContext _context;
     public EspecialidadesController(DataContext context)
     {
        _context = context;
     }

     [HttpGet]
     public async Task<ActionResult<List<Especialidades>>> GetAll(){
        try{
                var especialidades = await _context.especialidades.ToListAsync();
                return Ok(especialidades);
        }catch (Exception e){
                return BadRequest(e.Message);
        }

     }
     [HttpPost]
     public async Task<ActionResult<List<Especialidades>>> Create(EspecialidadesDtos request){
        try{
           var especialidade = new Especialidades{
                nome = request.nome
           }; 
           _context.especialidades.Add(especialidade);
           await _context.SaveChangesAsync();
           return Created("api/[controller]", especialidade);    

        }catch(Exception e){
                return BadRequest($"DEU RUIM PAI: {e.Message}");
        }

     }
     [HttpPut]
     public async Task<ActionResult<List<Especialidades>>> Update(int id, EspecialidadesDtos request){
        try{
                var especialidade = await _context.especialidades.FindAsync(id);
                if(especialidade == null)
                        return NotFound();
                especialidade.nome = request.nome;

                await _context.SaveChangesAsync();
                return Ok();
        }catch(Exception e){
                return BadRequest(e.Message);
        }
     }
[HttpDelete]
public async Task<ActionResult<List<Especialidades>>> Delete(int id){
   
    try{
        var especialidade = await _context.especialidades.FindAsync(id);
        if(especialidade == null)
        return NotFound();
        _context.especialidades.Remove(especialidade);
        await _context.SaveChangesAsync();
        return Ok();
    }catch(Exception e){
        return BadRequest();
    }
}
[HttpGet("{id}")]
public async Task<ActionResult<List<Especialidades>>> GetById(int id){

    try{
        var especialidade = await _context.especialidades
                        .Where(c => c.id == id)
                        .Include(m => m.medicos)
                        .ToListAsync();  //LINQ
   /* if(medico == null)
        return NotFound(); 
    return Ok(medico);*/
    return especialidade == null ? NotFound() : Ok(especialidade);
    }catch(Exception e){
        return BadRequest(e.Message);
    }


}


}