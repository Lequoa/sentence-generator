import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import {}

@Injectable({
  providedIn: 'root'
})
export class SentenceService {

  constructor(private http: HttpClient) { }

  baseUrl = 'https://localhost:44397/api';

  public getSentences() { 
    return this.http.get(this.baseUrl + '/sentence'); 
  } 
  
  public addSentence(sentence: any) { 
    return this.http.post(this.baseUrl + '/sentence', {sentence}); 
  }   
}
