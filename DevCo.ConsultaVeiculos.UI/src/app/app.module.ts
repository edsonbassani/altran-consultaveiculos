import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { HttpClientModule } from "@angular/common/http";

import { AppComponent } from './app.component';
import { VeiculosDetalhesComponent } from './veiculos-detalhes/veiculos-detalhes.component';
import { VeiculosDetalheComponent } from './veiculos-detalhes/veiculos-detalhe/veiculos-detalhe.component';
import { VeiculosDetalheService } from './shared/veiculos-detalhe.service';

@NgModule({
  declarations: [
    AppComponent,
    VeiculosDetalhesComponent,
    VeiculosDetalheComponent
  ],
  imports: [
    BrowserModule,
    FormsModule,
    HttpClientModule
  ],
  providers: [VeiculosDetalheService],
  bootstrap: [AppComponent]
})
export class AppModule { }
