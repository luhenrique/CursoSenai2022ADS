using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

[Route("api/[controller]")]
public class UsuariosController : ControllerBase{
    
     private readonly DataContext _context;
     public UsuariosController(DataContext context)
     {
        _context = context;
     }

     [HttpGet]
     public async Task<ActionResult<List<Usuarios>>> GetAll(){
        try{
            var usuarios = await _context.usuarios.ToListAsync();
            return Ok(usuarios);
        }catch(Exception e){
            return BadRequest(e.Message);
        }

     }
}