import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class ConsultaCepService {

  private url: string = 'https://viacep.com.br/ws/';

  constructor(private http: HttpClient) { }
  
  buscarCEP(cep: string): Observable<any> {
    return this.http.get<any>(this.url + cep + '/json/');
  }
}
