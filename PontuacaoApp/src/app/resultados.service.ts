import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { Resultados } from './Resultados';

const httpOptions = {
  headers: new HttpHeaders({
    "Content-Type" : 'application/json'
  })
};

@Injectable({
  providedIn: 'root'
})
export class ResultadosService {
url = 'http://localhost:5093/api/resultados/estatisticas';

  constructor(private http: HttpClient) {}

  //para pegar conforme dados mudar
 PegarPontuacao(): Observable<Resultados> {
  return this.http.get<Resultados>(this.url);
 }
}
