import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Injectable({
  providedIn: 'root'
})
export class RegisterService {

  constructor(private http: HttpClient) { }

  baseUrl = 'https://localhost:44397/api';

  public getUser() { 
    return this.http.get(this.baseUrl + '/user'); 
  } 
  
  public addUser(user: any) { 
    return this.http.post(this.baseUrl + '/user', {user}); 
  }   
}
