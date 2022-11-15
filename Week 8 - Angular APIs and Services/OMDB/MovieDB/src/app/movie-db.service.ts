import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { MovieDetails } from './MovieDetails';
import { SearchResult } from './SearchResult';

@Injectable({
  providedIn: 'root'
})
export class MovieDBService {
  baseURL:string = "https://www.omdbapi.com/?apikey=62398519";
  constructor(private http: HttpClient) { }

  SearchMovies(title:string):Observable<SearchResult>{
    let url:string = this.baseURL +"&s="+title;
    return this.http.get<SearchResult>(url);
  }

  GetMovieDetails(title:string):Observable<MovieDetails>{
    let url:string = this.baseURL +"&t="+title;
    return this.http.get<MovieDetails>(url);
  }
}
