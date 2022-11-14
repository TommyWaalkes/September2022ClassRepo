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

  //Think of the observable as an IOU or a meal ticket, we hand that off to our component with the promise of later 
  //giving them a pokemon 
  //When the pokemon does get passed the service we can tell the Component to run some code in reaction 
  //Commonly that code will be placing the pokemon model into a variable so our component can use it however it needs. 
  GetPokemonByName(name:string):Observable<Pokemon>{

    //All rest methods which are: GET, PUT, POST, DELETE are available from the HTTP service 
    //This will come in handy for when we use our own C# APIs as this gives us full CRUD access 

    //Most 3rd party APIs will only allow gets, as the other actions alter the dataset for everyone
    return this.http.get<Pokemon>(this.baseURL + name);
  }
}
