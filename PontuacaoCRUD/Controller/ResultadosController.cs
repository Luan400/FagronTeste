using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PontuacaoCRUD.Entitites;
using PontuacaoCRUD.Models;
using PontuacaoCRUD.Infrastructure; 
using Microsoft.EntityFrameworkCore;

namespace PontuacaoCRUD.Controller
{
    
    [Route("api/[controller]")]
    [ApiController]

    public class ResultadosController : ControllerBase

    {
     
    private readonly PontuacaoDbContext _context;

    public ResultadosController(PontuacaoDbContext context)
    {
        _context = context;
    }

    [HttpGet("estatisticas")]

    public async Task<IActionResult> GetPlayerStatisticsAsync()
    {
     
    var games = await _context.Jogos.ToListAsync();

     if (games.Count() == 0)
    {
     
     return NotFound("Nenhum jogo registrado.");
    }

    var firstGameDate = games.Min(g => g.Date);
    var lastGameDate = games.Max(g => g.Date);
    var gamesPlayed = games.Count();
    var totalPoints = games.Sum(g => g.Points);
    var averagePoints = gamesPlayed > 0 ? totalPoints / (double)gamesPlayed : 0;
    var highestPoints = games.Max(g => g.Points);
    var lowestPoints = games.Where(g => g.Points > 0).Min(g => g.Points);

    
    int vezesQuebrouRecorde = 0;
    int recordeAtual = 0;


    foreach (var game in games)
    {
        
        if (game.Points > recordeAtual)
        {
            recordeAtual = game.Points;
            vezesQuebrouRecorde++;
        }
    }

   var resultados = new Resultados
    {

    FirstGameDate = firstGameDate,
    LastGameDate = lastGameDate,
    GamesPlayed = gamesPlayed,
    TotalPoints = totalPoints,
    AveragePoints = averagePoints,
    HighestPoints = highestPoints,
    LowestPoints = lowestPoints,
    vezesQuebrouRecorde = vezesQuebrouRecorde
    };

    return Ok(resultados);
    }
}

}