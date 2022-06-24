using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

[Route("api/[controller]")]
public class CidadesController : ControllerBase{
     private readonly DataContext _context;
     public CidadesController(DataContext context)
     {
        _context = context;
     }
    [HttpGet]
     public async Task<ActionResult<List<Cidades>>> GetAll(){
        
        try{
                var cidades = await _context.cidades.ToListAsync();
                return Ok(cidades);
        }catch(Exception e){
                return BadRequest(e.Message);
        }

     }

     [HttpPost]
     public async Task<ActionResult<List<Cidades>>> Create(CidadesDtos request){
        try{
           var cidade = new Cidades{
                nome = request.nome,
                estado = request.estado
           }; 
           _context.cidades.Add(cidade);
           await _context.SaveChangesAsync();
           return Created("api/[controller]", cidade);    

        }catch(Exception e){
                return BadRequest(e.Message);
        }

     }

     [HttpPut]
     public async Task<ActionResult<List<Cidades>>> Update(int id, CidadesDtos request){
        try{
                var cidade = await _context.cidades.FindAsync(id);
                if(cidade == null)
                        return NotFound();
                cidade.nome = request.nome;
                cidade.estado = request.estado;

                await _context.SaveChangesAsync();
                return Ok(cidade);
        }catch(Exception e){
                return BadRequest();
        }
     }
     [HttpDelete]
     public async Task<ActionResult<List<Cidades>>> Delete(int id){
        try{
                var cidade = await _context.cidades.FindAsync(id);
                if(cidade == null)
                        return NotFound();
                _context.cidades.Remove(cidade);
                _context.SaveChangesAsync();
                return Ok();
        }catch(Exception e){
                return BadRequest(e.Message);
        }
     }

[HttpGet("{id}")]
public async Task<ActionResult<List<Cidades>>> GetById(int id){

    try{
        var cidade = await _context.cidades
                        .Where(c => c.id == id)
                        .Include(m => m.medicos)
                        .ToListAsync();  //LINQ
   /* if(medico == null)
        return NotFound(); 
    return Ok(medico);*/
    return cidade == null ? NotFound() : Ok(cidade);
    }catch(Exception e){
        return BadRequest(e.Message);
    }


}

}