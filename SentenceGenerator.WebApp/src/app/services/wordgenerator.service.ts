import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Injectable({
  providedIn: 'root'
})
export class WordGeneratorService {

  baseUrl = 'https://localhost:44397/api';

  constructor(private http: HttpClient) { }

  public generateWords(type: string) {
    return this.http.get(this.baseUrl + '/word/' + type);
  }
}
