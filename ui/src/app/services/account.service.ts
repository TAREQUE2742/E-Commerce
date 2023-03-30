import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { map, Observable } from 'rxjs';
import { IUserModel } from '../model/iUser-model';

@Injectable({
  providedIn: 'root'
})
export class AccountService {

  constructor(private http: HttpClient) { }

  private url= "https://localhost:5001/account";
  
  get(): Observable<IUserModel[]> {
    return this.http.get<IUserModel[]>(this.url)
    .pipe(
      map(user=>user.filter(x=>x.id!==2))
      );
  }

  getById(id: number): Observable<IUserModel> {
    return this.http.get<IUserModel>(`${this.url}/${id}`);
  }
}