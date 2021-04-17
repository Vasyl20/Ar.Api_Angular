import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { ApiResponse } from '../Models/api.response';
import { LoginModel } from '../Models/login.model';
import { RegisterModel } from '../Models/register.model';
import jwt_decode from "jwt-decode";


@Injectable({
  providedIn: 'root'
})
export class AuthService {
[x: string]: any;

constructor(private http: HttpClient) { }

token_data: any;
token = localStorage.getItem('token');
baseUrl = "/api/Account";

register(model: RegisterModel): Observable<ApiResponse> {
  return this.http.post<ApiResponse>(this.baseUrl + "/register", model)
}

login(model: LoginModel): Observable<ApiResponse> {
  return this.http.post<ApiResponse>(this.baseUrl + "/login", model)
}

isAdmin(): boolean {
   if(this.token != null) {
     this.token_data = jwt_decode(this.token);
     if(this.token_data.roles == "Admin") {
       return true;
     } else {
       return false;
     }
   } else {
       return false;
   }
  }
    isLoggedIn(): boolean {
     if(this.token != null) {
       return true;
     } else {
       return false;
     }
   }
   
  
   Logout() {
    localStorage.removeItem('token');
   }
}
                                               