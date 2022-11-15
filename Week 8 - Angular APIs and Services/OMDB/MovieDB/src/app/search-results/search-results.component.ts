import { Component, Input, OnInit } from '@angular/core';
import { MovieDBService } from '../movie-db.service';
import { Search, SearchResult } from '../SearchResult';
import { MovieDetails } from '../MovieDetails';

@Component({
  selector: 'app-search-results',
  templateUrl: './search-results.component.html',
  styleUrls: ['./search-results.component.css']
})
export class SearchResultsComponent implements OnInit {

  //This allows Search results to get passed down into this component
  @Input() results: SearchResult[] =[];
  movieToDisplay: MovieDetails = {} as MovieDetails;
  constructor(private movieService: MovieDBService) { }

  ngOnInit(): void {
  }

  DisplayDetails(s:Search, i:number):MovieDetails{
   
    this.movieService.GetMovieDetails(s.Title).subscribe(
      (m:MovieDetails) => {
        this.movieToDisplay = m;
        console.log(m);
        let display = document.getElementById(i.toString());
        display?.setAttribute("style", "display:block");

      }
    );

    return this.movieToDisplay;

  }
  

}
