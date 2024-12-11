using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PontuacaoCRUD.Models
{
    public class ResultadosModels
    { 
     public int Id { get; set;}   
    public DateTime FirstGameDate { get; set; }
    public DateTime LastGameDate { get; set; }
    public int GamesPlayed { get; set; } 
    public int TotalPoints { get; set; } 
    public double AveragePoints { get; set; } 
    public int HighestPoints { get; set; } 
    public int LowestPoints { get; set; } 
    public int vezesQuebrouRecorde { get; set; }

    }
}