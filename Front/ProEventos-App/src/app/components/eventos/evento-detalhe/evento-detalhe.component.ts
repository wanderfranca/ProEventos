import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormControl, FormGroup, Validators } from '@angular/forms';

@Component({
  selector: 'app-evento-detalhe',
  templateUrl: './evento-detalhe.component.html',
  styleUrls: ['./evento-detalhe.component.scss']
})
export class EventoDetalheComponent implements OnInit {

  form!: FormGroup;

  ngOnInit(): void {
    this.validation();
  }

  public validation(): void {
    this.form = new FormGroup({

      tema: new FormControl('',


      local: new FormControl('', Validators.required),

      dataEvento: new FormControl('', Validators.required),

      qtdPessoas: new FormControl('',
      [Validators.required, Validators.max(120000)]
      ),
      telefone: new FormControl('', Validators.required),

      email: new FormControl('',
      [Validators.required, Validators.email]),
      imagemURL: new FormControl('', Validators.required),
    });
  }

}
