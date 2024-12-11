import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup } from '@angular/forms';

import { Jogo } from 'src/app/Jogo';
import { JogoService } from '../../jogo.service';

@Component({
  selector: 'app-jogo',
  templateUrl: './jogo.component.html',
  styleUrls : ['./jogo.component.css']
})
export class JogoComponent implements OnInit {

formulario: any;
tituloFormulario: string | undefined;


constructor(private jogoService: JogoService) {}

ngOnInit(): void {
this.tituloFormulario = "Lançar Pontos"

  this.formulario = new FormGroup({
    date: new FormControl(null),
    points: new FormControl(null)
  });
}
salvarPontuacao(): void {
const jogo : Jogo = this.formulario.value;

if (!jogo.date || !jogo.points) {
  alert('Por favor, preencha todos os campos.');
  return;  
}

this.jogoService.SalvarPontuacao(jogo).subscribe({
  next: (resultado) => {
    alert('Pontuação inserida com sucesso!');
    this.formulario.reset();
  },
  error: (err) => {
    console.error('Erro ao salvar pontuação:', err);  
    alert('Erro ao salvar a pontuação. Confira o console para detalhes.');
  }
});

}

}
