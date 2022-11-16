import { HttpClient } from '@angular/common/http';
import { Inject, Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { Movie } from './movie';

@Injectable({
  providedIn: 'root'
})
export class MovieService {
  urlBase:string ="";

  //The inject justs get us the local host info, we still put in the controller and endpoint 
  constructor(private http:HttpClient, @Inject('BASE_URL') baseUrl: string) { 
    this.urlBase = baseUrl;
  }

  GetAllMovies(): Observable<Movie[]>{
    return this.http.get<Movie[]>(this.urlBase+"api/movie");
  }
}
