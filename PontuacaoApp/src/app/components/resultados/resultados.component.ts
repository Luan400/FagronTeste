import { Component, OnInit } from '@angular/core';
import { ResultadosService } from '../../resultados.service'; 
import { Resultados } from '../../Resultados';



@Component({
  selector: 'app-resultados',
  templateUrl: './resultados.component.html',
  styleUrls: ['./resultados.component.css']
})
export class ResultadosComponent implements OnInit {
 
  resultados: Resultados | null = null;
  errorMessage: string | null= null

  primeiraData: Date | null = null;
  ultimaData: Date | null = null;
  totalJogos: number = 0;
  totalPontos: number = 0;
  mediaPontos: number = 0;
  maiorPontuacao: number = 0;
  menorPontuacao: number = 0;
  vezesQuebrouRecorde: number=0;

  constructor(private resultadosService: ResultadosService){}

  ngOnInit(): void {
    this.carregarResultados();
  }

carregarResultados(): void {
  this.resultadosService.PegarPontuacao().subscribe({
    next: (data) => {
      this.resultados = data;
      this.errorMessage = null;

      if (this.resultados) {
        this.primeiraData = this.resultados.firstGameDate;
        this.ultimaData = this.resultados.lastGameDate;
        this.totalJogos = this.resultados.gamesPlayed;
        this.totalPontos = this.resultados.totalPoints;
        this.mediaPontos = this.resultados.averagePoints;
        this.maiorPontuacao = this.resultados.highestPoints;
        this.menorPontuacao = this.resultados.lowestPoints;
        this.vezesQuebrouRecorde = this.resultados.vezesQuebrouRecorde;
      }
    },
    error: (error) => {
      this.errorMessage = "Erro ao carregar os resultados."
      console.log(error);
    },
  })
 }

}
