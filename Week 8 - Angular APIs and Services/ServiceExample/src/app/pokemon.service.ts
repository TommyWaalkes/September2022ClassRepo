import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Pokemon } from './Pokemon';
import { Observable } from 'rxjs';



@Injectable({
  providedIn: 'root'
})
export class PokemonService {
baseURL:string = "https://pokeapi.co/api/v2/pokemon/"
  constructor(private http: HttpClient) { }

  GetPokemonByName(name:string):Observable<Pokemon>{
    return this.http.get<Pokemon>(this.baseURL + name);
  }
}
