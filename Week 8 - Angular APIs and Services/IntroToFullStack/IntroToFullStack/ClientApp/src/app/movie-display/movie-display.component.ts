import { Component, OnInit } from '@angular/core';
import { Movie } from '../movie';
import { MovieService } from '../movie.service';

@Component({
  selector: 'app-movie-display',
  templateUrl: './movie-display.component.html',
  styleUrls: ['./movie-display.component.css']
})
export class MovieDisplayComponent implements OnInit {
  movies: Movie[] =[];
  constructor(private movieApi: MovieService) { 
    this.movieApi.GetAllMovies().subscribe(
      (results: Movie[]) => {this.movies = results;}
    )
  }

  ngOnInit(): void {
  }



}
