import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Injectable({
  providedIn: 'root'
})
export class AccountService {

  baseUrl = 'https://localhost:44397/api';

  constructor(private http: HttpClient) { }

  public login(email: string, password: string) {
    let loginViewModel = {
      Email: email,
      Password: password
    };
    return this.http.post(this.baseUrl + '/account', {loginViewModel}); 
  }

  public register(User: any) {
    return this.http.post(this.baseUrl + 'account/saveUser', {User});
  }
}
