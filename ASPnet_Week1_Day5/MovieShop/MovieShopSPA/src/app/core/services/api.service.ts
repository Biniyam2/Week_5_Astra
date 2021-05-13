import { Injectable } from '@angular/core';
import {HttpClient} from '@angular/common/http'
import {environment } from 'src/environments/environment'
import { Observable } from 'rxjs';
import {map} from 'rxjs/operators';
@Injectable({
  providedIn: 'root'
})
export class ApiService {
//HttpClinet => used to communicate with API
  constructor(protected http: HttpClient) { }

  getList(path: string): Observable<any[]>
  {
//var apiUrl = environment.apiUrl;
 return this.http.get(`${environment.apiUrl}${path}`).pipe(map(resp => resp as any[]))
  }
  getOne(path:string) : Observable<any>
  {

    return this.http.get(`${environment.apiUrl}${path}`).pipe(map(resp => resp as any))
  }
  create(path:string): Observable<any>
  {
    return this.http.get(`${environment.apiUrl}${path}`).pipe(map(resp => resp as any))
  }
  update(path:string): Observable<any>
  {
    return this.http.get(`${environment.apiUrl}${path}`).pipe(map(resp => resp as any))
  }
  delete(path:string): Observable<any>
  {
    return this.http.get(`${environment.apiUrl}${path}`).pipe(map(resp => resp as any))
  }
}
