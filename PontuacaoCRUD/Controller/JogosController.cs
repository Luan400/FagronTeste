using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PontuacaoCRUD.Models;
using PontuacaoCRUD.Infrastructure; 
using PontuacaoCRUD.Entitites;
using Microsoft.EntityFrameworkCore;

namespace PontuacaoCRUD.Controller
{
    [Route("api/[controller]")]
    public class JogosController : ControllerBase
    {
    
    private readonly PontuacaoDbContext _context;

    public JogosController(PontuacaoDbContext context)
    {
        _context = context;
    }

        [HttpPost("dados")]

        public async Task<IActionResult> RegistrarPontosAsync ([FromBody] Jogo jogo)
        {
        
        await _context.Jogos.AddAsync(jogo);
        await  _context.SaveChangesAsync();
          return Ok();
        }

        [HttpDelete("{Id}")]

        public async Task<IActionResult> DeleteAsync(int id)
        {
         Jogo jogo = await _context.Jogos.FindAsync(id);
         _context.Remove(jogo);

          if (jogo == null)
          {
          return NotFound("Jogo não encontrado.");
          }

         await _context.SaveChangesAsync();
         return Ok("Jogo deletado com sucesso.");
        }
    }
}