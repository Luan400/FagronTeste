import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { Jogo } from './Jogo';

const httpOptions = {
  headers: new HttpHeaders({
    "Content-Type" : 'application/json'
  })
};

@Injectable({
  providedIn: 'root'
})
export class JogoService {
url = 'http://localhost:5093/api/jogos/dados';
  constructor(private http: HttpClient) { }

  SalvarPontuacao(jogo: Jogo) : Observable<any>{
    return this.http.post<Jogo>(this.url, jogo, httpOptions);
  }

  //delete caso necessario
  ExcluirJogo(Id: number) : Observable<any>{
    const apiUrl = `${this.url}/${Id}`;
    return this.http.delete<any>(apiUrl, httpOptions);
  }

  // ObterResultados(): Observable<any> {
  //   const apiUrl = `${this.url}/resultados/estatisticas`;
  //   return this.http.get<any>(apiUrl, httpOptions);
  // }
  
}
