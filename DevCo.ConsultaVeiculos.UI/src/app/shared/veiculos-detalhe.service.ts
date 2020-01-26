import { Injectable, ɵConsole } from '@angular/core';
import { VeiculosDetalhe } from './veiculos-detalhe.model'
import { HttpClient, HttpParams, HttpHeaders } from "@angular/common/http";
import { stringify } from 'querystring';
@Injectable({
  providedIn: 'root'
})
export class VeiculosDetalheService {
  formData:VeiculosDetalhe;
  readonly rootURL = 'https://localhost:44380/api';
  list:VeiculosDetalhe[];
 
  

  constructor(private http:HttpClient) { }

  postConsultarVeiculo(formData:VeiculosDetalhe){
   const headers = new HttpHeaders().set('content-type', 'application/json');
   this.http.post(this.rootURL + '/consulta-placa/', JSON.stringify(new String(formData.Placa)), {headers})
   .toPromise().
   then(res => 
    this.list = res as VeiculosDetalhe[], 
    err => this.list = null
    );
 }

}
 