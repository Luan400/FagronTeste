import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { JogoComponent } from './components/jogo/jogo.component';
import { ResultadosComponent } from './components/resultados/resultados.component';

const routes: Routes = [
    {path: 'jogo', component: JogoComponent},
    {path: 'resultados', component: ResultadosComponent},
    { path: '', redirectTo: '/jogo', pathMatch: 'full' }
];

@NgModule({
    imports: [RouterModule.forRoot(routes)],
    exports: [RouterModule]
})

export class AppRoutingModule {}