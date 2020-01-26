import { Component, OnInit } from '@angular/core';
import { VeiculosDetalheService } from 'src/app/shared/veiculos-detalhe.service';
import { NgForm } from '@angular/forms';
import { VeiculosDetalhe } from 'src/app/shared/veiculos-detalhe.model';

@Component({
  selector: 'app-veiculos-detalhe',
  templateUrl: './veiculos-detalhe.component.html',
  styles: []
})
export class VeiculosDetalheComponent implements OnInit {
  formData:VeiculosDetalhe;
  constructor(private service:VeiculosDetalheService) { }

  ngOnInit() {
    this.resetForm();
  }

  resetForm(form?:NgForm){
    if(form != null)
      form.resetForm();

      this.service.formData = { 
        IdVeiculo : 0, 
        Placa: '',
        Ano_modelo: 0,
        Ano_fabricacao: 0,
        Veiculo_roubado: false,
        Proprietario: ''
      }
      
  }

  onSubmit(form:NgForm){
    this.service.postConsultarVeiculo(form.value);
    form.resetForm();
  }

  
  

}
