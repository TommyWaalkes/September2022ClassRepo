import { Component } from '@angular/core';
import { MovieDBService } from './movie-db.service';
import { SearchResult } from './SearchResult';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  title = 'MovieDB';
  results: SearchResult[] =[];
  searchTitle:string ="";

  constructor(private movieApi: MovieDBService){
    this.movieApi.SearchMovies("Dune").subscribe(
      (results:SearchResult) => {
        console.log(results);
      }
    )
  }

  SearchMovies(title:string):void{
    this.movieApi.SearchMovies(title).subscribe(
      (results: SearchResult) => {
        this.results[0] = results;
        console.log(results);
      }
    );
  }
}
