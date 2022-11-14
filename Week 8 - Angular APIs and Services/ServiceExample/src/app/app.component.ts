//Imports and export are features from Node.JS, anything that uses node can do that
import { Component } from '@angular/core';
import { Pokemon } from './Pokemon';
import { PokemonService } from './pokemon.service';
import { RandomNumberGenerationService } from './random-number-generation.service';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  title = 'ServiceExample';

  output:number = 0; 
  resultPokemon: Pokemon[] =[];
  searchName:string ="";

  //How Dependency is done in angular is that in the constructor for our component, 
  //We will create a private parameter, which Angular sees and knows to treat as a dependency injection 
  constructor(private rng: RandomNumberGenerationService, private pokeAPI: PokemonService){
    this.output = this.rng.GetRandomNumber(1,10);
  }

  //The job of this method is to delegate to our service
  GetRandomNum(min: number, max:number):number{
    return this.rng.GetRandomNumber(min, max);
  }

  UpdateOutput(){
    this.output = this.GetRandomNum(1,10);
  }

  //It is a convention to delegate calls to your API in your Component class 
  //That way all calls are in the same and we don't have to go searching for them 
  //Avoid using services directly in the view, unless there's no other way to get it working 
  SearchPokemonByName(name:string):void{
    //Given this is an HTTP call, we need to wait for our meal ticket and react once we get it 
    this.pokeAPI.GetPokemonByName(name).subscribe( (result: Pokemon) =>{ 
      this.resultPokemon.push(result);
    });
  }
}
