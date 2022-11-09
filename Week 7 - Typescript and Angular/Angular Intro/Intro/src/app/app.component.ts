//This acts like a using statement in C#, we will use to gain to other files, whether they built in, extensions, or a file you wrote yourself
import { Component } from '@angular/core';
import { Movie } from 'src/movie';

//This tells angular setting for your component. 
//This is where we set what view (HTML file) we want to use and what CSS sheet we wish to use 
@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})

//This class interacts with our view and provide data and functionality to it 
//Angular is written in TS - technically the TS syntax is optional but in general angular is expecting typescript syntax over JS
export class AppComponent {
  title = 'Intro';

  num: number = 10;
  //every property in an interface is required, it must get a value, this is to ensure consistency 
  m: Movie = {id: 1, title:"Big Lebowski", genre:"Comedy/Religion", runTime:120, isKidFriendly:false};

  movies: Movie[] = [this.m, {id: 2, title:"Shrek", genre: "Religious", runTime: 90, isKidFriendly:true}, 
                              {id: 3, title: "Diehard", genre:"action", runTime: 100, isKidFriendly:false}
];

FilterMovies(){
  //This line comes in as a generic HTML element, which lacks a value 

  let input:string = (<HTMLInputElement> document.getElementById("movieGenre")).value;

  //If we're referring to a property IE a varialbe that exists as part of a class we MUST use this. in typescript 
  //We can still create and use local variables with let, but they only exist in their function
  //this.movies.includes( (mov: Movie) => mov.genre.includes(input));

  let filteredMovies: Movie[] = [];
  for(let i = 0; i < this.movies.length; i++){
    let mov: Movie = this.movies[i];

    if(mov.genre.includes(input)){
      //This is the same as Add in C# 
      filteredMovies.push(mov);
    }
  }

  this.movies = filteredMovies;
}

//This sets the movies array to its original state
Reset(){
  this.movies = [this.m, {id: 2, title:"Shrek", genre: "Religious", runTime: 90, isKidFriendly:true}, 
  {id: 3, title: "Diehard", genre:"action", runTime: 100, isKidFriendly:false}];

}
}


//This is MVC pattern BUT each component.ts file acts as our controller 
//and components manage only 1 view at a time, unlike .net