import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders} from '@angular/common/http';
import { Observable } from 'rxjs';
import { Comentario } from '../models/comentario';

@Injectable({
  providedIn: 'root'
})
export class ComentarioService {
  myAppUrl = 'https://localhost:44314';
  myApiUrl = '/api/comentario/';

  httpOptions = {
    headers: new HttpHeaders({
      'Content-Type': 'application/json'
    })
  }

  constructor(private http: HttpClient) { }

  getListComentario(): Observable<Comentario[]> {
      return this.http.get<Comentario[]>(this.myAppUrl + this.myApiUrl);
  }

  deleteComentario(id: number): Observable<Comentario> {
    return this.http.delete<Comentario>(this.myAppUrl + this.myApiUrl + id);
  }

  saveComentario(comentario: Comentario): Observable<Comentario> {
    return this.http.post<Comentario>(this.myAppUrl + this.myApiUrl, comentario, this.httpOptions);
  }

  singleComentario(id: number): Observable<Comentario> {
    return this.http.get<Comentario>(this.myAppUrl + this.myApiUrl + id);
  }

  updateComentario(comentario: Comentario, id: number): Observable<Comentario>{
    return this.http.put<Comentario>(this.myAppUrl + this.myApiUrl + id, comentario, this.httpOptions);
  }
}
