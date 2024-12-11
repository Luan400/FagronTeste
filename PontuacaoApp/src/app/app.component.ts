import { Component } from '@angular/core';
import { Router } from '@angular/router';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styles: []
})
export class AppComponent {
  title = 'PontuacaoApp';


  constructor(private router: Router){}

  lancarPontuacao(): void {
    this.router.navigate(['/jogo']);
  }

  verResultados(): void {
    this.router.navigate(['/resultados']);
  }
}
