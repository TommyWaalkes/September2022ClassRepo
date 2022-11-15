import { Component, Input, OnInit } from '@angular/core';
import { MovieDetails } from '../MovieDetails';

@Component({
  selector: 'app-movie-details',
  templateUrl: './movie-details.component.html',
  styleUrls: ['./movie-details.component.css']
})
export class MovieDetailsComponent implements OnInit {
  @Input() displayMovie: MovieDetails ={} as MovieDetails;
  constructor() { }

  ngOnInit(): void {
  }

}
